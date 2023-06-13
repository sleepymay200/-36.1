namespace CustomTextEditor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            previewToolStripMenuItem = new ToolStripMenuItem();
            printerSettingsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            insertToolStripMenuItem = new ToolStripMenuItem();
            eraseToolStripMenuItem = new ToolStripMenuItem();
            serviceToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            alignToolStripMenuItem = new ToolStripMenuItem();
            ByLeftToolStripMenuItem = new ToolStripMenuItem();
            byCenterToolStripMenuItem = new ToolStripMenuItem();
            ByRightToolStripMenuItem = new ToolStripMenuItem();
            aboutAppToolStripMenuItem = new ToolStripMenuItem();
            aboutAppToolStripMenuItem1 = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            buttonOpen = new Button();
            buttonSave = new Button();
            button10 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(14, 40);
            richTextBox1.Margin = new Padding(4, 3, 4, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(752, 700);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Title = "Сохраните текстовый файл";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Title = "Выберите текстовый файл";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, serviceToolStripMenuItem, aboutAppToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(903, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, printToolStripMenuItem, previewToolStripMenuItem, printerSettingsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "файлToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(47, 20);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "открытьToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(242, 22);
            openToolStripMenuItem.Text = "Открыть";
            openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(242, 22);
            saveToolStripMenuItem.Text = "Сохранить";
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // печатьToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "печатьToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(242, 22);
            printToolStripMenuItem.Text = "Печать";
            // 
            // предварительныйПросмотрToolStripMenuItem
            // 
            previewToolStripMenuItem.Name = "предварительныйПросмотрToolStripMenuItem";
            previewToolStripMenuItem.Size = new Size(242, 22);
            previewToolStripMenuItem.Text = "Предварительный просмотр";
            // 
            // настройкаПринтераToolStripMenuItem
            // 
            printerSettingsToolStripMenuItem.Name = "настройкаПринтераToolStripMenuItem";
            printerSettingsToolStripMenuItem.Size = new Size(242, 22);
            printerSettingsToolStripMenuItem.Text = "Настройка принтера";
            // 
            // выходToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "выходToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(242, 22);
            exitToolStripMenuItem.Text = "Выход";
            // 
            // редактироватьToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, insertToolStripMenuItem, eraseToolStripMenuItem });
            editToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(110, 20);
            editToolStripMenuItem.Text = "Редактировать";
            // 
            // вырезатьToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(144, 22);
            cutToolStripMenuItem.Text = "Вырезать ";
            cutToolStripMenuItem.Click += CutToolStripMenuItem_Click;
            // 
            // копираватьToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "копираватьToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(144, 22);
            copyToolStripMenuItem.Text = "Копиравать";
            copyToolStripMenuItem.Click += CopyToolStripMenuItem_Click;
            // 
            // вставитьToolStripMenuItem
            // 
            insertToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            insertToolStripMenuItem.Size = new Size(144, 22);
            insertToolStripMenuItem.Text = "Вставить";
            insertToolStripMenuItem.Click += InsertToolStripMenuItem_Click;
            // 
            // очиститьToolStripMenuItem
            // 
            eraseToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            eraseToolStripMenuItem.Size = new Size(144, 22);
            eraseToolStripMenuItem.Text = "Очистить";
            // 
            // сервисToolStripMenuItem
            // 
            serviceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { colorToolStripMenuItem, fontToolStripMenuItem, alignToolStripMenuItem });
            serviceToolStripMenuItem.Name = "сервисToolStripMenuItem";
            serviceToolStripMenuItem.Size = new Size(61, 20);
            serviceToolStripMenuItem.Text = "Сервис";
            // 
            // цветToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "цветToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(158, 22);
            colorToolStripMenuItem.Text = "Цвет";
            // 
            // шрифтToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(158, 22);
            fontToolStripMenuItem.Text = "Шрифт";
            // 
            // выравниваниеToolStripMenuItem
            // 
            alignToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ByLeftToolStripMenuItem, byCenterToolStripMenuItem, ByRightToolStripMenuItem });
            alignToolStripMenuItem.Name = "выравниваниеToolStripMenuItem";
            alignToolStripMenuItem.Size = new Size(158, 22);
            alignToolStripMenuItem.Text = "Выравнивание";
            alignToolStripMenuItem.Click += AlignToolStripMenuItem_Click;
            // 
            // поЛевомуToolStripMenuItem
            // 
            ByLeftToolStripMenuItem.Name = "поЛевомуToolStripMenuItem";
            ByLeftToolStripMenuItem.Size = new Size(144, 22);
            ByLeftToolStripMenuItem.Text = "По левому";
            ByLeftToolStripMenuItem.Click += ByLeftToolStripMenuItem_Click;
            // 
            // поЦентруToolStripMenuItem
            // 
            byCenterToolStripMenuItem.Name = "поЦентруToolStripMenuItem";
            byCenterToolStripMenuItem.Size = new Size(144, 22);
            byCenterToolStripMenuItem.Text = "По центру";
            byCenterToolStripMenuItem.Click += ByCenterToolStripMenuItem_Click;
            // 
            // поПравамуToolStripMenuItem
            // 
            ByRightToolStripMenuItem.Name = "поПравамуToolStripMenuItem";
            ByRightToolStripMenuItem.Size = new Size(144, 22);
            ByRightToolStripMenuItem.Text = "По праваму";
            ByRightToolStripMenuItem.Click += ByRightToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            aboutAppToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutAppToolStripMenuItem1 });
            aboutAppToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            aboutAppToolStripMenuItem.Size = new Size(96, 20);
            aboutAppToolStripMenuItem.Text = "О программе";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            aboutAppToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            aboutAppToolStripMenuItem1.Size = new Size(180, 22);
            aboutAppToolStripMenuItem1.Text = "О программе";
            aboutAppToolStripMenuItem1.Click += AboutAppWindowToolStripMenuItem1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(791, 84);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(90, 26);
            button1.TabIndex = 2;
            button1.Text = "Вырезать";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(791, 116);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(90, 26);
            button2.TabIndex = 3;
            button2.Text = "Копировать";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(791, 149);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(90, 26);
            button3.TabIndex = 4;
            button3.Text = "Вставить";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(791, 181);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(90, 26);
            button4.TabIndex = 5;
            button4.Text = "Очистить";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(791, 213);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(90, 26);
            button5.TabIndex = 6;
            button5.Text = "Выделить";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(791, 280);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(90, 26);
            button6.TabIndex = 7;
            button6.Text = "Цвет";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(791, 331);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(90, 26);
            button7.TabIndex = 8;
            button7.Text = "Шрифт";
            button7.UseVisualStyleBackColor = true;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(791, 382);
            buttonOpen.Margin = new Padding(4, 3, 4, 3);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(90, 26);
            buttonOpen.TabIndex = 9;
            buttonOpen.Text = "Открыть";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(791, 437);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(90, 26);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // button10
            // 
            button10.Location = new Point(791, 491);
            button10.Margin = new Padding(4, 3, 4, 3);
            button10.Name = "button10";
            button10.Size = new Size(90, 26);
            button10.TabIndex = 11;
            button10.Text = "Выход";
            button10.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 749);
            Controls.Add(button10);
            Controls.Add(buttonSave);
            Controls.Add(buttonOpen);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Custom Text Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem previewToolStripMenuItem;
        private ToolStripMenuItem printerSettingsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem insertToolStripMenuItem;
        private ToolStripMenuItem eraseToolStripMenuItem;
        private ToolStripMenuItem serviceToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem alignToolStripMenuItem;
        private ToolStripMenuItem aboutAppToolStripMenuItem;
        private ToolStripMenuItem aboutAppToolStripMenuItem1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button buttonOpen;
        private Button buttonSave;
        private Button button10;
        private ToolStripMenuItem ByLeftToolStripMenuItem;
        private ToolStripMenuItem byCenterToolStripMenuItem;
        private ToolStripMenuItem ByRightToolStripMenuItem;
    }
}

