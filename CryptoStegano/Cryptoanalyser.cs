using System;
using System.Collections.Generic;
using System.IO;

namespace CryptoStegano
{
    public class Cryptoanalyser
    {
        private AffineCipher affineCipher = new AffineCipher();

        public Dictionary<string, byte[]> GetSygnaturesDic()
        {
            //  a * byte_from_array + b = encrypted_byte
            Dictionary<string, byte[]> MyDic = new Dictionary<string, byte[]>();
            MyDic.Add("png", new byte[] { 0x89, 0x50, 0x4E, 0x47 });
            MyDic.Add("zip", new byte[] { 0x50, 0x4B, 0x03, 0x04 });
            MyDic.Add("mp3", new byte[] { 0x49, 0x44, 0x33, 0x03 });
            MyDic.Add("jpg", new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 });
            MyDic.Add("pdf", new byte[] { 0x25, 0x50, 0x44, 0x46 });
            return MyDic;
        }

        private AffineKey CalculateEncryptKey(int x1, int c1, int x2, int c2)
        {
            int x = x1 - x2;
            int c = c1 - c2;
            int a = Ring.Modulo(c * Ring.Inverse(x, Ring.N), Ring.N);
            int b = Ring.Modulo(c1 - a * x1, Ring.N);
            AffineKey encryptKey = new AffineKey(a, b);
            return encryptKey;
        }

        private AffineKey GetKey(FileStream fsIn, string ext)
        {
            int c1 = fsIn.ReadByte(), c2 = fsIn.ReadByte();
            Dictionary<string, byte[]> SygnaturesDic = GetSygnaturesDic();
            byte x1 = SygnaturesDic[ext][0], x2 = SygnaturesDic[ext][1];
            AffineKey encKey1 = CalculateEncryptKey(x1, c1, x2, c2);
            return encKey1;
        }

        private AffineKey GetKey2(FileStream fsIn, string ext)
        {
            int c1 = fsIn.ReadByte(), c2 = fsIn.ReadByte();
            Dictionary<string, byte[]> SygnaturesDic = GetSygnaturesDic();
            byte x1 = SygnaturesDic[ext][2], x2 = SygnaturesDic[ext][3];
            AffineKey encKey2 = CalculateEncryptKey(x1, c1, x2, c2);
            return encKey2;
        }

        public bool DecryptFile(string inputFilePath, string ext)
        {
            string outFile = Path.ChangeExtension(inputFilePath, ext);// Path.GetFileNameWithoutExtension(inFile) + "." + ext;
            using (FileStream fsIn = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            {
                AffineKey key1 = GetKey(fsIn, ext), key2 = GetKey2(fsIn, ext);
                fsIn.Close();
                Console.WriteLine(key1.A.ToString() + "," + key1.B.ToString() + " ; " + key2.B.ToString() + "," + key2.B.ToString());
                affineCipher.DecryptFile(inputFilePath, outFile, key1);
                return true;
            }
        }
    }
}
