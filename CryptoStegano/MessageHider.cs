using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace CryptoStegano
{
    public class MessageHider : FilesProcessor
    {
        private const int endOfMessageCharacter = 0;

        public void HideMessage(string messageFilePath, string inputCoverFilePath, string outputCoverFilePath, int hidingStartByte)
        {
            base.outputFilePath = outputCoverFilePath;
            using (FileStream messageStream = StreamMaker.MakeInputStream(messageFilePath))
            using (FileStream inputCoverStream = StreamMaker.MakeInputStream(inputCoverFilePath))
            using (FileStream outputCoverStream = StreamMaker.MakeOutputStream(base.outputFilePath))
            {
                if (hidingStartByte > inputCoverStream.Length - messageStream.Length * 8)
                    throw new ArgumentException("Hiding start byte or message file is too large to hold all the message inside cover file.");

                int coverCharacter;

                // Move to hiding start byte.
                for (int i = 0; i < hidingStartByte; i++)
                {
                    coverCharacter = inputCoverStream.ReadByte();
                    outputCoverStream.WriteByte((byte)coverCharacter);
                    SetProgressPercentageAndCheckCancellation(inputCoverStream);
                }

                int messageCharacter, messageCharacterBit;
                bool endOfMessageFile = false;
                while (!endOfMessageFile)
                {
                    // End of file shouldn't appear now, because of checking hidding start byte at the beginning of the method.
                    messageCharacter = messageStream.ReadByte();
                    endOfMessageFile = messageCharacter == -1;
                    if (endOfMessageFile)
                        messageCharacter = endOfMessageCharacter;
                    for (int i = 0; i < 8; i++)
                    {
                        messageCharacterBit = messageCharacter & 1; // Obtain current message character bit.
                        coverCharacter = inputCoverStream.ReadByte();
                        coverCharacter &= 254; // Reset least significant bit from the cover file character.
                        coverCharacter |= messageCharacterBit; // Change least significant bit value of the cover file character to the value of the current message character bit.
                        // coverCharacter &= (254 | messageCharacterBit) for short
                        outputCoverStream.WriteByte((byte)coverCharacter);
                        messageCharacter = messageCharacter >> 1;
                    }
                    SetProgressPercentageAndCheckCancellation(inputCoverStream);
                }

                // Rewrite rest of the cover file.
                bool endOfCoverFile = false;
                while (!endOfCoverFile)
                {
                    coverCharacter = inputCoverStream.ReadByte();
                    endOfCoverFile = coverCharacter == -1;
                    if (!endOfCoverFile)
                    {
                        outputCoverStream.WriteByte((byte)coverCharacter);
                        SetProgressPercentageAndCheckCancellation(inputCoverStream);
                    }
                    else
                        NotifyFinishedWork();
                }
            }
        }

        public async Task HideMessageAsync(string messageFilePath, string inputCoverFilePath, string outputCoverFilePath, int hidingStartByte, CancellationToken cancellationToken)
        {
            CancellationToken = cancellationToken;
            await Task.Run(() => HideMessage(messageFilePath, inputCoverFilePath, outputCoverFilePath, hidingStartByte), cancellationToken);
        }

        public async Task HideMessageAsync(string messageFilePath, string inputCoverFilePath, string outputCoverFilePath, int hidingStartByte) =>
            await HideMessageAsync(messageFilePath, inputCoverFilePath, outputCoverFilePath, hidingStartByte, CancellationToken.None);

        public void DiscoverMessage(string coverMessageFilePath, string readMessageFilePath, int hiddingStartByte)
        {
            using (FileStream coverStream = StreamMaker.MakeInputStream(coverMessageFilePath))
            using (FileStream readMessageStream = StreamMaker.MakeOutputStream(readMessageFilePath))
            {
                if (hiddingStartByte > coverStream.Length)
                    throw new ArgumentException("Hiding start byte cannot be greater than covered message file length.");

                coverStream.Position = hiddingStartByte;
                int messageCharacter, coverCharacter, messageCharacterBit;
                bool endOfMessage = false;
                while (!endOfMessage)
                {
                    messageCharacter = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        coverCharacter = coverStream.ReadByte();
                        if (coverCharacter == -1)
                        {
                            NotifyFinishedWork();
                            return; // End of cover file reached before end of message character found.
                        }
                        messageCharacterBit = coverCharacter & 1;
                        messageCharacter |= messageCharacterBit << i;
                    }
                    endOfMessage = messageCharacter == endOfMessageCharacter;
                    if (!endOfMessage)
                    {
                        readMessageStream.WriteByte((byte)messageCharacter);
                        SetProgressPercentageAndCheckCancellation(coverStream);
                    }
                    else
                        NotifyFinishedWork();
                }
            }
        }

        public async Task DiscoverMessageAsync(string coverMessageFilePath, string readMessageFilePath, int hiddingStartByte, CancellationToken cancellationToken)
        {
            CancellationToken = cancellationToken;
            await Task.Run(() => DiscoverMessage(coverMessageFilePath, readMessageFilePath, hiddingStartByte), cancellationToken);
        }

        public async Task DiscoverMessageAsync(string coverMessageFilePath, string readMessageFilePath, int hiddingStartByte) =>
            await DiscoverMessageAsync(coverMessageFilePath, readMessageFilePath, hiddingStartByte, CancellationToken.None);
    }
}
