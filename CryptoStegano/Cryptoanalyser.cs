
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace CryptoStegano
{
    public class Cryptoanalyser : IFilesProcessor
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

            // All of these signatures are acceptable - key can be calculated from first two bytes of each array.
            // key.A * byte_from_array + key.B = encrypted_byte
            AddExtensionWithSignature("png", new byte[] { 0x89, 0x50, 0x4E, 0x47 });
            AddExtensionWithSignature("zip", new byte[] { 0x50, 0x4B, 0x03, 0x04 });
            AddExtensionWithSignature("mp3", new byte[] { 0x49, 0x44, 0x33, 0x03 });
            AddExtensionWithSignature("jpg", new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 });
            AddExtensionWithSignature("pdf", new byte[] { 0x25, 0x50, 0x44, 0x46 });
        }

        public bool AddExtensionWithSignature(string extension, byte[] hexSignature)
        {
            // Look for pair of signature bytes, which difference is invertible modulo 256, so encrypt key can be calculated.
            for (int signatureByte1Position = 0; signatureByte1Position < hexSignature.Length; signatureByte1Position++)
            {
                for (int signatureByte2Position = signatureByte1Position + 1; signatureByte2Position < hexSignature.Length; signatureByte2Position++)
                {
                    int signatureByte1 = hexSignature[signatureByte1Position];
                    int signatureByte2 = hexSignature[signatureByte2Position];
                    if (Ring.IsInvertibleMod(signatureByte1 - signatureByte2, Ring.N))
                    {
                        // Found such pair of bytes, so add them and their numbers in signature array.
                        signatures.Add(extension, new Signature(signatureByte1, signatureByte2, signatureByte1Position, signatureByte2Position));
                        return true;
                    }
                }
            }
            return false; // Not found such pair, so encrypt key cannot be balculated from given signature bytes and given extension isn't acceptable.
        }

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
            int deltaSignatureBytes = -signature.DeltaBytes; // Yes, I want minus delta.
            int deltaEncryptedSygnatureBytes = encryptedSignatureByte1 - encryptedSignatureByte2; // Yes, I want minus delta.
            int keyA = Ring.Modulo(deltaEncryptedSygnatureBytes * Ring.Inverse(deltaSignatureBytes, Ring.N), Ring.N);
            int keyB = Ring.Modulo(encryptedSignatureByte1 - keyA * signature.Byte1, Ring.N);
            AffineKey encryptKey = new AffineKey(keyA, keyB);
            return encryptKey;
        }

        private AffineKey GetEncryptKey(FileStream inputFileStream, string originalExtension)
        {
            Signature fileSignature = signatures[originalExtension];
            inputFileStream.Position += 1 + originalExtension.Length; // Jump over encrypted extension, where first character means extension length.
            long positionBehindEncryptedExtension = inputFileStream.Position;
            inputFileStream.Position += fileSignature.Byte1Position;
            int encryptedSignatureByte1 = inputFileStream.ReadByte();
            inputFileStream.Position = positionBehindEncryptedExtension + fileSignature.Byte2Position;
            int encyptedSignatureByte2 = inputFileStream.ReadByte();

            inputFileStream.Position = positionBehindEncryptedExtension;

            AffineKey encryptKey = CalculateEncryptKey(fileSignature, encryptedSignatureByte1, encyptedSignatureByte2);
            return encryptKey;
        }

        public AffineKey TryGetEncryptKeyByOutputFilePathWithExtension(string inputFilePath, string outputFilePath)
        {
            string originalExtension = Path.GetExtension(outputFilePath);
            return TryGetEncryptKeyByOriginalExtension(inputFilePath, originalExtension);
        }

        public AffineKey TryGetEncryptKeyByOriginalExtension(string inputFilePath, string originalExtension)
        {
            if (!signatures.ContainsKey(originalExtension))
                throw new ArgumentException($"Signatures dictionary does not contain extension \"{originalExtension}\". Encrypt key cannot be calculated. Add \"{originalExtension}\" extension and its signature to the signatures dictionary first.");

            AffineKey encryptKey;
            using (FileStream inputFileStream = StreamMaker.MakeInputStream(inputFilePath))
            {
                encryptKey = GetEncryptKey(inputFileStream, originalExtension);
            }

            return encryptKey;
        }

        public void DecryptFile(string inputFilePath, string outputFilePath) // outputFilePath - with CORRECT extension
        {
            AffineKey encryptKey = TryGetEncryptKeyByOutputFilePathWithExtension(inputFilePath, outputFilePath);
            affineCipher.DecryptFile(inputFilePath, outputFilePath, encryptKey);
        }

        public async Task DecryptFileAsync(string inputFilePath, string outputFilePath, CancellationToken cancellationToken)
        {
            AffineKey encryptKey = TryGetEncryptKeyByOutputFilePathWithExtension(inputFilePath, outputFilePath);
            await affineCipher.DecryptFileAsync(inputFilePath, outputFilePath, encryptKey, cancellationToken);
        }

        public async Task DecryptFileAsync(string inputFilePath, string outputFilePath)
            => await DecryptFileAsync(inputFilePath, outputFilePath, CancellationToken.None);

        #region IFilesProcessor

        public int ProgressPercentage => affineCipher.ProgressPercentage;

        public event Action<object> ProgressUpdated
        {
            add { affineCipher.ProgressUpdated += value; }
            remove { affineCipher.ProgressUpdated -= value; }
        }

        #endregion IFIlesProcessor
    }
}
