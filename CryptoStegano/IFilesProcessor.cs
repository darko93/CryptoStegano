using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoStegano
{
    public interface IFilesProcessor
    {
        event Action<object> ProgressUpdated;
        int ProgressPercentage { get; }
    }
}
