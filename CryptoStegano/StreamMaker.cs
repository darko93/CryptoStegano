using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CryptoStegano
{
    static class StreamMaker
    {
        public static FileStream MakeInputStream(string inputFilePath)
        {
            return new FileStream(inputFilePath, FileMode.Open, FileAccess.Read);
        }

        public static FileStream MakeOutputStream(string outputFilePath)
        {
            return new FileStream(outputFilePath, FileMode.CreateNew, FileAccess.Write);
        }
    }
}
