using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1_kriptoanalizCaesar
{
    class CaesarCipher
    {
        //шифрование текста
        public string Encrypt(Language language, string clearMessage, int key)
            => CaesarEncoder(language, clearMessage, key);

        //дешифрование текста
        public string Decrypt(Language language, string encryptedMessage, int key)
            => CaesarEncoder(language, encryptedMessage, -key);

        /// <summary>
        /// Шифр Цезаря - вид шифра подстановки, в котором каждый символ в открытом тексте заменяется символом, 
        /// находящимся на некотором постоянном смещении (ключе) левее или правее него в алфавите.
        /// </summary>
        /// <param name="language">язык</param>
        /// <param name="message">сообщение</param>
        /// <param name="key">смещение (ключ)</param>
        /// <returns></returns>
        public string CaesarEncoder(Language language, string message, int key)
        {
            string alphBig;
            string alphSmall;
            Alphabet.GetAlphabet(language, out alphBig, out alphSmall);
            int alphabetPower = alphBig.Length;
            string resultText = "";
            for (int i = 0; i < message.Length; i++)
            {
                string letter = message[i].ToString();
                var letterIndex = alphSmall.IndexOf(letter);
                if (letterIndex > -1)
                {
                    int newLetterIndex = (letterIndex + key + alphabetPower) % alphabetPower;
                    resultText += alphSmall[newLetterIndex];
                }
                else
                {
                    letterIndex = alphBig.IndexOf(letter);//ищем среди больших                 
                    if (letterIndex < 0)//если символ не найден - добавляем в исходном виде.
                        resultText += letter;
                    else
                    {
                        int newLetterIndex = (letterIndex + key + alphabetPower) % alphabetPower;
                        resultText += alphBig[newLetterIndex];
                    }
                }             
            }
            return resultText;
        }
    }
}
