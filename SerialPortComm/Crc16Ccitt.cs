using System;
using System.Linq;

namespace SerialPortComm
{
    public enum InitialCrcValue { Zeros, NonZero1 = 0xffff, NonZero2 = 0x1D0F }

    public class Crc16Ccitt
    {
        private const ushort Poly = 4129;
        private readonly ushort[] _table = new ushort[256];
        private readonly ushort _initialValue;

        public ushort ComputeChecksum(byte[] bytes)
        {
            return bytes.Aggregate(_initialValue, (current, b) => (ushort)((current << 8) ^ _table[((current >> 8) ^ (0xff & b))]));
        }

        public byte[] ComputeChecksumBytes(byte[] bytes)
        {
            ushort crc = ComputeChecksum(bytes);
            return BitConverter.GetBytes(crc).Reverse().ToArray();
        }

        public bool ChecksumBytesResult(byte[] bytes)
        {
            byte[] bytetemp = new byte[bytes.Length - 2];
            for (int i = 1; i < bytes.Length - 2; i++)
            {
                bytetemp[i] = bytes[i];
            }
            byte[] result = ComputeChecksumBytes(bytetemp);
            return result.Length == 2 && (bytes[bytes.Length - 2] == result[0] && bytes[bytes.Length - 1] == result[1]);
        }

        public Crc16Ccitt(InitialCrcValue initialValue)
        {
            _initialValue = (ushort)initialValue;
            for (int i = 0; i < _table.Length; i++)
            {
                ushort temp = 0;
                ushort a = (ushort)(i << 8);
                for (int j = 0; j < 8; ++j)
                {
                    if (((temp ^ a) & 0x8000) != 0)
                    {
                        temp = (ushort)((temp << 1) ^ Poly);
                    }
                    else
                    {
                        temp <<= 1;
                    }
                    a <<= 1;
                }
                _table[i] = temp;
            }
        }
    }
}