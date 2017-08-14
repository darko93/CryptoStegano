using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace CryptoStegano
{
    public abstract class Cipher<TKey> : FilesProcessor, ICipher<TKey> where TKey : IKey<TKey>
    {
        #region ICipher

        public abstract string EncryptedFileExtension { get; }

        public bool IsEncryptedFile(string filePath)
            => Path.GetExtension(filePath).Equals(EncryptedFileExtension, StringComparison.InvariantCultureIgnoreCase);

        public void EncryptFile(string inputFilePath, string outputFilePath, TKey encryptKey)
        {
            base.outputFilePath = Path.ChangeExtension(outputFilePath, EncryptedFileExtension);
            using (FileStream inputStream = StreamMaker.MakeInputStream(inputFilePath))
            using (FileStream outputStream = StreamMaker.MakeOutputStream(base.outputFilePath + EncryptedFileExtension))
            {
                EncryptFileExtension(inputFilePath, outputStream, encryptKey);
                EqualizeFileLengthEncryption(inputStream, outputStream, encryptKey);
                EncryptUntilEndOfFile(inputStream, outputStream, encryptKey);
            }
        }

        public async Task EncryptFileAsync(string inputFilePath, string outputFilePath, TKey encryptKey, CancellationToken cancellationToken)
        {
            CancellationToken = cancellationToken;
            await Task.Run(() => EncryptFile(inputFilePath, outputFilePath, encryptKey), cancellationToken);
        }

        public async Task EncryptFileAsync(string inputFilePath, string outputFilePath, TKey encryptKey) =>
            await EncryptFileAsync(inputFilePath, outputFilePath, encryptKey, CancellationToken.None);

        public void DecryptFile(string inputFilePath, string outputFilePath, TKey encryptKey)
        {
            if (!IsEncryptedFile(inputFilePath))
                throw new ArgumentException("Cannot decrypt file, because this file is not decrypted using corresponding encryption agorithm.");

            TKey decryptKey = encryptKey.GetInverseMod(Ring.N);

            using (FileStream inputStream = StreamMaker.MakeInputStream(inputFilePath))
            {
                string decryptedFileExtension = DecryptFileExtension(inputStream, decryptKey);
                base.outputFilePath = Path.ChangeExtension(outputFilePath, decryptedFileExtension);
                using (FileStream outputStream = StreamMaker.MakeOutputStream(base.outputFilePath + decryptedFileExtension))
                {
                    EqualizeFileLengthDecryption(inputStream, outputStream, decryptKey);
                    EncryptUntilEndOfFile(inputStream, outputStream, decryptKey);
                }
            }
        }

        public async Task DecryptFileAsync(string inputFilePath, string outputFilePath, TKey encryptKey, CancellationToken cancellationToken)
        {
            CancellationToken = cancellationToken;
            await Task.Run(() => DecryptFile(inputFilePath, outputFilePath, encryptKey), cancellationToken);
        }

        public async Task DecryptFileAsync(string inputFilePath, string outputFilePath, TKey encryptKey) =>
            await DecryptFileAsync(inputFilePath, outputFilePath, encryptKey, CancellationToken.None);

        #endregion ICIpher

        protected abstract void EncryptFileExtension(string inputFilePath, FileStream outputStream, TKey encryptKey);
        protected abstract void EncryptUntilEndOfFile(FileStream inputStream, FileStream outputStream, TKey encryptKey);
        protected abstract string DecryptFileExtension(FileStream inputStream, TKey decryptKey);

        protected virtual void EqualizeFileLengthEncryption(FileStream inputStream, FileStream outputStream, TKey encryptKey) { }
        protected virtual void EqualizeFileLengthDecryption(FileStream inputStream, FileStream outputStream, TKey decryptKey) { }
    }
}
