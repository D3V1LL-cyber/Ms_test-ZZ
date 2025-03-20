using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherApp
{
    class CaesarCipher
    {
        public string Encrypt(string text, int shift)
        {
            string result = "";

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char d = char.IsUpper(c) ? 'A' : 'a';
                    result += (char)((((c + shift) - d + 26) % 26) + d);
                }
                else
                {
                    result += c; // Не шифруем символы, которые не буквы
                }
            }
            return result;
        }

        public string Decrypt(string text, int shift)
        {
            return Encrypt(text, 26 - (shift % 26));
        }
    }
}
