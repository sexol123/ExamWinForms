using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using TestingLibrary;

namespace ExamWinForms
{
    public partial class MainForm : Form
    {
        private bool start = false;
        public string FileName;
        public int numq = 0;
        const int valtime = 10;
        string answeredQ { get; set; }
        private FormUsername nameDLG = new FormUsername();
        private ResultsWindow resDLG;
        private byte time = valtime;
        private List<Question> listquestions = new List<Question>();
        private readonly Random mix = new Random();
        private ushort TruAnswers = 0;
        private ushort Trying { get; set; }
        public List<Question> Listquestions
        {
            get { return listquestions; }

            set { listquestions = value; }
        }

        public ResultsWindow ResDLG
        {
            get
            {
                return resDLG;
            }

            set
            {
                resDLG = value;
            }
        }

        public BindingList<Result> Listresults = new BindingList<Result>();
      
        public MainForm()
        {
            
            InitializeComponent();
            Trying = 1;
            resDLG = new ResultsWindow(Listresults);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void загрузитьФаилВопросовToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Фаилы XML (*.xml)|*.xml";
            if (dlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            FileName = dlg.FileName;
            XmlTextReader reader = null;
            try
            {
                reader = new XmlTextReader(FileName);
                reader.WhitespaceHandling = WhitespaceHandling.None;
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "Question")
                        {
                            Question question = new Question
                            {
                                question = reader.GetAttribute("question"),
                                tru = reader.GetAttribute("TruAnswer"),
                                a1 = reader.GetAttribute("Answer1"),
                                a2 = reader.GetAttribute("Answer2"),
                                alta = reader.GetAttribute("AltAnswer")
                            };
                            Listquestions.Add(question);

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка загрузки данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                button2.Enabled = true;
            }
            // labeltime.Text = $"Время: {time} сек";

           
        }

        private void Initials()
        {
            try
            {
                richTextBoxQ.Text = Listquestions[numq].question;
                MixAnswers();
                label2.Text = $" {numq + 1} из {Listquestions.Count} ";
                button3.Enabled = true;
                timer1.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Нет списка вопросов");
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Файли XML (*.xml)|*.xml";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.OverwritePrompt = true;
            FileName = null;
            saveFileDialog1.FileName = FileName ?? "QuestinsList";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            FileName = Path.GetFullPath(saveFileDialog1.FileName);
            XmlTextWriter writer = null;
            try
            {
                writer = new XmlTextWriter(FileName, Encoding.Unicode);
                writer.WriteStartDocument();

                writer.WriteStartElement("QuestionsList");
                foreach (Question question in Listquestions)
                {
                    writer.WriteStartElement("Question");
                    writer.WriteAttributeString("question", question.question);
                    writer.WriteAttributeString("TruAnswer", question.tru);
                    writer.WriteAttributeString("Answer1", question.a1);
                    writer.WriteAttributeString("Answer2", question.a2);
                    writer.WriteAttributeString("AltAnswer", question.alta);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();

                writer.WriteEndDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка сохранения дынных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        //private void тестToolStripMenuItem1_Click(object sender, EventArgs e)
        //{

        //    Listquestions.Add(new Question("Ты вася?", "Я это Я", "Да", "Нет"));
        //    richTextBoxQ.Text = Listquestions[0].question;
        //    richTextBoxA1.Text = Listquestions[0].tru;
        //    richTextBoxA2.Text = Listquestions[0].a1;
        //    richTextBoxA3.Text = Listquestions[0].a2;
        //}

        private void richTextBoxA2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxA3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxA1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Listquestions.Count == 0)
            {
                MessageBox.Show("Нет списка вопросов");
                return;
            }
            if (radioButton1.Checked || radioButton2.Checked 
                || radioButton3.Checked)
                   Doing();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            nameDLG.ShowDialog();
            if (DialogResult.OK == nameDLG.DialogResult)
            {
                labelName.Text = Data.username;
                Initials();
                button2.Enabled = false;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labeltime.BackColor = DefaultBackColor;
            labeltime.Text = $"Время: {time} сек";
            if (time <= 0)
            {
                timer1.Stop();
                numq++;
                time = valtime;
                Doing();              
                return;
            }
            time--;
            if (time < 8)
            {
                labeltime.BackColor = time%2 == 0 ? Color.Crimson : Color.Chartreuse;              
            }

                
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
          
        }

        public void MixAnswers()
        {
            int sw = mix.Next(0, 4);
            switch (sw)
            {
                case 1:
                    richTextBoxA1.Text = Listquestions[numq].tru;
                    richTextBoxA2.Text = Listquestions[numq].a1;
                    richTextBoxA3.Text = Listquestions[numq].a2;
                    break;
                case 2:
                    richTextBoxA2.Text = Listquestions[numq].tru;
                    richTextBoxA1.Text = Listquestions[numq].a1;
                    richTextBoxA3.Text = Listquestions[numq].a2;
                    break;
                case 3:
                    richTextBoxA3.Text = Listquestions[numq].tru;
                    richTextBoxA2.Text = Listquestions[numq].a1;
                    richTextBoxA1.Text = Listquestions[numq].a2;
                    break;
                case 0:
                    richTextBoxA2.Text = Listquestions[numq].tru;
                    richTextBoxA3.Text = Listquestions[numq].a1;
                    richTextBoxA1.Text = Listquestions[numq].a2;
                    break;
            }
        }

        public bool CheckTru(string tru)
        {
            if (radioButton1.Checked)
            {              
                return richTextBoxA1.Text == tru;
            }
            else if (radioButton2.Checked)
            {
                return richTextBoxA2.Text == tru;
            }
            else if (radioButton3.Checked)
            {               
                return richTextBoxA3.Text == tru;
            }
            return false;
        }

        private void Doing()
        {
            
            timer1.Start();
            try
            {
                if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
                {
                    if (CheckTru(Listquestions[numq].tru))
                    {
                        ++TruAnswers;
                        answeredQ += $"{numq+1}, ";
                    }
                        
                    time = valtime;
                    numq++;
                }
                if (numq >= Listquestions.Count)
                {
                    timer1.Stop();
                    labeltime.BackColor = DefaultBackColor;
                    labeltime.Text = $"Время: {time} сек";                    
                    MessageBox.Show($"Вопросы закончились.\nРезультат: {TruAnswers} из {Listquestions.Count}\nПопыток: {Trying}",
                        $"Результат: {TruAnswers} из {Listquestions.Count}  Попыток: {Trying}",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button2.Enabled = true;
                    Listresults.Add(new Result(Data.username, TruAnswers, Trying, DateTime.Now.ToString(),answeredQ));
                    richTextBoxQ.Clear();
                    richTextBoxA1.Clear();
                    label2.Text = "";
                    richTextBoxA2.Clear();
                    richTextBoxA3.Clear();
                    button3.Enabled = false;
                    return;
                }
                label2.Text = $" {numq + 1} из {Listquestions.Count} ";
                richTextBoxQ.Text = Listquestions[numq].question;
                MixAnswers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Печалька " + ex, "Походу вопросы кончились", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                radioButton3.Enabled = true;
            }
        }

        private void свойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var res = new AddQuestions(Listquestions).ShowDialog();
            if (DialogResult.Cancel == res)
                return;
            button3.Enabled = true;
        }

        private void button1Start_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Начать сначала?", "Хотите сделать новую попытку?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (DialogResult.No == res)
                return;         
            TruAnswers = 0;
            numq = 0;
            button2.Enabled = true;
            Initials();
            Trying++;
            if (Listquestions.Count > 0)
                button3.Enabled = true;
        }

        private void очиститьПамятьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Listquestions.Clear();
                richTextBoxQ.Clear();
                richTextBoxA1.Clear();
                label2.Text = "";
                richTextBoxA2.Clear();
                richTextBoxA3.Clear();
                button3.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
         
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
        
        }

        private void результатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResDLG.ShowDialog();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var d = MessageBox.Show("Выйти?","Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == d )
                    Application.Exit();
        }
    }
}