using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1_kriptoanalizCaesar
{
    //enum определен вне класса, но внутри namespace, чтобы был доступ из всех частей кода
    public enum Language { Русский, Английский }

    public class Coder
    {
        CaesarCipher caesarCipher = new CaesarCipher();
        FrequancyCipher frequancyCipher = new FrequancyCipher();

        public string EncodeByCaesarCipher(Language lang, string message, int key)
        {
            if (message == "")
                return "";
            return caesarCipher.Encrypt(lang, message, key);
        }
        public string DecodeByCaesarCipher(Language lang, string message, int key)
        {
            if (message == "")
                return "";
            return caesarCipher.Decrypt(lang, message, key);
        }

        public string GenerateRandomShiftText(string message, Language l)
        {
            Random r = new Random();

            int key = r.Next(1, Alphabet.GetAlphabetLength(l)-1);
            return caesarCipher.Encrypt(l, message, key);
        }

        public string GenerateAllShifts(string message, Language l)
        {
            string result = "";
            for (int i = 1; i <= Alphabet.GetAlphabetLength(l)-1; i++)
            {
                result += $"Смещение = {i}.\nРезультат: {DecodeByCaesarCipher(l, message, i)}\n" +
                    $"____________________________________________________\n";
            }
            return result;
        }

        public void ClearPairs()
        {
            frequancyCipher.pairs.Clear();
        }

        public string CountFrequancy(string message)
        {
            Dictionary<char, int> frequancy = frequancyCipher.CountFrequancy(message);
            string result = "";
            foreach (var pair in frequancy.OrderByDescending(pair => pair.Value))
                result += $"{pair.Key} - {pair.Value}\n";
            return result;
        }

        public string HelpChooseByFrequancyTable(string message)
        {
            string result = "Предлагаемые варианты частот для букв (согласно приближенным данным по таблице частот):";

            //считаем частоту использования для каждой буквы
            Dictionary<char, int> frequancy = frequancyCipher.CountFrequancy(message);
            foreach (var pair in frequancy.OrderByDescending(pair => pair.Value))
            {
                //сортируем похожие буквы по наибольшему совпадению с частотой
                Dictionary<char, double> letterDifference = new Dictionary<char, double>();

                //частота упротребления буквы в %
                double frequancyLetter = pair.Value / (double)message.Length;

                result += $"\n\n{pair.Key}({Math.Round(frequancyLetter, 3)}): ";

                foreach(KeyValuePair<char, double> freaquancyTableLetter in frequancyCipher.frequancyTable)
                {
                    if (Math.Abs(frequancyLetter - freaquancyTableLetter.Value) <= 0.010)
                        letterDifference.Add(freaquancyTableLetter.Key, Math.Abs(frequancyLetter - freaquancyTableLetter.Value));     
                }

                foreach (var diff in letterDifference.OrderBy(d => d.Value))
                    result += $"{diff.Key}({frequancyCipher.frequancyTable[diff.Key]}); ";
            }
            return result;
        }

        public void CreateFrequancyTable()
        {
            frequancyCipher.MadeFrequancyTable();
        }

    }
}
