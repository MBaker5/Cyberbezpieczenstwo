using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberbezpieczenstwo.Classes
{
    public static class HashHandler
    {

        public static string Hash(string str) 
        {
            using var sha256 = SHA256.Create();
            var B = Encoding.Default.GetBytes(str);
            var hashed = sha256.ComputeHash(B);
            return Convert.ToBase64String(hashed);
        }

        public static string DeHash(string str)
        {
            using var sha384 = SHA384.Create();

            return "stuff";
        }


    }
}
