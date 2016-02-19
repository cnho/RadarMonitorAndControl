using System;

namespace SerialPortComm
{
    public enum Crc16Mode : ushort { Standard = 0xA001, CcittKermit = 0x8408 }

    public class Crc16CcittKermit
    {
        private readonly ushort[] _table = new ushort[256];

        public ushort ComputeChecksum(byte[] bytes)
        {
            ushort crc = 0;
            foreach (byte b in bytes)
            {
                byte index = (byte)(crc ^ b);
                crc = (ushort)((crc >> 8) ^ _table[index]);
            }
            return crc;
        }

        public byte[] ComputeChecksumBytes(byte[] bytes)
        {
            ushort crc = ComputeChecksum(bytes);
            return BitConverter.GetBytes(crc);
        }

        public Crc16CcittKermit(Crc16Mode mode)
        {
            ushort polynomial = (ushort)mode;
            for (ushort i = 0; i < _table.Length; ++i)
            {
                ushort value = 0;
                var temp = i;
                for (byte j = 0; j < 8; ++j)
                {
                    if (((value ^ temp) & 0x0001) != 0)
                    {
                        value = (ushort)((value >> 1) ^ polynomial);
                    }
                    else
                    {
                        value >>= 1;
                    }
                    temp >>= 1;
                }
                _table[i] = value;
            }
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
    }
}