using ExamWinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamWinForms
{
    public partial class FormUsername : Form
    {
        
        private string s;
        public FormUsername()
        {
           
            InitializeComponent();
           
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        
        private void btOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                textBoxUsername.BackColor = Color.Chocolate;
                MessageBox.Show("Введите имя", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
            else
            {
                Data.username = textBoxUsername.Text;
                DialogResult = DialogResult.OK;            
            }
           
        }

        private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxUsername.BackColor = Color.FloralWhite;
        }
    }
}
