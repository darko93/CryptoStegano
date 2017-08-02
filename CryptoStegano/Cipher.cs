using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CryptoStegano
{
    public abstract class Cipher<TKey> : ProgressNotificator, ICipher<TKey> where TKey : IKey<TKey>
    {
        #region ICipher

        public abstract string EncryptedFileExtension { get; }

        public bool IsEncryptedFile(string filePath)
            => Path.GetExtension(filePath).Equals(EncryptedFileExtension, StringComparison.InvariantCultureIgnoreCase);

        public void EncryptFile(string inputFilePath, string outputFilePath, TKey encryptKey)
        {
            using (FileStream inputStream = StreamMaker.MakeInputStream(inputFilePath))
            using (FileStream outputStream = StreamMaker.MakeOutputStream(outputFilePath + EncryptedFileExtension))
            {
                EncryptFileExtension(inputFilePath, outputStream, encryptKey);
                EqualizeFileLengthEncryption(inputStream, outputStream, encryptKey);
                EncryptUntilEndOfFile(inputStream, outputStream, encryptKey);
            }
        }

        public void DecryptFile(string inputFilePath, string outputFilePath, TKey encryptKey)
        {
            if (!IsEncryptedFile(inputFilePath))
                throw new ArgumentException("Cannot decrypt file, because this file is not decrypted using corresponding encryption agorithm.");

            TKey decryptKey = encryptKey.GetInverseMod(Ring.N);

            using (FileStream inputStream = StreamMaker.MakeInputStream(inputFilePath))
            {
                string decryptedFileExtension = DecryptFileExtension(inputStream, decryptKey);
                using (FileStream outputStream = StreamMaker.MakeOutputStream(outputFilePath + decryptedFileExtension))
                {
                    EqualizeFileLengthDecryption(inputStream, outputStream, decryptKey);
                    EncryptUntilEndOfFile(inputStream, outputStream, decryptKey);
                }
            }
        }

        #endregion ICIpher

        protected abstract void EncryptFileExtension(string inputFilePath, FileStream outputStream, TKey encryptKey);
        protected abstract void EncryptUntilEndOfFile(FileStream inputStream, FileStream outputStream, TKey encryptKey);
        protected abstract string DecryptFileExtension(FileStream inputStream, TKey decryptKey);

        protected virtual void EqualizeFileLengthEncryption(FileStream inputStream, FileStream outputStream, TKey encryptKey) { }
        protected virtual void EqualizeFileLengthDecryption(FileStream inputStream, FileStream outputStream, TKey decryptKey) { }
    }
}
