using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr1_kriptoanalizCaesar
{
    /// <summary>
    /// Класс обработчика файлов (работа с загрузкой, сохранением)
    /// </summary>
    public class FileHandler
    {
        StreamReader reader;
        StreamWriter writer;

        public void Save(string text)
        {
            SaveFileDialog sf1 = new SaveFileDialog();
            sf1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (sf1.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = sf1.FileName;
            System.IO.File.WriteAllText(fileName, text);
        }

        public string Open()
        {
            OpenFileDialog of1 = new OpenFileDialog();
            of1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (of1.ShowDialog() == DialogResult.Cancel)
                return "";
            string filename = of1.FileName;
            // читаем файл в строку
            return System.IO.File.ReadAllText(filename);
        }

        public string ReadFile(string fileName)
        {
            if (fileName == "")
                return "";
            try
            {
                reader = new StreamReader(fileName);
                var messageText = reader.ReadToEnd();
                reader.Close();
                return messageText;
            }
            catch (Exception e)
            {
                MessageBox.Show("Вы запустили Release версию приложения. Просим вручную загрузить .txt файл из папки bin/Debug в текстовое окно. \n\n(Если хочется, чтобы текст загружался автоматически - запуск проекта производить через файл bin/Debug/Lr1-kriptoanalizCaesar.exe)");
                return "";
            }
        }

        public void WriteFile(string fileName, string resultText)
        {
            if (fileName == "")
            {
                MessageBox.Show("Не указано имя файла");
                return;
            }
            try
            {
                using (writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(resultText);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка: " + e);
                return;
            }
        }
    }
}
