using System;
using System.IO;
using System.Text;

namespace CryptoStegano
{
    public class AffineCipher : ICipher<AffineKey>
    {
        private const string encryptedFileExtension = ".aff";

        public string EncryptedFileExtension => encryptedFileExtension;

        private int EncryptCharacter(int character, AffineKey encryptKey) =>
            encryptKey.A * character + encryptKey.B; // It doesn't return value modulo N (256), because during writing character to the output file, we have to cast it to byte anyway.

        private void EncryptAndWriteCharacter(int character, AffineKey encryptKey, FileStream outputFileStream)
        {
            int encryptedCharacter = EncryptCharacter(character, encryptKey);
            outputFileStream.WriteByte((byte)encryptedCharacter); // Write character which correspond to encrypted byte to the output file.
        }

        private void EncryptFileExtension(string inputFilePath, FileStream outputFileStream, AffineKey encryptKey)
        {
            string extension = Path.GetExtension(inputFilePath);
            extension = extension.Substring(1); // Remove dot from extension. (To encrypt dot, remove this line and don't add dot in DecryptFileExtension. Also set correct position in Cryptoanalyser GetKey method.)
            int extensionLength = extension.Length;
            EncryptAndWriteCharacter(extensionLength, encryptKey, outputFileStream);
            for (int i = 0; i <= extensionLength - 1; i++)
                EncryptAndWriteCharacter(extension[i], encryptKey, outputFileStream);
        }

        private string DecryptFileExtension(FileStream inputFileStream, AffineKey decryptKey)
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

        private void EncryptUntilEndOfFile(FileStream inputFileStream, FileStream outputFileStream, AffineKey encryptKey)
        {
            int inputCharacter;
            bool notEndOfFile;
            do
            {
                inputCharacter = inputFileStream.ReadByte(); // Read character as ASCII number.
                notEndOfFile = inputCharacter != -1;
                if (notEndOfFile)
                    EncryptAndWriteCharacter(inputCharacter, encryptKey, outputFileStream);
            }
            while (notEndOfFile);
        }

        public bool IsEncryptedFile(string filePath) =>
            String.Equals(Path.GetExtension(filePath), encryptedFileExtension, StringComparison.InvariantCultureIgnoreCase);

        public void EncryptFile(string inputFilePath, string outputFilePath, AffineKey encryptKey) // outputFilePath - full output file path without extension; method adds extension
        {
            using (FileStream inputFileStream = StreamMaker.MakeInputStream(inputFilePath), outputFileStream = StreamMaker.MakeOutputStream(outputFilePath + encryptedFileExtension))
            {
                EncryptFileExtension(inputFilePath, outputFileStream, encryptKey);
                EncryptUntilEndOfFile(inputFileStream, outputFileStream, encryptKey);
            }
        }

        public void DecryptFile(string inputFilePath, string outputFilePath, AffineKey encryptKey)
        {
            AffineKey decryptKey = encryptKey.GetInverseMod(Ring.N);

            using (FileStream inputFileStream = StreamMaker.MakeInputStream(inputFilePath), outputFileStream = StreamMaker.MakeOutputStream(outputFilePath + DecryptFileExtension(inputFileStream, decryptKey)))
            {
                EncryptUntilEndOfFile(inputFileStream, outputFileStream, decryptKey);
            }
        }

        internal void DecryptFile(FileStream inputFileStream, string outputFilePath, AffineKey encryptKey) // outputFilePath - with correct extension given by Cryptoanalyser
        {
            AffineKey decryptKey = encryptKey.GetInverseMod(Ring.N);

            using (FileStream outputFileStream = StreamMaker.MakeOutputStream(outputFilePath))
            {
                EncryptUntilEndOfFile(inputFileStream, outputFileStream, decryptKey);
            }
        }
    }
}
