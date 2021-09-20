using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr1_kriptoanalizCaesar
{
    /// <summary>
    /// Метод частотного криптоанализа
    /// </summary>
    public partial class FormFrequancy : Form
    {
        Coder coder;
        FileHandler fileHandler;
        string message;
        Dictionary<char, char> pairs = new Dictionary<char, char>(); //ключ-значение
        Dictionary<char, List<int>> pairsIndexes = new Dictionary<char, List<int>>(); //ключ-индексы
        List<int> changedIndexes = new List<int>(); //индексы всех замененных символов


        #region Блок отвечающий за добавление/удаление пары ключ-значение
        private void btnDeleteChange_Click(object sender, EventArgs e)
        {
            //delete from txtbx & dictionary
            char c = lbLetterPair.SelectedItem.ToString()[0];
            

            List<int> ids = pairsIndexes[c]; //берем список индексов для данного ключа
            foreach (int i in ids)
            {
                changedIndexes.Remove(i);
                rtbMessage.Text = rtbMessage.Text.Remove(i, 1);
                rtbMessage.Text = rtbMessage.Text.Insert(i, c.ToString());
            }

            lbLetterPair.Items.Remove(lbLetterPair.SelectedItem);
            pairs.Remove(c);
            pairsIndexes.Remove(c);
            ShowText();
        }

        private void btnAddChange_Click(object sender, EventArgs e)
        {
            //создаем пару ключ-значение
            KeyValuePair<char, char> pair = new KeyValuePair<char, char>(Convert.ToChar(tbClearLetter.Text), Convert.ToChar(tbChangedLetter.Text));
            //индексы для данного ключа(буквы)
            List<int> idsForLetter = new List<int>();

            //подготовка сообщения для обработки
            string tempMessage = message;
            tempMessage = Regex.Replace(tempMessage, "\r", "");

            for (int i = 0; i < rtbMessage.Text.Length; i++)
            {
                if (pair.Key == tempMessage[i])
                {
                    changedIndexes.Add(i);//список элементов, которые подверглись замены
                    idsForLetter.Add(i);//индексы данной буквы в тексте 

                    int startPosition = tempMessage.IndexOf(pair.Key);
                    tempMessage = tempMessage.Remove(startPosition, 1);
                    tempMessage = tempMessage.Insert(startPosition, pair.Value.ToString());
                    rtbMessage.Text = rtbMessage.Text.Remove(i, 1);
                    rtbMessage.Text = rtbMessage.Text.Insert(i, pair.Value.ToString());
                }
            }

            //добавляем информацию о парах и индексах ключа
            pairs.Add(pair.Key, pair.Value);
            pairsIndexes.Add(pair.Key, idsForLetter);

            //изменения в интерфейсе
            lbLetterPair.Items.Add($"{tbClearLetter.Text} -> {tbChangedLetter.Text}");
            tbChangedLetter.Clear();
            tbClearLetter.Clear();
            ShowText();
        }

        #endregion

        #region Блок отвечающий за стартовые процессы при загрузке формы или нового текста
        public FormFrequancy(Coder c, FileHandler f)
        {
            coder = c;
            fileHandler = f;
            InitializeComponent();
            btnAddChange.Enabled = false;
            btnDeleteChange.Enabled = false;
        }

        private void FormFrequancy_Load(object sender, EventArgs e)
        {
            string clearMessage = fileHandler.ReadFile("longText.txt").ToUpper();
            ToProcessText(clearMessage);
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            btnAddChange.Enabled = false;
            btnDeleteChange.Enabled = false;

            string clearMessage = fileHandler.Open().ToUpper(); 
            ToProcessText(clearMessage);
        }

        private void ToProcessText(string clearMessage)
        {
            lbLetterPair.Items.Clear();
            coder.ClearPairs();
            pairs.Clear();
            pairsIndexes.Clear();
            changedIndexes.Clear();

            message = coder.GenerateRandomShiftText(clearMessage, Language.Русский);
            rtbMessage.Text = message;
            message = Regex.Replace(message, "\r", "");
            rtbLetterFrequancy.Text = coder.CountFrequancy(message);
        }

        #endregion

        #region Блок отвечающий за ввод/удаление данных ключ-значение

        private void tbClearLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void tbChangedLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
            e.KeyChar = char.ToUpper(e.KeyChar);

            if (tbChangedLetter.TextLength == 1 && tbClearLetter.TextLength == 1)
                btnAddChange.Enabled = true;
            else
                btnAddChange.Enabled = false;
        }

        private void tbClearLetter_TextChanged(object sender, EventArgs e)
        {
            CheckButtonsEnabled();
        }

        private void tbChangedLetter_TextChanged(object sender, EventArgs e)
        {
            CheckButtonsEnabled();
        }

        private void CheckButtonsEnabled()
        {
            if (tbChangedLetter.TextLength == 1 && tbClearLetter.TextLength == 1)
                btnAddChange.Enabled = true;
            else
                btnAddChange.Enabled = false;
        }

        private void lbLetterPair_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbLetterPair.SelectedIndex != -1)
                btnDeleteChange.Enabled = true;
            else
                btnDeleteChange.Enabled = false;
        }


        #endregion

        #region Блок отвечающий за изменения checkBox
        private void cbShowFirstText_CheckedChanged(object sender, EventArgs e)
        {

            if (cbShowFirstText.Checked == true)
            {
                cbShowChangedText.Checked = false;
                JustShowFirstText();
            }
                
            if (cbShowFirstText.Checked == false)
                ShowDefaultText();
        }

        private void cbShowChangedText_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowChangedText.Checked == true)
            {
                cbShowFirstText.Checked = false;
                JustShowChangedText();
            }

            if (cbShowChangedText.Checked == false)
                ShowDefaultText();
        }

        #endregion

        #region Блок с демонстрацией текста
        private void ShowText()
        {
            if (cbShowFirstText.Checked == true)
                JustShowFirstText();
            if (cbShowChangedText.Checked == true)
                JustShowChangedText();
            if (cbShowChangedText.Checked == false && cbShowFirstText.Checked == false)
                ShowDefaultText();
        }
        private void JustShowFirstText()
        {
            if (changedIndexes.Count > 0)
            {
                //показываем исходный текст
                for (int i = 0; i < rtbMessage.Text.Length; i++)
                {
                    //делаем обычным текст-замену
                    if (changedIndexes.Contains(i))
                    {
                        rtbMessage.SelectionStart = i;
                        rtbMessage.SelectionLength = 1;
                        rtbMessage.SelectionColor = Color.Gray;
                        rtbMessage.SelectionBackColor = Color.White;
                        rtbMessage.SelectionFont = new Font("Microsoft Sans Serif", 7);
                    }
                    //выделяем исходный текст
                    else
                    {
                        rtbMessage.SelectionStart = i;
                        rtbMessage.SelectionLength = 1;
                        rtbMessage.SelectionColor = Color.Black;
                        rtbMessage.SelectionBackColor = Color.White;
                        rtbMessage.SelectionFont = new Font("Microsoft Sans Serif", 9);
                    }
                }
            }
        }

        private void JustShowChangedText() 
        {
            if (changedIndexes.Count > 0)
            {
                //показываем исходный текст
                for (int i = 0; i < rtbMessage.Text.Length; i++)
                {
                    //выделяем текст-замену
                    if (changedIndexes.Contains(i))
                    {
                        rtbMessage.SelectionStart = i;
                        rtbMessage.SelectionLength = 1;
                        rtbMessage.SelectionColor = Color.Black;
                        rtbMessage.SelectionBackColor = Color.White;
                        rtbMessage.SelectionFont = new Font("Microsoft Sans Serif", 9);
                    }
                    //делаем обычным исходный текст
                    else
                    {
                        rtbMessage.SelectionStart = i;
                        rtbMessage.SelectionLength = 1;
                        rtbMessage.SelectionColor = Color.Gray;
                        rtbMessage.SelectionBackColor = Color.White;
                        rtbMessage.SelectionFont = new Font("Microsoft Sans Serif", 7);
                    }
                }
            }
        }

        private void ShowDefaultText()
        {
            if (changedIndexes.Count > 0)
            {
                //показываем исходный текст
                for (int i = 0; i < rtbMessage.Text.Length; i++)
                {
                    //выделяем текст-замену
                    if (changedIndexes.Contains(i))
                    {
                        rtbMessage.SelectionStart = i;
                        rtbMessage.SelectionLength = 1;
                        rtbMessage.SelectionColor = Color.Red;
                        rtbMessage.SelectionBackColor = Color.Yellow;
                        rtbMessage.SelectionFont = new Font("Microsoft Sans Serif", 9);
                    }
                    //делаем обычным исходный текст
                    else
                    {
                        rtbMessage.SelectionStart = i;
                        rtbMessage.SelectionLength = 1;
                        rtbMessage.SelectionColor = Color.Black;
                        rtbMessage.SelectionBackColor = Color.White;
                        rtbMessage.SelectionFont = new Font("Microsoft Sans Serif", 9);
                    }
                }
            }
        }

        #endregion

        private void btnHelpFrequancy_Click(object sender, EventArgs e)
        {
            HelpChoice f = new HelpChoice(coder, message);
            f.ShowDialog();
        }
    }
}
