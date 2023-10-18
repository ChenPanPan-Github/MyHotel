using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyHotel.Helper
{
    /// <summary>
    /// 加密类
    /// </summary>
    public static class Encryption
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Md5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.Default.GetBytes(str);
            byte[] md5data = md5.ComputeHash(data);
            md5.Clear();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < md5data.Length - 1; i++)
            {
                sb.Append(md5data[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
