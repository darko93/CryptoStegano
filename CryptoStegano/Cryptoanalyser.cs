using System;
using System.Collections.Generic;
using System.IO;

namespace CryptoStegano
{
    public class Cryptoanalyser
    {
        // Contains values associated with signature bytes, which allow calculate encypt key.
        private class Signature
        {
            public int Byte1 { get; private set; } // Byte 1 from signature, from which encrypt key is calculated.
            public int Byte2 { get; private set; } // Byte 2 from signature, from which encrypt key is calculated.
            public int Byte1Position { get; private set; } // Position of Byte1 in extension signature, eg. position of 'D' in "%PDF" is 2.
            public int Byte2Position { get; private set; } // Position of Byte2 in extension signature.

            public int DeltaBytes => Byte2 - Byte1;
            public int DeltaBytesPositions => Byte2Position - Byte1Position;

            public Signature(int byte1, int byte2, int byte1Position, int byte2Position)
            {
                Byte1 = byte1;
                Byte2 = byte2;
                Byte1Position = byte1Position;
                Byte2Position = byte2Position;
            }
        }

        private AffineCipher affineCipher = new AffineCipher();
        private readonly Dictionary<string, Signature> signatures = null;

        public Cryptoanalyser()
        {
            signatures = new Dictionary<string, Signature>(5, StringComparer.OrdinalIgnoreCase);

            // I know, that all of these signatures are acceptable - key can be calculated from first two bytes of each array.
            // key.A * byte_from_array + key.B = encrypted_byte
            AddExtensionAndSignatureBytes("png", new byte[] { 0x89, 0x50, 0x4E, 0x47 });
            AddExtensionAndSignatureBytes("zip", new byte[] { 0x50, 0x4B, 0x03, 0x04 });
            AddExtensionAndSignatureBytes("mp3", new byte[] { 0x49, 0x44, 0x33, 0x03 });
            AddExtensionAndSignatureBytes("jpg", new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 });
            AddExtensionAndSignatureBytes("pdf", new byte[] { 0x25, 0x50, 0x44, 0x46 });
        }

        public bool AddExtensionAndSignatureBytes(string extension, byte[] signatureBytes)
        {
            // Look for pair of signature bytes, which difference is invertible modulo 256, so encrypt key can be calculated.
            for (int signatureByte1Position = 0; signatureByte1Position < signatureBytes.Length; signatureByte1Position++)
            {
                for (int signatureByte2Position = signatureByte1Position + 1; signatureByte2Position < signatureBytes.Length; signatureByte2Position++)
                {
                    int signatureByte1 = signatureBytes[signatureByte1Position];
                    int signatureByte2 = signatureBytes[signatureByte2Position];
                    if (Ring.IsInvertibleMod(signatureByte1 - signatureByte2, Ring.N))
                    {
                        // Found such pair of bytes, so add them and their numbers in signature array.
                        signatures.Add(extension, new Signature(signatureByte1, signatureByte2, signatureByte1Position, signatureByte2Position));
                        return true;
                    }
                }
            }
            return false; // Not found such pair, so key cannot be balculated from given signature bytes and given extension isn't acceptable.
        }

        //private static readonly Dictionary<string, byte[]> signatures3 = new Dictionary<string, byte[]>(StringComparer.OrdinalIgnoreCase)
        //{
        //    //  key.A * byte_from_array + key.B = encrypted_byte
        //    { "png", new byte[] { 0x89, 0x50, 0x4E, 0x47 } },
        //    { "zip", new byte[] { 0x50, 0x4B, 0x03, 0x04 } },
        //    { "mp3", new byte[] { 0x49, 0x44, 0x33, 0x03 } },
        //    { "jpg", new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 } },
        //    { "pdf", new byte[] { 0x25, 0x50, 0x44, 0x46 } },
        //};

        public string[] GetSupportedFileExtensions
        {
            get
            {
                string[] supportedFileExtension = new string[signatures.Count];
                int i = 0;
                foreach (string extension in signatures.Keys)
                    supportedFileExtension[i++] = extension;
                return supportedFileExtension;
            }
        }

        private AffineKey CalculateEncryptKey(Signature signature, int encryptedSignatureByte1, int encryptedSignatureByte2)
        {
            int deltaSygnatureBytes = -signature.DeltaBytes; // Yes, I need minus delta.
            int deltaEncryptedSygnatureBytes = encryptedSignatureByte1 - encryptedSignatureByte2; // Yes, I need minus delta.
            int keyA = Ring.Modulo(deltaEncryptedSygnatureBytes * Ring.Inverse(deltaSygnatureBytes, Ring.N), Ring.N);
            int keyB = Ring.Modulo(encryptedSignatureByte1 - keyA * signature.Byte1, Ring.N);
            AffineKey encryptKey = new AffineKey(keyA, keyB);
            return encryptKey;
        }

        //private AffineKey CalculateEncryptKey(int signatureByte1, int encryptedSignatureByte1, int signatureByte2, int encryptedSignatureByte2)
        //{
        //    int deltaSygnatureBytes = signatureByte1 - signatureByte2;
        //    int deltaEncryptedSygnatureBytes = encryptedSignatureByte1 - encryptedSignatureByte2;
        //    int keyA = Ring.Modulo(deltaEncryptedSygnatureBytes * Ring.Inverse(deltaSygnatureBytes, Ring.N), Ring.N);
        //    int keyB = Ring.Modulo(encryptedSignatureByte1 - keyA * signatureByte1, Ring.N);
        //    AffineKey encryptKey = new AffineKey(keyA, keyB);
        //    return encryptKey;
        //}

        //private AffineKey GetKey2(FileStream inputFileStream, string extension)
        //{
        //    inputFileStream.Position += 1 + extension.Length; // Jump over encrypted extension, where first character means extension length.
        //    int encryptedSygnatureByte1 = inputFileStream.ReadByte();
        //    int encryptedSygnatureByte2 = inputFileStream.ReadByte();
        //    byte sygnatureByte1 = sygnatures[extension][0];
        //    byte sygnatureByte2 = sygnatures[extension][1];
        //    AffineKey encryptKey = CalculateEncryptKey(sygnatureByte1, encryptedSygnatureByte1, sygnatureByte2, encryptedSygnatureByte2);
        //    return encryptKey;
        //}

        //private AffineKey GetKey(FileStream inputFileStream, string originalExtension)
        //{
        //    inputFileStream.Position += 1 + originalExtension.Length; // Jump over encrypted extension, where first character means extension length.

        //    byte[] extensionSignatureBytes = signatures[originalExtension];
        //    int signatureBytesAmount = extensionSignatureBytes.Length;

        //    int[] encryptedSignatureBytes = new int[signatureBytesAmount];
        //    for (int i = 0; i < signatureBytesAmount; i++)
        //        encryptedSignatureBytes[i] = inputFileStream.ReadByte();

        //    // Variables associated with sygnature bytes, which difference is invertible modulo 256, so encrypt key can be calculated.
        //    int signatureByte1 = 0;
        //    int signatureByte2 = 0;
        //    int signatureByte1Number = 0;
        //    int signatureByte2Number = 0;

        //    // Look for pair of sygnature bytes, which difference is invertible modulo 256, so encrypt key can be calculated.
        //    for (signatureByte1Number = 0; signatureByte1Number < signatureBytesAmount; signatureByte1Number++)
        //    {
        //        for (signatureByte2Number = signatureByte1Number + 1; signatureByte2Number < signatureBytesAmount; signatureByte2Number++)
        //        {
        //            signatureByte1 = extensionSignatureBytes[signatureByte1Number];
        //            signatureByte2 = extensionSignatureBytes[signatureByte2Number];
        //            if (Ring.IsInvertibleMod(signatureByte1 - signatureByte2, Ring.N))
        //                goto FoundPairOfSygnatureBytesWhichDifferenceIsInvertibleModulo256;
        //        }
        //    }
        //    FoundPairOfSygnatureBytesWhichDifferenceIsInvertibleModulo256:

        //    // Calculate encrypt key.
        //    AffineKey encryptKey = CalculateEncryptKey(signatureByte1, encryptedSignatureBytes[signatureByte1Number], signatureByte2, encryptedSignatureBytes[signatureByte2Number]);

        //    return encryptKey;
        //}

        private AffineKey GetEncryptKey(FileStream inputFileStream, string originalExtension)
        {
            inputFileStream.Position += 1 + originalExtension.Length; // Jump over encrypted extension, where first character means extension length.
            long positionBehindEncryptedExtension = inputFileStream.Position;

            Signature fileSignature = signatures[originalExtension];

            inputFileStream.Position += fileSignature.Byte1Position;
            int encryptedSignatureByte1 = inputFileStream.ReadByte();
            inputFileStream.Position += fileSignature.DeltaBytesPositions - 1;
            int encyptedSignatureByte2 = inputFileStream.ReadByte();

            inputFileStream.Position = positionBehindEncryptedExtension;

            AffineKey encryptKey = CalculateEncryptKey(fileSignature, encryptedSignatureByte1, encyptedSignatureByte2);
            //AffineKey encryptKey = CalculateEncryptKey(extensionSignatureProperties.Byte1, encryptedSignatureByte1, extensionSignatureProperties.Byte2, encyptedSignatureByte2);
            return encryptKey;
        }

        public bool DecryptFile(string inputFilePath, string outputFilePath) // outputFilePath - with correct extension
        {
            string originalExtension = Path.GetExtension(outputFilePath);

            // Check if signatures dictionary contains such extension.
            if (!signatures.ContainsKey(originalExtension))
                return false;

            using (FileStream inputFileStream = StreamMaker.MakeInputStream(inputFilePath))
            {
                //inputFileStream.Position += 1 + originalExtension.Length; // Jump over encrypted extension, where first character means extension length.
                //long positionBehindExtension = inputFileStream.Position;

                AffineKey encryptKey = GetEncryptKey(inputFileStream, originalExtension);

                //inputFileStream.Position = positionBehindExtension;

                affineCipher.DecryptFile(inputFileStream, outputFilePath, encryptKey);
            }
            return true;
        }
    }
}
// dodać abstract class Cipher<TKey> : ICipher<TKey> where TKey : IKey<TKey>, w której zaimplementuję IsEncryptedFile() i zrobię szablon szyfrowania i deszyfrowania (reszta metod interfejsu bd abstract)
// dodać sprawdzenie, czy plik, który chcemy zdeszyfrować, ma odpowiednie rozszerzenie (w każdej klasie)
// wywalić stąd zakomentowany kod
// wywalić projekty testów CA, wizualizera CA i geometrii z gita
