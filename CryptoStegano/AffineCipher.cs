﻿using System.IO;
using System.Text;

namespace CryptoStegano
{
    class AffineCipher : Cipher
    {
        const string encryptedFileExtension = ".aff";

        protected override string EncryptedFileExtension => encryptedFileExtension;

        int EncryptCharacter(int character, AffineKey encryptKey) =>
            encryptKey.A * character + encryptKey.B; // It doesn't return value modulo N, because during writing character to the output file, we have to cast it to byte anyway.

        void EncryptAndWriteCharacter(int character, AffineKey encryptKey, FileStream outputFileStream)
        {
            int cryptedCharacter = EncryptCharacter(character, encryptKey);
            outputFileStream.WriteByte((byte)cryptedCharacter); // Write character which correspond to encrypted byte to the output file.
        }

        void EncryptFileExtension(string inputFilePath, FileStream outputFileStream, AffineKey encryptKey)
        {
            string extension = Path.GetExtension(inputFilePath);
            extension = extension.Substring(1); // Remove dot from extension. (To encrypt dot, remove this line and don't add dot in DecryptFileExtension)
            int extensionLength = extension.Length;
            EncryptAndWriteCharacter(extensionLength, encryptKey, outputFileStream);
            for (int i = 0; i <= extensionLength - 1; i++)
                EncryptAndWriteCharacter(extension[i], encryptKey, outputFileStream);
        }

        string DecryptFileExtension(FileStream inputFileStream, AffineKey decryptKey)
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

        void EncryptUntilEndOfFile(FileStream inputFileStream, FileStream outputFileStream, AffineKey encryptKey)
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

        public void EncryptFile(string inputFilePath, string outputFilePath, AffineKey encryptKey)
        {
            using (FileStream inputFileStream = MakeInputStream(inputFilePath), outputFileStream = MakeOutputStream(outputFilePath + encryptedFileExtension))
            {
                EncryptFileExtension(inputFilePath, outputFileStream, encryptKey);
                EncryptUntilEndOfFile(inputFileStream, outputFileStream, encryptKey);
            }
        }

        public void DecryptFile(string inputFilePath, string outputFilePath, AffineKey encryptKey)
        {
            AffineKey decryptKey = encryptKey.GetInverseMod(Ring.N);

            using (FileStream inputFileStream = MakeInputStream(inputFilePath), 
                    outputFileStream = MakeOutputStream(outputFilePath + DecryptFileExtension(inputFileStream, decryptKey)))
            {
                EncryptUntilEndOfFile(inputFileStream, outputFileStream, decryptKey);
            }
        }
    }
}