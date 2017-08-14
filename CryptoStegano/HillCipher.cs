using System.IO;
using System.Text;

namespace CryptoStegano
{
    public class HillCipher : Cipher<HillKey>
    {
        private const string encryptedFileExtension = ".hil";
        public override string EncryptedFileExtension => encryptedFileExtension;

        private void EncryptDigram(Digram digram, HillKey encryptKey) // It doesn't calculate values modulo N (256), because during writing character to the output file, we have to cast it to byte anyway.
        {
            digram.MultiplyBy(encryptKey.Matrix);
            digram.Add(encryptKey.Digram);
        }

        private void EncryptAndWriteDigram(Digram digram, HillKey encryptKey, FileStream outputStream)
        {
            EncryptDigram(digram, encryptKey);
            outputStream.WriteByte((byte)digram[0]); // Write character which correspond to encrypted byte to the output file.
            outputStream.WriteByte((byte)digram[1]);
        }

        private Digram ReadAndDecryptDigram(FileStream inputStream, HillKey decryptKey)
        {
            Digram digram = new Digram();
            digram[0] = inputStream.ReadByte();
            digram[1] = inputStream.ReadByte();
            EncryptDigram(digram, decryptKey);
            Ring.Modulo(digram, Ring.N); // Modulo values needed during: equalizing file length, obtaining extension length, and obtaining correct extension characters
            return digram;               // (after decrypting, read bytes can exceed byte range)
        }

        protected override void EncryptFileExtension(string inputFilePath, FileStream outputStream, HillKey encryptKey)
        {
            Digram digram = new Digram();
            string extension = Path.GetExtension(inputFilePath);
            extension = extension.Substring(1); // Remove dot from extension. (To encrypt dot, remove this line and don't add dot in DecryptFileExtension. Also set correct position in Cryptoanalyser GetKey method.)

            if (extension.Length % 2 == 0)
            {
                digram[0] = extension.Length; // First number is extension length.
                digram[1] = Randomizer.Next(256); // First digram = [extension.Length, randomByte], when extension length is even.
                EncryptAndWriteDigram(digram, encryptKey, outputStream);

                for (int i = 1; i <= extension.Length - 1; i += 2)
                {
                    digram[0] = extension[i - 1];
                    digram[1] = extension[i];
                    EncryptAndWriteDigram(digram, encryptKey, outputStream);
                }
            }
            else
            {
                digram[0] = extension.Length; // First number is extension length.
                digram[1] = extension[0]; // First digram = [extension.Length, firstExtensionCharacter], when extension length is odd.
                EncryptAndWriteDigram(digram, encryptKey, outputStream);

                for (int i = 1; i <= extension.Length - 2; i += 2)
                {
                    digram[0] = extension[i];
                    digram[1] = extension[i + 1];
                    EncryptAndWriteDigram(digram, encryptKey, outputStream);
                }
            }
        }

        protected override string DecryptFileExtension(FileStream inputStream, HillKey decryptKey)
        {
            Digram digram = ReadAndDecryptDigram(inputStream, decryptKey);
            int extensionLength = digram[0]; // Read extension length.
            StringBuilder extensionStringBuilder = new StringBuilder();
            if (extensionLength % 2 == 1) // If extension length is odd
                extensionStringBuilder.Append((char)digram[1]); // we have to append second character from first extension digram, because it is first character of the extension (not random byte)
            for (int i = 1; i <= extensionLength / 2; i++)
            {
                digram = ReadAndDecryptDigram(inputStream, decryptKey);
                extensionStringBuilder.Append((char)digram[0]);
                extensionStringBuilder.Append((char)digram[1]);
            }
            extensionStringBuilder.Insert(0, '.');
            return extensionStringBuilder.ToString();
        }

        protected override void EqualizeFileLengthEncryption(FileStream inputStream, FileStream outputStream, HillKey encryptKey)
        {
            Digram digram = new Digram();
            if (inputStream.Length % 2 == 1) // If file length is odd
            {
                // then add random number between [0;127].
                digram[0] = Randomizer.Next(128);
                digram[1] = inputStream.ReadByte();
            }
            else // If file length is even
            {
                // then add two random numbers, where first is between [128;255] and second is between [0;255].
                digram[0] = 128 + Randomizer.Next(128);
                digram[1] = Randomizer.Next(256);
            }
            EncryptAndWriteDigram(digram, encryptKey, outputStream);
        }

        protected override void EqualizeFileLengthDecryption(FileStream inputStream, FileStream outputStream, HillKey decryptKey)
        {
            Digram digram = ReadAndDecryptDigram(inputStream, decryptKey);

            if (digram[0] < 128) // If file length is odd
                outputStream.WriteByte((byte)digram[1]); // then first byte is random, but second must be written to the output file.
            // If file length is even, then both bytes are random.
        }

        protected override void EncryptUntilEndOfFile(FileStream inputStream, FileStream outputStream, HillKey encryptKey)
        {

            Digram digram = new Digram();
            bool endOfFile = false;
            while (!endOfFile)
            {
                digram[0] = inputStream.ReadByte();
                endOfFile = digram[0] == -1;
                if (!endOfFile)
                {
                    digram[1] = inputStream.ReadByte();
                    EncryptAndWriteDigram(digram, encryptKey, outputStream);
                    SetProgressPercentageAndCheckCancellation(inputStream);
                }
                else
                    NotifyFinishedWork();
            }
        }
    }
}
