using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr1_kriptoanalizCaesar
{
    /// <summary>
    /// Метод смещения по Цезарю
    /// </summary>
    public partial class FormShift : Form
    {
        Coder coder;
        FileHandler fileHandler;
        public FormShift(Coder c, FileHandler f)
        {
            coder = c;
            fileHandler = f;
            InitializeComponent();
            InitializeElements();
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            Language lang;
            string message;
            int key;
            CollectParams(out lang, out message, out key);
            rtbResult.Text = $"Величина смещения: {key}\n_________________________________________________________" +
                $"\n\n{coder.DecodeByCaesarCipher(lang, message, key)}";
        }

        void CollectParams(out Language lang, out string message, out int key)
        {
            lang = (Language)cbLanguage.SelectedIndex;
            message = rtbMessage.Text;
            key = 3;
            try
            {
                key = (int)nudKey.Value;
                nudKey.Text = key.ToString(); //(в случае, если число не целое, то оно будет округлено
            }
            catch
            {
                MessageBox.Show("Вы забыли указать смещение. \nОно будет установлено автоматически на значение: 3");
            }
        }

        private void rtbMessage_TextChanged(object sender, EventArgs e)
        {
            if (rtbMessage.TextLength < 50)
                btnFullDecode.Enabled = true;
            else
                btnFullDecode.Enabled = false;
        }

        void InitializeElements()
        {
            if (cbLanguage.Items.Count == 0)
            {
                cbLanguage.Items.Add(Language.Русский.ToString());
                cbLanguage.Items.Add(Language.Английский.ToString());
            }
            cbLanguage.SelectedIndex = 0;
            nudKey.Value = 3;
            
            string clearMessage = fileHandler.ReadFile("longText.txt");
            rtbMessage.Text = coder.GenerateRandomShiftText(clearMessage,Language.Русский);
            btnFullDecode.Enabled = false;
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            string clearMessage = fileHandler.Open();
            rtbMessage.Text = coder.GenerateRandomShiftText(clearMessage, Language.Русский);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbMessage.Text = "";
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            fileHandler.Save(rtbResult.Text);
        }

        private void btnFullDecode_Click(object sender, EventArgs e)
        {
            rtbResult.Text = coder.GenerateAllShifts(rtbMessage.Text, (Language)cbLanguage.SelectedIndex);
        }
    }
}
