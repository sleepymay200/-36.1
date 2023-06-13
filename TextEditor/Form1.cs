using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CustomTextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox1.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы
                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.
                richTextBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем содержимое файла в richTextBox
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
            {
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox1.Text, Encoding.GetEncoding(1251)); //Записываем в файл содержимое textBox с кодировкой 1251
            }
            richTextBox1.Clear();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox1.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы
                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.
                richTextBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем содержимое файла в richTextBox
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
            {
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox1.Text, Encoding.GetEncoding(1251)); //Записываем в файл содержимое textBox с кодировкой 1251
            }
            richTextBox1.Clear();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ensure that text is selected in the text box.   
            if (richTextBox1.SelectionLength > 0)
                // Copy the selected text to the Clipboard.
                richTextBox1.Copy();
        }

        private void InsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                // Determine if any text is selected in the text box.
                if (richTextBox1.SelectionLength > 0)
                {
                    // Ask user if they want to paste over currently selected text.
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                        // Move selectio
                        richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
                }
                // Paste current text in Clipboard into text box.
                richTextBox1.Paste();
            }
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
                // Cut the selected text in the control and paste it into the Clipboard.
                richTextBox1.Cut();
        }

        private void AlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select();
        }

        private void ByLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select(); // выравнивание только выделенного текста
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void ByCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select(); // выравнивание только выделенного текста
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void ByRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select(); // выравнивание только выделенного текста
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void AboutAppWindowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutWindow w = new AboutWindow();
            w.Show();
        }
    }
}
