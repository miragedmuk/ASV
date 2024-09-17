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
                //using(BufferedStream bufferedOutput =  new BufferedStream(outputStream))
                {
                    while (currentPos < inputBuffer.Length)
                    {
                        var next = inputBuffer[currentPos];

                        switch (next)
                        {
                            case byte checkNext when checkNext == 0xF0:
                                //escape
                                currentPos++;
                                outputStream.WriteByte(inputBuffer[currentPos]);
                                break;
                            case byte checkNext when checkNext == 0xF1:
                                //switch
                                currentPos++;
                                next = inputBuffer[currentPos];
                                int returnValue = 0xF0 | ((next & 0xF0) >> 4);
                                outputStream.WriteByte((byte)returnValue);
                                outputStream.WriteByte((byte)((0xF0 | (next & 0x0F))));

                                break;
                            case byte checkNext when checkNext >= 0xF2 && checkNext < 0xFF:
                                //expand 0's
                                int byteCount = next & 0x0F;

                                outputStream.Write(new byte[byteCount]);
                                /*
                                for (int i = 0; i < byteCount; i++)
                                {
                                    outputStream.WriteByte((byte)0);
                                }
                                */

                                break;
                            case byte checkNext when checkNext == 0xFF:
                                //expand
                                currentPos++;
                                var b1 = inputBuffer[currentPos];
                                currentPos++;
                                var b2 = inputBuffer[currentPos];
                                outputStream.WriteByte((byte)0);
                                outputStream.WriteByte((byte)0);
                                outputStream.WriteByte((byte)0);
                                outputStream.WriteByte(b1);
                                outputStream.WriteByte((byte)0);
                                outputStream.WriteByte((byte)0);
                                outputStream.WriteByte((byte)0);
                                outputStream.WriteByte(b2);
                                outputStream.WriteByte((byte)0);
                                outputStream.WriteByte((byte)0);
                                outputStream.WriteByte((byte)0);
                                break;
                            default:
                                outputStream.WriteByte(next);
                                break;
                        }
                        currentPos++;

                    }

                    outputStream.Flush();
                }                

                return outputStream.ToArray();
            }
        }



    }
}
