using System;
using System.Globalization;
using System.Linq;

namespace Common
{
    public static class HexBinDecOct
    {
        /// <summary>
        /// 十六进制字节转十进制数据.
        /// </summary>
        /// <param name="hexdata">十六进制字节.</param>
        /// <returns></returns>
        public static int HexStringToDec(byte hexdata)
        {
            string hexdatastr = hexdata.ToString("X2");
            int iNumber = Convert.ToInt32(hexdatastr, 16);
            if (iNumber <= 32767) return iNumber;

            int iComplement = iNumber - 1;
            char[] binChar = Convert.ToString(iComplement, 2).PadLeft(8, '0').ToArray();

            string strNegate = string.Empty;
            strNegate = binChar.Aggregate(strNegate, (current, ch) => current + (Convert.ToInt32(ch) == 48 ? "1" : "0"));
            return -Convert.ToInt32(strNegate, 2);
        }

        /// <summary>
        /// 十六进制字符串转十进制数据.
        /// </summary>
        /// <param name="hexdata">十六进制字符串.</param>
        /// <returns></returns>
        public static int HexStringToDec(string hexdata)
        {
            int iNumber = Convert.ToInt32(hexdata, 16);
            if (iNumber <= 32767) return iNumber;
            if (iNumber > 32768) return 0;
            int iComplement = iNumber - 1;
            char[] binChar = Convert.ToString(iComplement, 2).PadLeft(8, '0').ToArray();

            string strNegate = string.Empty;
            strNegate = binChar.Aggregate(strNegate, (current, ch) => current + (Convert.ToInt32(ch) == 48 ? "1" : "0"));
            return -Convert.ToInt32(strNegate, 2);
        }

        /// <summary>
        /// 16进制字符串转2进制字符串.
        /// </summary>
        /// <param name="hexdata">十六进制字符串.</param>
        /// <returns></returns>
        public static string HexStringToBinString(string hexdata)
        {
            int iNumber = Convert.ToInt32(hexdata, 16);
            return Convert.ToString(iNumber, 2).PadLeft(8, '0');
        }

        /// <summary>
        /// 字节转2进制字符串.
        /// </summary>
        /// <param name="byteStr">The byte string.</param>
        /// <returns></returns>
        public static string ByteToBinString(byte byteStr)
        {
            return Convert.ToString(byteStr, 2).PadLeft(8, '0');
        }

        /// <summary>
        /// 字符串转字节数组.
        /// </summary>
        /// <param name="strdata">The strdata.</param>
        /// <returns></returns>
        public static byte[] StringToBytes(string strdata)
        {
            byte[] bytes = new byte[strdata.Length];
            for (int i = 0; i < bytes.Length; i++)
            { bytes[i] = Convert.ToByte(strdata[i].ToString(CultureInfo.InvariantCulture), 16); }
            return bytes;
        }

        /// <summary>
        /// 字节数组转为带空格的字符串.
        /// </summary>
        /// <param name="bytedata">The bytedata.</param>
        /// <returns></returns>
        public static string BytesToString(byte[] bytedata)
        {
            string[] strdata = bytedata.Select(x => x.ToString("X2")).ToArray();
            return string.Join(" ", strdata);
        }
    }
}