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
            this.list = list;
            InitializeComponent();
        }

        private void btAddQ_Click(object sender, EventArgs e)
        {
            
            list.Add(new Question(richTextBoxAddQuestions.Text,richTexAddTruAnsw.Text,
                richTextBoxAddAnsw1.Text,richTextBoxAddAnsw2.Text));
            
        }
    }
}
