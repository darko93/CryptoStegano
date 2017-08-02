using System;
using System.IO;

namespace CryptoStegano
{
    public class ProgressNotificator
    {
        public event Action<object> ProgressUpdated;

        private int progressPercentage = 0;
        public int ProgressPercentage
        {
            get { return progressPercentage; }
            protected set
            {
                if (value != progressPercentage)
                {
                    progressPercentage = value;
                    ProgressUpdated(this);
                }
            }
        }

        protected void SetProgressPercentage(FileStream inputStream)
        {
            ProgressPercentage = (int)(inputStream.Position * 100 / inputStream.Length);
        }
    }
}
