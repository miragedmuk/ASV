using NLog.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsaSavegameToolkit
{
    public class AsaCompressedData
    {
        private enum ReadState
        {
            None,
            Escape,
            Switch
        }

        private readonly Queue<int> fifoQueue = new Queue<int>();
        private readonly Stream inputStream;
        private ReadState readState = ReadState.None;

        public AsaCompressedData(Stream inputStream)
        {
            this.inputStream = inputStream;
        }


        public byte[] Inflate()
        {
            List<int> list = new List<int>();
            while(inputStream.Position < inputStream.Length || fifoQueue.Count > 0) 
            {
                list.Add(Read());            
            }
            return list.Select(o=>(byte)o).ToArray(); 

        }


        private int Read()
        {
            if (fifoQueue.Count > 0)
            {
                return fifoQueue.Dequeue();
            }

            int next = inputStream.ReadByte();

            if (readState == ReadState.Switch)
            {
                int returnValue = 0xF0 | ((next & 0xF0) >> 4);
                fifoQueue.Enqueue(0xF0 | (next & 0x0F));
                readState = ReadState.None;
                return returnValue;
            }

            if (readState == ReadState.None)
            {
                if (next == 0xF0)
                {
                    readState = ReadState.Escape;
                    return Read();
                }

                if (next == 0xF1)
                {
                    readState = ReadState.Switch;
                    return Read();
                }

                if (next >= 0xF2 && next < 0xFF)
                {
                    int byteCount = next & 0x0F;
                    for (int i = 0; i < byteCount; i++)
                    {
                        fifoQueue.Enqueue(0);
                    }
                    return Read();
                }

                if (next == 0xFF)
                {
                    int b1 = inputStream.ReadByte();
                    int b2 = inputStream.ReadByte();
                    fifoQueue.Enqueue(0);
                    fifoQueue.Enqueue(0);
                    fifoQueue.Enqueue(0);
                    fifoQueue.Enqueue(b1);
                    fifoQueue.Enqueue(0);
                    fifoQueue.Enqueue(0);
                    fifoQueue.Enqueue(0);
                    fifoQueue.Enqueue(b2);
                    fifoQueue.Enqueue(0);
                    fifoQueue.Enqueue(0);
                    fifoQueue.Enqueue(0);
                    return Read();
                }
            }

            readState = ReadState.None;
            return next;
        }

    }
}
