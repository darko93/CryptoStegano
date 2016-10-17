using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace CryptoStegano
{
    public abstract class Cipher
    {
        protected abstract string EncryptedFileExtension { get; }

        protected FileStream MakeInputStream(string inputFilePath)
        {
            return new FileStream(inputFilePath, FileMode.Open, FileAccess.Read);
        }

        protected FileStream MakeOutputStream(string outputFilePath)
        {
            return new FileStream(outputFilePath, FileMode.CreateNew, FileAccess.Write);
        }

        public bool HasCryptedFileExtension(string filePath) => String.Equals(Path.GetExtension(filePath), EncryptedFileExtension, StringComparison.OrdinalIgnoreCase);
    }
}
