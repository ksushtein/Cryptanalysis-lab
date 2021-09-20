using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1_kriptoanalizCaesar
{
    public class FrequancyCipher
    {
        public Dictionary<char, double> frequancyTable = new Dictionary<char, double>();
        public List<KeyValuePair<char, char>> pairs = new List<KeyValuePair<char, char>>();
        

        public Dictionary<char, int> CountFrequancy(string message)
        {
            Dictionary<char, int> frequancies = new Dictionary<char, int>();

            for (int i=0;i<Alphabet.GetAlphabetLength(Language.Русский); i++)
            {
                frequancies.Add(Alphabet.russian[i], 0);
            }

            for (int i = 0; i < message.Length; i++)
            {
                char c = message[i];
                c = Convert.ToChar(c.ToString().ToUpper());
                if (Alphabet.russian.Contains(c))
                {
                    frequancies[c] = frequancies[c] + 1;
                }
            }
            return frequancies;
        }

        public void MadeFrequancyTable()
        {
            frequancyTable.Add('О', 0.090);
            frequancyTable.Add('Е', 0.072);
            frequancyTable.Add('А', 0.062);
            frequancyTable.Add('И', 0.062);
            frequancyTable.Add('Т', 0.053);
            frequancyTable.Add('Н', 0.052);
            frequancyTable.Add('С', 0.045);
            frequancyTable.Add('Р', 0.040);

            frequancyTable.Add('В', 0.038);
            frequancyTable.Add('Л', 0.035);
            frequancyTable.Add('К', 0.028);
            frequancyTable.Add('М', 0.026);
            frequancyTable.Add('Д', 0.025);
            frequancyTable.Add('П', 0.023);
            frequancyTable.Add('У', 0.021);
            frequancyTable.Add('Я', 0.018);

            frequancyTable.Add('З', 0.016);
            frequancyTable.Add('Ы', 0.016);
            frequancyTable.Add('Б', 0.014);
            frequancyTable.Add('Ь', 0.014);
            frequancyTable.Add('Г', 0.013);
            frequancyTable.Add('Ч', 0.012);
            frequancyTable.Add('Й', 0.010);
            frequancyTable.Add('Х', 0.009);

            frequancyTable.Add('Ж', 0.007);
            frequancyTable.Add('Ш', 0.006);
            frequancyTable.Add('Ю', 0.006);
            frequancyTable.Add('Ц', 0.004);
            frequancyTable.Add('Щ', 0.003);
            frequancyTable.Add('Э', 0.003);
            frequancyTable.Add('Ф', 0.002);
            frequancyTable.Add('Ъ', 0.0037);
        }
    }

    
}
