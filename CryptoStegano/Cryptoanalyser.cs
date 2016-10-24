using System;
using System.Collections.Generic;
using System.IO;

namespace CryptoStegano
{
    public class Cryptoanalyser
    {
        private static readonly Dictionary<string, byte[]> sygnatures = new Dictionary<string, byte[]>()
        {
            //  key.A * byte_from_array + key.B = encrypted_byte
            { "png", new byte[] { 0x89, 0x50, 0x4E, 0x47 } },
            { "zip", new byte[] { 0x50, 0x4B, 0x03, 0x04 } },
            { "mp3", new byte[] { 0x49, 0x44, 0x33, 0x03 } },
            { "jpg", new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 } },
            { "pdf", new byte[] { 0x25, 0x50, 0x44, 0x46 } },
        };

        //public static string SupportedFilesExtensions => sygnatures.Keys.;

        private AffineCipher affineCipher = new AffineCipher();

        private AffineKey CalculateEncryptKey(int sygnatureByte1, int encryptedSygnatureByte1, int sygnetureByte2, int encryptedSygnatureByte2)
        {
            int deltaSygnatureBytes = sygnatureByte1 - sygnetureByte2;
            int deltaEncryptedSygnatureBytes = encryptedSygnatureByte1 - encryptedSygnatureByte2;
            int keyA = Ring.Modulo(deltaEncryptedSygnatureBytes * Ring.Inverse(deltaSygnatureBytes, Ring.N), Ring.N);
            int keyB = Ring.Modulo(encryptedSygnatureByte1 - keyA * sygnatureByte1, Ring.N);
            AffineKey encryptKey = new AffineKey(keyA, keyB);
            return encryptKey;
        }

        private AffineKey GetKey(FileStream inputFileStream, string extension)
        {
            inputFileStream.Position += extension.Length; // Jump over encrypted extension.
            int encryptedSygnatureByte1 = inputFileStream.ReadByte();
            int encryptedSygnatureByte2 = inputFileStream.ReadByte();
            byte sygnatureByte1 = sygnatures[extension][0];
            byte sygnatureByte2 = sygnatures[extension][1];
            AffineKey encryptKey = CalculateEncryptKey(sygnatureByte1, encryptedSygnatureByte1, sygnatureByte2, encryptedSygnatureByte2);
            return encryptKey;
        }

        public bool DecryptFile(string inputFilePath, string extension)
        {
            string outputFilePath = Path.ChangeExtension(inputFilePath, extension);
            AffineKey encryptKey;
            using (FileStream inputFileStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            {
                encryptKey = GetKey(inputFileStream, extension);
            }
            affineCipher.DecryptFile(inputFilePath, outputFilePath, encryptKey);
            return true;
        }
    }
}
