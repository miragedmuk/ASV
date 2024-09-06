namespace AsaSavegameToolkit
{
    public class AsaCompressedData
    {
        public AsaCompressedData()
        {

        }

        public static byte[] Inflate(ReadOnlySpan<byte> inputBuffer)
        {
            int currentPos = 0;
            using (MemoryStream outputStream = new MemoryStream())
            {
                using(BufferedStream bufferedOutput =  new BufferedStream(outputStream))
                {
                    while (currentPos < inputBuffer.Length)
                    {
                        var next = inputBuffer[currentPos];

                        switch (next)
                        {
                            case byte checkNext when checkNext == 0xF0:
                                //escape
                                currentPos++;
                                bufferedOutput.WriteByte(inputBuffer[currentPos]);
                                break;
                            case byte checkNext when checkNext == 0xF1:
                                //switch
                                currentPos++;
                                next = inputBuffer[currentPos];
                                int returnValue = 0xF0 | ((next & 0xF0) >> 4);
                                bufferedOutput.WriteByte((byte)returnValue);
                                bufferedOutput.WriteByte((byte)((0xF0 | (next & 0x0F))));

                                break;
                            case byte checkNext when checkNext >= 0xF2 && checkNext < 0xFF:
                                //expand 0's
                                int byteCount = next & 0x0F;
                                for (int i = 0; i < byteCount; i++)
                                {
                                    bufferedOutput.WriteByte((byte)0);
                                }
                                break;
                            case byte checkNext when checkNext == 0xFF:
                                //expand
                                currentPos++;
                                var b1 = inputBuffer[currentPos];
                                currentPos++;
                                var b2 = inputBuffer[currentPos];
                                bufferedOutput.WriteByte((byte)0);
                                bufferedOutput.WriteByte((byte)0);
                                bufferedOutput.WriteByte((byte)0);
                                bufferedOutput.WriteByte(b1);
                                bufferedOutput.WriteByte((byte)0);
                                bufferedOutput.WriteByte((byte)0);
                                bufferedOutput.WriteByte((byte)0);
                                bufferedOutput.WriteByte(b2);
                                bufferedOutput.WriteByte((byte)0);
                                bufferedOutput.WriteByte((byte)0);
                                bufferedOutput.WriteByte((byte)0);
                                break;
                            default:
                                bufferedOutput.WriteByte(next);
                                break;
                        }
                        currentPos++;

                    }

                    bufferedOutput.Flush();
                }                

                return outputStream.ToArray();
            }
        }



    }
}
