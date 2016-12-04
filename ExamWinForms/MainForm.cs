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
        public string FileName;
        public int numq = 0;
        const byte valtime = 20;
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
        public BindingList<Result> Listresults = new BindingList<Result>();
        bool truchecker { get; set; }

        public MainForm()
        {
            
            InitializeComponent();
            Trying = 1;
            
        }

        private void Form1_Load(object sender, EventArgs e)
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
                Listquestions.Clear();
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
        }

        private void Initials()
        {
            try
            {
                if (Listquestions.Count <= 0)
                {
                    MessageBox.Show(Data.username+", загрузите вопросы");
                    btRestart.Enabled = false;
                    return;
                }
                truchecker = EnabledAnsw(true);
                numq = 0;
                TruAnswers = 0;
                richTextBoxQ.Text = Listquestions[numq].question;
                MixAnswers();
                label2.Text = $" {numq + 1} из {Listquestions.Count} ";
                button3.Enabled = true;
                timer1.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Нет списка вопросов\n"+ex);
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
            saveFileDialog1.FileName = FileName ?? "QuestinsList"+DateTime.Today;
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
               
                btRestart.Enabled = true;    
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

        private void radioButton1_Click(object sender, EventArgs e)
        {
            richTextBoxA1_MouseClick(null, null);
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
            if (radioButton2.Checked)
            {
                return richTextBoxA2.Text == tru;
            }
            if (radioButton3.Checked)
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
                    richTextBoxA1.BackColor = Color.Azure;
                    richTextBoxA2.BackColor = Color.Azure;
                    richTextBoxA3.BackColor = Color.Azure;
                    EnabledAnsw(true);                                                   
                
                }
                if (numq == Listquestions.Count)
                {
                    timer1.Stop();
                    labeltime.BackColor = DefaultBackColor;
                    labeltime.Text = $"Время: {time} сек";                    
                    MessageBox.Show($"Вопросы закончились.\nРезультат: {TruAnswers} из {Listquestions.Count}\nПопыток: {Trying}",
                        $"Результат: {TruAnswers} из {Listquestions.Count}  Попыток: {Trying}",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EnabledAnsw(false);
                    try
                    {
                        Listresults.Add(new Result(Data.username, TruAnswers, Trying, DateTime.Now.ToString(), answeredQ,(ushort)Listquestions.Count));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Результат не добавился(((\n"+ex.Message, "пипец");
                    }
                   
                    btRestart.Enabled = false;
                    answeredQ = "";
                    numq = 0;                      
                    button2.Enabled = true;
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

        bool EnabledAnsw(bool ch)
        {
            if (ch)
            {
                richTextBoxA1.Enabled = true;
                richTextBoxA2.Enabled = true;
                richTextBoxA3.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                return true;
            }
            richTextBoxA1.Enabled = false;
            richTextBoxA2.Enabled = false;
            richTextBoxA3.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            return false;
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var res = MessageBox.Show("Начать сначала?", "Хотите сделать новую попытку?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (DialogResult.No == res)
            {
                timer1.Start();
                return;
            }                
            time = valtime;
            labeltime.Text = $"Время: {time} сек";
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
                truchecker = EnabledAnsw(false);
                Listquestions.Clear();
                richTextBoxQ.Clear();
                richTextBoxA1.Clear();
                label2.Text = "";
                richTextBoxA2.Clear();
                richTextBoxA3.Clear();
                button3.Enabled = false;
                timer1.Stop();
                time = valtime;
                labeltime.BackColor = DefaultBackColor;
                labeltime.Text = $"Время: {time} сек";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void результатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resDLG = new ResultsWindow(Listresults);
            resDLG.ShowDialog();          
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

        private void добавитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddQuestions(Listquestions).Show();           
            button3.Enabled = true;
        }

        private void richTextBoxA1_MouseClick(object sender, MouseEventArgs e)
        {
            radioButton1.Checked = true;
            if (radioButton1.Checked && truchecker)
            {
                richTextBoxA1.BackColor =  Color.Chartreuse;
                richTextBoxA2.BackColor = Color.Azure;
                richTextBoxA3.BackColor = Color.Azure;
            }
            
        }

        private void richTextBoxA2_MouseClick(object sender, MouseEventArgs e)
        {
           
            radioButton2.Checked = true;
            if (radioButton2.Checked && truchecker)
                richTextBoxA2.BackColor = Color.Chartreuse;
            richTextBoxA1.BackColor = Color.Azure;
            richTextBoxA3.BackColor = Color.Azure;
        }

        private void richTextBoxA3_MouseClick(object sender, MouseEventArgs e)
        {
            radioButton3.Checked = true;
            if (radioButton3.Checked && truchecker)
                richTextBoxA3.BackColor = Color.Chartreuse;
            richTextBoxA1.BackColor = Color.Azure;
            richTextBoxA2.BackColor = Color.Azure;
        }

        private void richTextBoxA1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_Click_1(object sender, EventArgs e)
        {
            richTextBoxA2_MouseClick(null, null);
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            richTextBoxA3_MouseClick(null, null);
        }
    }
}