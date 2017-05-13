using System;
using System.IO;

namespace CryptoStegano
{
    public class MessageHider
    {
        public bool HideMessage(string messageFilePath, string inputCoverFilePath, string outputCoverFilePath, int hidingStartByte)
        {
            using (FileStream messageFileStream = StreamMaker.MakeInputStream(messageFilePath),
                inputCoverFileStream = StreamMaker.MakeInputStream(inputCoverFilePath),
                outputCoverFileStream = StreamMaker.MakeOutputStream(outputCoverFilePath))
            {
                if (hidingStartByte > inputCoverFileStream.Length - messageFileStream.Length * 8)
                    return false; // Hiding start byte or message file is too large to hold all the message inside cover file.

                int messageCharacter, coverCharacter, messageCharacterBit;

                // Move to hiding start byte.
                for (int i = 0; i < hidingStartByte; i++)
                {
                    coverCharacter = inputCoverFileStream.ReadByte();
                    outputCoverFileStream.WriteByte((byte)coverCharacter);
                }

                bool endOfMessageFile;
                do
                {
                    // End of file shouldn't appear, because of checking hidding start byte at the beginning of the method.
                    messageCharacter = messageFileStream.ReadByte();
                    endOfMessageFile = messageCharacter == -1;
                    if (endOfMessageFile)
                        messageCharacter = 0; // 0 means end of message that is being hidden.
                    for (int i = 0; i < 8; i++)
                    {
                        messageCharacterBit = messageCharacter & 1; // Obtain current message character bit.
                        coverCharacter = inputCoverFileStream.ReadByte();
                        coverCharacter &= 254; // Reset least significant bit from the cover file character.
                        coverCharacter |= messageCharacterBit; // Change least significant bit value of the cover file character to the value of the current message character bit.
                        // coverCharacter &= (254 | messageCharacterBit) for short
                        outputCoverFileStream.WriteByte((byte)coverCharacter);
                        messageCharacter = messageCharacter >> 1;
                    }
                }
                while (!endOfMessageFile);

                // Rewrite rest of the cover file.
                do
                {
                    coverCharacter = inputCoverFileStream.ReadByte();
                    endOfMessageFile = coverCharacter == -1;
                    if (!endOfMessageFile)
                        outputCoverFileStream.WriteByte((byte)coverCharacter);
                }
                while (!endOfMessageFile);

                return true;
            }
        }

        // In general false returned means that end of cover file reached before message has been read.
        public static bool DiscoverMessage(string coveredMessageFilePath, string readMessageFilePath, int hiddingStartByte)
        {
            using (FileStream coverFileStream = new FileStream(coveredMessageFilePath, FileMode.Open, FileAccess.Read), readMessageFileStream = new FileStream(readMessageFilePath, FileMode.Create, FileAccess.Write))
            {
                if (hiddingStartByte > coverFileStream.Length)
                    return false; // Hiding start byte cannot be greater than covered message file length.

                coverFileStream.Position = hiddingStartByte;
                int messageCharacter, coverCharacter, messageCharacterBit;
                bool notEndOfMessage;
                do
                {
                    messageCharacter = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        coverCharacter = coverFileStream.ReadByte();
                        if (coverCharacter == -1)
                            return false; // End of cover file reached before message has been read.
                        messageCharacterBit = coverCharacter & 1;
                        messageCharacter |= messageCharacterBit << i;
                    }
                    notEndOfMessage = messageCharacter != 0;
                    if (notEndOfMessage)
                        readMessageFileStream.WriteByte((byte)messageCharacter);
                }
                while (notEndOfMessage);

                return true;
            }
        }
    }
}
