namespace ExamWinForms
{
    partial class AddQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuestions));
            this.richTextBoxAddQuestions = new System.Windows.Forms.RichTextBox();
            this.richTexAddTruAnsw = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAddAnsw1 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAddAnsw2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btcancel = new System.Windows.Forms.Button();
            this.btAddQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxAddQuestions
            // 
            this.richTextBoxAddQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxAddQuestions.Location = new System.Drawing.Point(15, 39);
            this.richTextBoxAddQuestions.Name = "richTextBoxAddQuestions";
            this.richTextBoxAddQuestions.Size = new System.Drawing.Size(695, 114);
            this.richTextBoxAddQuestions.TabIndex = 0;
            this.richTextBoxAddQuestions.Text = "";
            this.richTextBoxAddQuestions.Click += new System.EventHandler(this.richTextBoxAddQuestions_Click);
            // 
            // richTexAddTruAnsw
            // 
            this.richTexAddTruAnsw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTexAddTruAnsw.Location = new System.Drawing.Point(15, 172);
            this.richTexAddTruAnsw.Name = "richTexAddTruAnsw";
            this.richTexAddTruAnsw.Size = new System.Drawing.Size(695, 68);
            this.richTexAddTruAnsw.TabIndex = 1;
            this.richTexAddTruAnsw.Text = "";
            this.richTexAddTruAnsw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTexAddTruAnsw_MouseClick);
            // 
            // richTextBoxAddAnsw1
            // 
            this.richTextBoxAddAnsw1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxAddAnsw1.Location = new System.Drawing.Point(15, 260);
            this.richTextBoxAddAnsw1.Name = "richTextBoxAddAnsw1";
            this.richTextBoxAddAnsw1.Size = new System.Drawing.Size(695, 58);
            this.richTextBoxAddAnsw1.TabIndex = 2;
            this.richTextBoxAddAnsw1.Text = "";
            this.richTextBoxAddAnsw1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBoxAddAnsw1_MouseClick);
            // 
            // richTextBoxAddAnsw2
            // 
            this.richTextBoxAddAnsw2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxAddAnsw2.Location = new System.Drawing.Point(15, 339);
            this.richTextBoxAddAnsw2.Name = "richTextBoxAddAnsw2";
            this.richTextBoxAddAnsw2.Size = new System.Drawing.Size(695, 57);
            this.richTextBoxAddAnsw2.TabIndex = 3;
            this.richTextBoxAddAnsw2.Text = "";
            this.richTextBoxAddAnsw2.Enter += new System.EventHandler(this.richTextBoxAddAnsw2_Enter);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Напишите вопрос";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Напишите верный ответ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Напишите вариант 1";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Напишите вариант 2";
            // 
            // btcancel
            // 
            this.btcancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btcancel.Location = new System.Drawing.Point(635, 412);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(75, 23);
            this.btcancel.TabIndex = 8;
            this.btcancel.Text = "Закрыть";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // btAddQ
            // 
            this.btAddQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAddQ.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAddQ.Location = new System.Drawing.Point(15, 412);
            this.btAddQ.Name = "btAddQ";
            this.btAddQ.Size = new System.Drawing.Size(227, 23);
            this.btAddQ.TabIndex = 9;
            this.btAddQ.Text = "Добавить этот вопрос";
            this.btAddQ.UseVisualStyleBackColor = true;
            this.btAddQ.Click += new System.EventHandler(this.btAddQ_Click);
            // 
            // AddQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btcancel;
            this.ClientSize = new System.Drawing.Size(722, 455);
            this.Controls.Add(this.btAddQ);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxAddAnsw2);
            this.Controls.Add(this.richTextBoxAddAnsw1);
            this.Controls.Add(this.richTexAddTruAnsw);
            this.Controls.Add(this.richTextBoxAddQuestions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление вопроса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxAddQuestions;
        private System.Windows.Forms.RichTextBox richTexAddTruAnsw;
        private System.Windows.Forms.RichTextBox richTextBoxAddAnsw1;
        private System.Windows.Forms.RichTextBox richTextBoxAddAnsw2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Button btAddQ;
    }
}