using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1_kriptoanalizCaesar
{
    public interface ICipher
    {
        /// <summary>
        /// Шифрование текста
        /// </summary>
        /// <param name="language"></param>
        /// <param name="clearMessage"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        string Encrypt(string language, string clearMessage, int key);

        /// <summary>
        /// Дешифрование текста
        /// </summary>
        /// <param name="language"></param>
        /// <param name="encryptedMessage">(зашифрованное сообщение)</param>
        /// <param name="key"></param>
        /// <returns></returns>
        string Decrypt(string language, string encryptedMessage, int key);
    }
}
