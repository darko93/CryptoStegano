using System;
using System.IO;
using System.Text;

namespace CryptoStegano
{
    public class AffineCipher : Cipher<AffineKey>
    {
        private const string encryptedFileExtension = ".aff";

        public override string EncryptedFileExtension => encryptedFileExtension;

        private int EncryptCharacter(int character, AffineKey encryptKey) =>
            encryptKey.A * character + encryptKey.B; // It doesn't return value modulo N (256), because during writing character to the output file, we have to cast it to byte anyway.

        private void EncryptAndWriteCharacter(int character, AffineKey encryptKey, FileStream outputFileStream)
        {
            int encryptedCharacter = EncryptCharacter(character, encryptKey);
            outputFileStream.WriteByte((byte)encryptedCharacter); // Write character which correspond to encrypted byte to the output file.
        }

        protected override void EncryptFileExtension(string inputFilePath, FileStream outputFileStream, AffineKey encryptKey)
        {
            string extension = Path.GetExtension(inputFilePath);
            extension = extension.Substring(1); // Remove dot from extension. (To encrypt dot, remove this line and don't add dot in DecryptFileExtension. Also set correct position in Cryptoanalyser GetKey method.)
            int extensionLength = extension.Length;
            EncryptAndWriteCharacter(extensionLength, encryptKey, outputFileStream);
            for (int i = 0; i <= extensionLength - 1; i++)
                EncryptAndWriteCharacter(extension[i], encryptKey, outputFileStream);
        }

        protected override string DecryptFileExtension(FileStream inputFileStream, AffineKey decryptKey)
        {
            int inputCharacter = inputFileStream.ReadByte(); // Read encrypted extension length.
            int extensionLength = Ring.Modulo(EncryptCharacter(inputCharacter, decryptKey), Ring.N);
            int decryptedExtensionCharacter;
            StringBuilder extensionStringBuilder = new StringBuilder();

            for (int i = 1; i <= extensionLength; i++)
            {
                inputCharacter = inputFileStream.ReadByte();
                decryptedExtensionCharacter = Ring.Modulo(EncryptCharacter(inputCharacter, decryptKey), Ring.N);
                extensionStringBuilder.Append((char)decryptedExtensionCharacter);
            }

            extensionStringBuilder.Insert(0, '.');
            return extensionStringBuilder.ToString();
        }

        protected override void EncryptUntilEndOfFile(FileStream inputStream, FileStream outputStream, AffineKey encryptKey)
        {
            int inputCharacter;
            bool endOfFile = false;
            while (!endOfFile)
            {
                inputCharacter = inputStream.ReadByte();
                endOfFile = inputCharacter == -1;
                if (!endOfFile)
                {
                    EncryptAndWriteCharacter(inputCharacter, encryptKey, outputStream);
                    SetProgressPercentageAndCheckCancellation(inputStream);
                }
                else
                    NotifyFinishedWork();
            }
        }

        //internal void DecryptFile(FileStream inputFileStream, string outputFilePath, AffineKey encryptKey) // outputFilePath - with correct extension given by Cryptoanalyser
        //{
        //    AffineKey decryptKey = encryptKey.GetInverseMod(Ring.N);

        //    using (FileStream outputStream = StreamMaker.MakeOutputStream(outputFilePath))
        //    {
        //        EncryptUntilEndOfFile(inputFileStream, outputStream, decryptKey);
        //    }
        //}
    }
}
