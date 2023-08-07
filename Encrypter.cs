using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTest
{
    internal class Encrypter
    {
        public static string Encrypt(string txt)
        {
            string result = "";

            var txtArray = txt.ToCharArray();

            foreach (var item in txtArray)
            {
                var temp = item;
                char[] cc = new char[1] { ++temp };

                byte[] bytes = Encoding.UTF8.GetBytes(cc);

                result += Encoding.UTF8.GetString(bytes);
            }

            return result;
        }

        public static string Decrypt(string txt)
        {
            string result = "";

            var txtArray = txt.ToCharArray();

            foreach (var item in txtArray)
            {
                var temp = item;
                char[] cc = new char[1] { --temp };

                byte[] bytes = Encoding.UTF8.GetBytes(cc);

                result += Encoding.UTF8.GetString(bytes);
            }

            return result;
        }
    }
}
