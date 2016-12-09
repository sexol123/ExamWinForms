namespace ExamWinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.тестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьПамятьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.встроеныеВопросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отладочныйТестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестТанкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестИдеотизмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menustriptimer = new System.Windows.Forms.ToolStripMenuItem();
            this.время10СекундToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.время20СекундToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.время30СекундToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.время40СекундToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.время60СекундToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBoxQ = new System.Windows.Forms.RichTextBox();
            this.richTextBoxA1 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxA2 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxA3 = new System.Windows.Forms.RichTextBox();
            this.labeltime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btRestart = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_test_name = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Azure;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(27, 230);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Azure;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(27, 296);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click_1);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Azure;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(27, 371);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Вопрос №  ";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Location = new System.Drawing.Point(250, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Старт";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.LightCyan;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(494, 423);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Следующий вопрос";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button3_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестToolStripMenuItem,
            this.результатыToolStripMenuItem,
            this.встроеныеВопросыToolStripMenuItem,
            this.добавитьВопросToolStripMenuItem,
            this.menustriptimer,
            this.оПрограммеToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // тестToolStripMenuItem
            // 
            this.тестToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.очиститьПамятьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.тестToolStripMenuItem.Name = "тестToolStripMenuItem";
            this.тестToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.тестToolStripMenuItem.Text = "Тест";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить...";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить...";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // очиститьПамятьToolStripMenuItem
            // 
            this.очиститьПамятьToolStripMenuItem.Name = "очиститьПамятьToolStripMenuItem";
            this.очиститьПамятьToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.очиститьПамятьToolStripMenuItem.Text = "Очистить память";
            this.очиститьПамятьToolStripMenuItem.Click += new System.EventHandler(this.очиститьПамятьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // результатыToolStripMenuItem
            // 
            this.результатыToolStripMenuItem.Name = "результатыToolStripMenuItem";
            this.результатыToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.результатыToolStripMenuItem.Text = "Результаты";
            this.результатыToolStripMenuItem.Click += new System.EventHandler(this.результатыToolStripMenuItem_Click);
            // 
            // встроеныеВопросыToolStripMenuItem
            // 
            this.встроеныеВопросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отладочныйТестToolStripMenuItem,
            this.тестТанкиToolStripMenuItem,
            this.тестИдеотизмToolStripMenuItem});
            this.встроеныеВопросыToolStripMenuItem.Name = "встроеныеВопросыToolStripMenuItem";
            this.встроеныеВопросыToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.встроеныеВопросыToolStripMenuItem.Text = "Встроеные тесты";
            // 
            // отладочныйТестToolStripMenuItem
            // 
            this.отладочныйТестToolStripMenuItem.Name = "отладочныйТестToolStripMenuItem";
            this.отладочныйТестToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.отладочныйТестToolStripMenuItem.Text = "Отладочный тест";
            this.отладочныйТестToolStripMenuItem.Click += new System.EventHandler(this.отладочныйТестToolStripMenuItem_Click);
            // 
            // тестТанкиToolStripMenuItem
            // 
            this.тестТанкиToolStripMenuItem.Name = "тестТанкиToolStripMenuItem";
            this.тестТанкиToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.тестТанкиToolStripMenuItem.Text = "Тест \"Танки\"";
            this.тестТанкиToolStripMenuItem.Click += new System.EventHandler(this.тестТанкиToolStripMenuItem_Click);
            // 
            // тестИдеотизмToolStripMenuItem
            // 
            this.тестИдеотизмToolStripMenuItem.Name = "тестИдеотизмToolStripMenuItem";
            this.тестИдеотизмToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.тестИдеотизмToolStripMenuItem.Text = "Тест \"Быстрый\"";
            this.тестИдеотизмToolStripMenuItem.Click += new System.EventHandler(this.тестИдеотизмToolStripMenuItem_Click);
            // 
            // добавитьВопросToolStripMenuItem
            // 
            this.добавитьВопросToolStripMenuItem.Name = "добавитьВопросToolStripMenuItem";
            this.добавитьВопросToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.добавитьВопросToolStripMenuItem.Text = "Добавить вопрос";
            this.добавитьВопросToolStripMenuItem.Click += new System.EventHandler(this.добавитьВопросToolStripMenuItem_Click);
            // 
            // menustriptimer
            // 
            this.menustriptimer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.время10СекундToolStripMenuItem,
            this.время20СекундToolStripMenuItem,
            this.время30СекундToolStripMenuItem,
            this.время40СекундToolStripMenuItem,
            this.время60СекундToolStripMenuItem});
            this.menustriptimer.Name = "menustriptimer";
            this.menustriptimer.Size = new System.Drawing.Size(61, 20);
            this.menustriptimer.Text = "Таймер";
            this.menustriptimer.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // время10СекундToolStripMenuItem
            // 
            this.время10СекундToolStripMenuItem.Name = "время10СекундToolStripMenuItem";
            this.время10СекундToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.время10СекундToolStripMenuItem.Text = "Время 10 секунд";
            this.время10СекундToolStripMenuItem.Click += new System.EventHandler(this.время10СекундToolStripMenuItem_Click);
            // 
            // время20СекундToolStripMenuItem
            // 
            this.время20СекундToolStripMenuItem.Name = "время20СекундToolStripMenuItem";
            this.время20СекундToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.время20СекундToolStripMenuItem.Text = "Время 20 секунд";
            this.время20СекундToolStripMenuItem.Click += new System.EventHandler(this.время20СекундToolStripMenuItem_Click);
            // 
            // время30СекундToolStripMenuItem
            // 
            this.время30СекундToolStripMenuItem.Name = "время30СекундToolStripMenuItem";
            this.время30СекундToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.время30СекундToolStripMenuItem.Text = "Время 30 секунд";
            this.время30СекундToolStripMenuItem.Click += new System.EventHandler(this.время30СекундToolStripMenuItem_Click);
            // 
            // время40СекундToolStripMenuItem
            // 
            this.время40СекундToolStripMenuItem.Name = "время40СекундToolStripMenuItem";
            this.время40СекундToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.время40СекундToolStripMenuItem.Text = "Время 40 секунд";
            this.время40СекундToolStripMenuItem.Click += new System.EventHandler(this.время40СекундToolStripMenuItem_Click);
            // 
            // время60СекундToolStripMenuItem
            // 
            this.время60СекундToolStripMenuItem.Name = "время60СекундToolStripMenuItem";
            this.время60СекундToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.время60СекундToolStripMenuItem.Text = "Время 60 секунд";
            this.время60СекундToolStripMenuItem.Click += new System.EventHandler(this.время60СекундToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // richTextBoxQ
            // 
            this.richTextBoxQ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxQ.BackColor = System.Drawing.Color.Azure;
            this.richTextBoxQ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBoxQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxQ.Location = new System.Drawing.Point(21, 59);
            this.richTextBoxQ.Name = "richTextBoxQ";
            this.richTextBoxQ.ReadOnly = true;
            this.richTextBoxQ.Size = new System.Drawing.Size(606, 137);
            this.richTextBoxQ.TabIndex = 13;
            this.richTextBoxQ.Text = "";
            this.richTextBoxQ.TextChanged += new System.EventHandler(this.richTextBoxQ_TextChanged);
            // 
            // richTextBoxA1
            // 
            this.richTextBoxA1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxA1.BackColor = System.Drawing.Color.Azure;
            this.richTextBoxA1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxA1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBoxA1.Enabled = false;
            this.richTextBoxA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxA1.Location = new System.Drawing.Point(51, 202);
            this.richTextBoxA1.Name = "richTextBoxA1";
            this.richTextBoxA1.ReadOnly = true;
            this.richTextBoxA1.Size = new System.Drawing.Size(576, 65);
            this.richTextBoxA1.TabIndex = 14;
            this.richTextBoxA1.Text = "";
            this.richTextBoxA1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBoxA1_MouseClick);
            this.richTextBoxA1.TextChanged += new System.EventHandler(this.richTextBoxA1_TextChanged);
            this.richTextBoxA1.MouseLeave += new System.EventHandler(this.richTextBoxA1_MouseLeave);
            // 
            // richTextBoxA2
            // 
            this.richTextBoxA2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxA2.BackColor = System.Drawing.Color.Azure;
            this.richTextBoxA2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxA2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBoxA2.Enabled = false;
            this.richTextBoxA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxA2.Location = new System.Drawing.Point(51, 273);
            this.richTextBoxA2.Name = "richTextBoxA2";
            this.richTextBoxA2.ReadOnly = true;
            this.richTextBoxA2.Size = new System.Drawing.Size(576, 65);
            this.richTextBoxA2.TabIndex = 15;
            this.richTextBoxA2.Text = "";
            this.richTextBoxA2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBoxA2_MouseClick);
            this.richTextBoxA2.TextChanged += new System.EventHandler(this.richTextBoxA2_TextChanged);
            // 
            // richTextBoxA3
            // 
            this.richTextBoxA3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxA3.BackColor = System.Drawing.Color.Azure;
            this.richTextBoxA3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxA3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBoxA3.Enabled = false;
            this.richTextBoxA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxA3.Location = new System.Drawing.Point(51, 344);
            this.richTextBoxA3.Name = "richTextBoxA3";
            this.richTextBoxA3.ReadOnly = true;
            this.richTextBoxA3.Size = new System.Drawing.Size(576, 65);
            this.richTextBoxA3.TabIndex = 16;
            this.richTextBoxA3.Text = "";
            this.richTextBoxA3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBoxA3_MouseClick);
            this.richTextBoxA3.TextChanged += new System.EventHandler(this.richTextBoxA3_TextChanged);
            // 
            // labeltime
            // 
            this.labeltime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltime.AutoSize = true;
            this.labeltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltime.Location = new System.Drawing.Point(503, 26);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(77, 24);
            this.labeltime.TabIndex = 17;
            this.labeltime.Text = "Время: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 18;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btRestart
            // 
            this.btRestart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btRestart.BackColor = System.Drawing.Color.LightCyan;
            this.btRestart.Enabled = false;
            this.btRestart.Location = new System.Drawing.Point(250, 30);
            this.btRestart.Name = "btRestart";
            this.btRestart.Size = new System.Drawing.Size(78, 23);
            this.btRestart.TabIndex = 19;
            this.btRestart.Text = "Сначала";
            this.btRestart.UseVisualStyleBackColor = false;
            this.btRestart.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(105, 29);
            this.labelName.MaximumSize = new System.Drawing.Size(130, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 20);
            this.labelName.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Пользователь: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_test_name
            // 
            this.label_test_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_test_name.AutoSize = true;
            this.label_test_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_test_name.Location = new System.Drawing.Point(18, 425);
            this.label_test_name.Name = "label_test_name";
            this.label_test_name.Size = new System.Drawing.Size(72, 17);
            this.label_test_name.TabIndex = 22;
            this.label_test_name.Text = "Название";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.ForeColor = System.Drawing.Color.Gold;
            this.progressBar1.Location = new System.Drawing.Point(21, 190);
            this.progressBar1.MarqueeAnimationSpeed = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(606, 13);
            this.progressBar1.TabIndex = 23;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(639, 458);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label_test_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btRestart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labeltime);
            this.Controls.Add(this.richTextBoxA3);
            this.Controls.Add(this.richTextBoxA2);
            this.Controls.Add(this.richTextBoxA1);
            this.Controls.Add(this.richTextBoxQ);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестировщик";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.MainForm_Layout);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem тестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВопросToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxQ;
        private System.Windows.Forms.RichTextBox richTextBoxA1;
        private System.Windows.Forms.RichTextBox richTextBoxA2;
        private System.Windows.Forms.RichTextBox richTextBoxA3;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btRestart;
        private System.Windows.Forms.ToolStripMenuItem очиститьПамятьToolStripMenuItem;
        public System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ToolStripMenuItem результатыToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menustriptimer;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem встроеныеВопросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестТанкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отладочныйТестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem время20СекундToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem время30СекундToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem время40СекундToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem время60СекундToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem время10СекундToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестИдеотизмToolStripMenuItem;
        private System.Windows.Forms.Label label_test_name;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

