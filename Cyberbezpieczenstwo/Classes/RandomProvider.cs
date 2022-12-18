using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberbezpieczenstwo.Classes
{
    internal class RandomProvider
    {
            static Random rd = new Random();
            internal static string CreateString(int stringLength)
            {
                const string allowedChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz";
                char[] chars = new char[stringLength];

                for (int i = 0; i < stringLength; i++)
                {
                    chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
                }

                return new string(chars);
            }
        
            
        
            
    }
}
