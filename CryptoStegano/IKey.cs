using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoStegano
{
    interface IKey<TKey> where TKey : IKey<TKey>
    {
        bool IsInvertibleMod(int n);
        TKey GetInverseMod(int n);
    }
}
