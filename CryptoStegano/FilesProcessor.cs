using System;
using System.IO;
using System.Threading;

namespace CryptoStegano
{
    public class FilesProcessor : IFilesProcessor
    {
        private event Action<object> progressUpdated;
        public event Action<object> ProgressUpdated
        {
            add { progressUpdated += value; }
            remove { progressUpdated -= value; }
        }

        private int progressPercentage = 0;
        public int ProgressPercentage
        {
            get { return progressPercentage; }
            protected set
            {
                if (value != progressPercentage)
                {
                    progressPercentage = value;
                    progressUpdated(this);
                }
            }
        }

        protected void SetProgressPercentage(FileStream inputStream)
        {
            ProgressPercentage = (int)(inputStream.Position * 100 / inputStream.Length);
        }

        protected void NotifyFinishedWork()
        {
            ProgressPercentage = 100;
        }


        protected string outputFilePath = null;
        private CancellationToken cancellationToken = CancellationToken.None;
        protected CancellationToken CancellationToken
        {
            get { return cancellationToken; }
            set
            {
                cancellationToken = value;
                cancellationToken.Register(() => OnCancell());
            }
        }

        private void OnCancell()
        {
            ProgressPercentage = 0;
            TryDeleteOutputFile();
        }

        private void TryDeleteOutputFile()
        {
            if (File.Exists(outputFilePath))
                File.Delete(outputFilePath);
        }

        protected void CheckCancellation()
        {
            CancellationToken.ThrowIfCancellationRequested();
        }

        protected void SetProgressPercentageAndCheckCancellation(FileStream inputStream)
        {
            SetProgressPercentage(inputStream);
            CheckCancellation();
        }
    }
}
