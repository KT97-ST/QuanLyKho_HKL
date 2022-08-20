using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace QuanLyKho.Controllers.DungChung
{
    public class Cls_Encode_Decode
    {
        private static Cls_Encode_Decode instance;

        public static Cls_Encode_Decode Instance
        {
            get => instance != null ? instance : instance = new Cls_Encode_Decode();
            set => instance = value;
        }
        private Cls_Encode_Decode() { }


        /// <summary>
        /// Mã hóa
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string EncodeString(string str)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
        }

        /// <summary>
        /// Giải mã
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string DecodeString(string str)
        {
            if (IsBase64String(str) == false)
            {
                str = EncodeString(str);
            }

            return Encoding.UTF8.GetString(Convert.FromBase64String(str));
        }

        // kiểm tra có phảo base 64 không
        public  bool IsBase64String(string base64)
        {
            try
            {
                Convert.FromBase64String(base64);
                return true;
            }
            catch (FormatException exception)
            {
                // Handle the exception
                return false;
            }
            return false;
        }
    }
}
