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
            this.добавитьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Azure;
            this.radioButton1.Location = new System.Drawing.Point(27, 230);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Azure;
            this.radioButton2.Location = new System.Drawing.Point(27, 296);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Azure;
            this.radioButton3.Location = new System.Drawing.Point(27, 371);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            this.radioButton3.Click += new System.EventHandler(this.radioButton2_Click);
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
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестToolStripMenuItem,
            this.добавитьВопросToolStripMenuItem,
            this.результатыToolStripMenuItem});
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
            // добавитьВопросToolStripMenuItem
            // 
            this.добавитьВопросToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.свойToolStripMenuItem});
            this.добавитьВопросToolStripMenuItem.Name = "добавитьВопросToolStripMenuItem";
            this.добавитьВопросToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.добавитьВопросToolStripMenuItem.Text = "Добавить вопрос";
            // 
            // свойToolStripMenuItem
            // 
            this.свойToolStripMenuItem.Name = "свойToolStripMenuItem";
            this.свойToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.свойToolStripMenuItem.Text = "Свой";
            this.свойToolStripMenuItem.Click += new System.EventHandler(this.свойToolStripMenuItem_Click);
            // 
            // результатыToolStripMenuItem
            // 
            this.результатыToolStripMenuItem.Name = "результатыToolStripMenuItem";
            this.результатыToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.результатыToolStripMenuItem.Text = "Результаты";
            this.результатыToolStripMenuItem.Click += new System.EventHandler(this.результатыToolStripMenuItem_Click);
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
            this.richTextBoxQ.Location = new System.Drawing.Point(27, 59);
            this.richTextBoxQ.Name = "richTextBoxQ";
            this.richTextBoxQ.ReadOnly = true;
            this.richTextBoxQ.Size = new System.Drawing.Size(600, 137);
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
            this.richTextBoxA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxA1.Location = new System.Drawing.Point(57, 202);
            this.richTextBoxA1.Name = "richTextBoxA1";
            this.richTextBoxA1.ReadOnly = true;
            this.richTextBoxA1.Size = new System.Drawing.Size(570, 65);
            this.richTextBoxA1.TabIndex = 14;
            this.richTextBoxA1.Text = "";
            this.richTextBoxA1.TextChanged += new System.EventHandler(this.richTextBoxA1_TextChanged);
            // 
            // richTextBoxA2
            // 
            this.richTextBoxA2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxA2.BackColor = System.Drawing.Color.Azure;
            this.richTextBoxA2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxA2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBoxA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxA2.Location = new System.Drawing.Point(57, 273);
            this.richTextBoxA2.Name = "richTextBoxA2";
            this.richTextBoxA2.ReadOnly = true;
            this.richTextBoxA2.Size = new System.Drawing.Size(570, 65);
            this.richTextBoxA2.TabIndex = 15;
            this.richTextBoxA2.Text = "";
            this.richTextBoxA2.TextChanged += new System.EventHandler(this.richTextBoxA2_TextChanged);
            // 
            // richTextBoxA3
            // 
            this.richTextBoxA3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxA3.BackColor = System.Drawing.Color.Azure;
            this.richTextBoxA3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxA3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBoxA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxA3.Location = new System.Drawing.Point(57, 344);
            this.richTextBoxA3.Name = "richTextBoxA3";
            this.richTextBoxA3.ReadOnly = true;
            this.richTextBoxA3.Size = new System.Drawing.Size(570, 65);
            this.richTextBoxA3.TabIndex = 16;
            this.richTextBoxA3.Text = "";
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
            this.labelName.Location = new System.Drawing.Point(107, 37);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 13);
            this.labelName.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Пользователь: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(639, 458);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестировщик";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ToolStripMenuItem свойToolStripMenuItem;
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
    }
}

