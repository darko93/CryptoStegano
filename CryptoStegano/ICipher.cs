using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoStegano
{
    interface ICipher<TKey> where TKey : IKey<TKey>
    {
        string EncryptedFileExtension { get; }
        bool IsEncryptedFile(string filePath);
        void EncryptFile(string inputFilePath, string outputFilePath, TKey encrptKey);
        void DecryptFile(string inputFilePath, string outputFilePath, TKey encryptKey);
    }
}
