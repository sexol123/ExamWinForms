using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingLibrary;

namespace ExamWinForms
{

    public partial class AddQuestions : Form
    {
       
       List<Question> list  = new List<Question>(); 
        public AddQuestions(List<Question> list)
        {
           
            InitializeComponent();
            this.list = list;
        }

        void RichTextBox_ToChokolate(bool x)
        {
            if (x)
            {
                richTextBoxAddQuestions.BackColor = Color.Chocolate;
                richTexAddTruAnsw.BackColor = Color.Chocolate;
                richTextBoxAddAnsw1.BackColor= Color.Chocolate;
                richTextBoxAddAnsw2 .BackColor= Color.Chocolate;
                return;
            }
            richTextBoxAddQuestions.BackColor = Color.Azure;
            richTexAddTruAnsw.BackColor = Color.Azure;
            richTextBoxAddAnsw1.BackColor = Color.Azure;
            richTextBoxAddAnsw2.BackColor = Color.Azure;
        }

        bool iftyping()
        {
            
            if (string.IsNullOrWhiteSpace(richTextBoxAddQuestions.Text) || string.IsNullOrWhiteSpace(richTexAddTruAnsw.Text)
                || string.IsNullOrWhiteSpace(richTextBoxAddAnsw1.Text) || string.IsNullOrWhiteSpace(richTextBoxAddAnsw2.Text))
            {
                RichTextBox_ToChokolate(true);
                MessageBox.Show("Заполните все поля", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }            
            return true;
        }
        private void btAddQ_Click(object sender, EventArgs e)
        {
            if (!iftyping()) return;
            list.Add(new Question(richTextBoxAddQuestions.Text,richTexAddTruAnsw.Text,
                richTextBoxAddAnsw1.Text,richTextBoxAddAnsw2.Text));
            MessageBox.Show($"Вопрос успешно добавлен\nВопросов в списке: {list.Count} ", "Вопрос добавлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void richTextBoxAddQuestions_Click(object sender, EventArgs e)
        {
            RichTextBox_ToChokolate(false);
        }

        private void richTexAddTruAnsw_MouseClick(object sender, MouseEventArgs e)
        {
            RichTextBox_ToChokolate(false);
        }

        private void richTextBoxAddAnsw1_MouseClick(object sender, MouseEventArgs e)
        {
            RichTextBox_ToChokolate(false);
        }

        private void richTextBoxAddAnsw2_Enter(object sender, EventArgs e)
        {
            RichTextBox_ToChokolate(false);
        }

    }
}
