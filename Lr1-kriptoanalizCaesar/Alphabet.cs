using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1_kriptoanalizCaesar
{
    public static class Alphabet
    {
        //символы азбуки
        public const string russian = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public const string english = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static void GetAlphabet(Language language, out string alphBig, out string alphSmall)
        {
            alphBig = "";
            alphSmall = "";
            if (language == Language.Русский)
            {
                alphBig = russian;
                alphSmall = russian.ToLower();
            }
            if (language == Language.Английский)
            {
                alphBig = english;
                alphSmall = english.ToLower();
            }
        }

        public static int GetAlphabetLength(Language language)
        {
            if (language == Language.Русский)
                return russian.Length;
            if (language == Language.Английский)
                return english.Length;
            return 0;
        }
    }
}
