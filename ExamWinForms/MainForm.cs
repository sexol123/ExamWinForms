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
       
        string answeredQ { get; set; }
        private FormUsername nameDLG = new FormUsername();
        private ResultsWindow resDLG;
        static byte time = Data.valtime;
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
            labeltime.Text = $"Время: {Data.valtime} сек";

        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Файлы QestXML (*.QestXML)|*.QestXML|Файли XML (*.xml)|*.xml";
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
                        if (reader.Name == "QuestionsList")
                        {
                            Data.test_name = reader.GetAttribute("Testname");
                        }
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
                MessageBox.Show($"Тест успешно добавлен\nВопросов в списке: {Listquestions.Count} ", "Тест загружен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button2.Enabled = true;
                menustriptimer.Enabled =  true;
                Trying = 1;
                progressBar1.Value = numq + 1;

                label_test_name.Text = Data.test_name;
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
                progressBar1.Minimum = 0;
                progressBar1.Maximum = Listquestions.Count;
               // progressBar1.Value = numq;
                time = Data.valtime;
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
            saveFileDialog1.Filter = "Файлы QestXML (*.QestXML)|*.QestXML|Файли XML (*.xml)|*.xml";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = "QestXML";
            saveFileDialog1.OverwritePrompt = true;
            FileName = null;
            saveFileDialog1.FileName = FileName;
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            FileName = Path.GetFullPath(saveFileDialog1.FileName);
            XmlTextWriter writer = null;
            try
            {
                writer = new XmlTextWriter(FileName, Encoding.Unicode);
                writer.WriteStartDocument();
                writer.WriteStartElement("QuestionsList");
                writer.WriteAttributeString("Testname", Data.test_name);
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
            progressBar1.Value = numq+1;
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
                if (labelName.Text != Data.username)
                {
                    Trying = 1;
                    labelName.Text = Data.username; 
                }                         
                Initials();
                button2.Enabled = false;
                menustriptimer.Enabled = false;
                progressBar1.Value = numq + 1;

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
                time = Data.valtime;
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
                    time = Data.valtime;
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
                    menustriptimer.Enabled = true;
                    EnabledAnsw(false);
                    try
                    {
                        Listresults.Add(new Result(Data.username, TruAnswers, Trying, DateTime.Now.ToString(), answeredQ,(ushort)Listquestions.Count,Data.test_name));
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
            time = Data.valtime;
            labeltime.Text = $"Время: {time} сек";     
            TruAnswers = 0;
            numq = 0;
            button2.Enabled = false;
            Initials();
            Trying++;
            if (Listquestions.Count > 0)
                button3.Enabled = true;
            progressBar1.Value = numq + 1;

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
                time =Data.valtime;
                labeltime.BackColor = DefaultBackColor;
                labeltime.Text = $"Время: {time} сек";
                Data.test_name = "";
                label_test_name.Text = Data.test_name;
                menustriptimer.Enabled = true;
                Data.username = "";
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

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\"Тестировщик\"\nМалеев Сергей\n     2016 год", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void тестТанкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listquestions.Clear();
            Listquestions.Add(new Question("Американский Танк Т-32 имеет классификацию?", "Тяжёлого танка", "Среднего танка", "Лёгкого танка"));
            Listquestions.Add(new Question("На противотанковую самоходную артиллерийскую установку ИСУ-152, устанавливались орудия...", " 152 мм ", "152 мм и 155 мм ", "152 мм, 100 мм "));
            Listquestions.Add(new Question("Какой танк считается символом Второй Мировой войны?", "Т-34 и его модификация Т-34-85", "Немецкий Тигр", "Американский М4 \"Шерман\""));
            Listquestions.Add(new Question("Советский тяжелый танк раннего периода войны ,существовал до  и после появления Т-34", "КВ-1", "ИС", "Т-28"));
            Listquestions.Add(new Question("Немецкий тяжелый танк, впервые сошел с конвеера фирмы «Хеншель» 1942 года", "PzKpfw VI Ausf. H1 «Tiger»", "КВ-1", "PzKpfw V «Panther»"));
            Listquestions.Add(new Question("«Ягдпантера» (Jagdpanther) это ?", " Тяжёлая по массе немецкая самоходно-артиллерийская установка (САУ) класса истребителей танков времён Второй мировой войны.", "Немецкий средний танк периода Второй мировой войны. ", "Советский средний танк периода Второй мировой войны"));
            Listquestions.Add(new Question("M4 «Шерман» (M4 Sherman) — основной [ выбрать пропущеное ] средний танк периода Второй мировой войны. ", "американский", "немецкий", "советский"));
            Listquestions.Add(new Question("«Фердина́нд» (Ferdinand) — это ? ", "Немецкая тяжёлая самоходно-артиллерийская установка периода Второй мировой войны класса истребителей танков.", "Советская тяжёлая самоходно-артиллерийская установка периода Второй мировой войны класса истребителей танков.", "Американская тяжёлая самоходно-артиллерийская установка периода Второй мировой войны класса истребителей танков."));
            Listquestions.Add(new Question("Отличительная особенность «Фердина́нд» (Ferdinand) ", "Гибридная (электродвигатели + бензогенераторы) установка", "4 пары гусениц", "Два основных орудия"));
            Listquestions.Add(new Question("ИС-1 это ?", "Советский тяжёлый танк периода Второй мировой войны. ", "Немецкий тяжёлый танк периода Второй мировой войны. ", "Советский легкий танк периода Второй мировой войны. "));
            Listquestions.Add(new Question("Аббревиатура танков серии ИС означает", "«Иосиф Сталин» ", "«Иосиф Кабзон» ", "Ничего не означает"));
            Listquestions.Add(new Question("ИС-3 (Объект 703) — советский тяжёлый танк разработки периода Великой Отечественной войны участвовал в боях ", "Не участвовал в Великой Отечественной", "Участвовал начиная с битвы под Сталинградом", "Штурмовал Берлин"));
            Listquestions.Add(new Question("ИС-3 (Объект 703) имеет особенност(и)ь ", "Щучий нос и гладкую каплевидную башню", "Щучий нос", "Гладкую каплевидную башню"));
            Listquestions.Add(new Question("«Ягдтигр» (Jagdtiger) это ?", "Германская самоходная артиллерийская установка (САУ) периода Второй мировой войны, класса истребителей танков.", "Японская самоходная артиллерийская установка (САУ) периода Второй мировой войны, класса истребителей танков.", "Американская самоходная артиллерийская установка (САУ) периода Второй мировой войны, класса истребителей танков."));
            Listquestions.Add(new Question("M46 (танк) Имел также название «Генерал Паттон» (англ. General Patton) в честь Джорджа Паттона", "Американский средний танк второй половины 1940-х годов. ", " Средний танк Японии второй половины 1940-х годов. ", " Средний танк Великобритании второй половины 1940-х годов. "));
            Listquestions.Add(new Question("Первый советский танк ", "МС-1", "Т-28", "Т-26"));
            Listquestions.Add(new Question("M3/M5 «Стюарт»", "Легкий танк США", "Средний танк США", "Легкий танк СССР"));
            Listquestions.Add(new Question("Т-50 советский танк по класификации", "Легкий", "Средний", "Тяжелый"));
            Data.test_name = "Танки";
            label_test_name.Text = Data.test_name;
            Trying = 1;
            progressBar1.Value = numq + 1;
            button2.Enabled = true;
            MessageBox.Show($"Тест \"Танки\" успешно добавлен\nВопросов в списке: {Listquestions.Count} ", "Тест загружен", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void отладочныйТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listquestions.Clear();
            Listquestions.Add(new Question("Да?", "Да", "Нет", "Незнаю"));
            Listquestions.Add(new Question("Нет?", "Нет", "Да", "Незнаю"));
            Listquestions.Add(new Question("Незнаю?", "Незнаю", "Да", "Нет"));
            Data.test_name = "Отладочный";
            progressBar1.Value = numq + 1;
            label_test_name.Text = Data.test_name;
            Trying = 1;
            button2.Enabled = true;
            MessageBox.Show($"Отладочный тест успешно добавлен\nВопросов в списке: {Listquestions.Count} ", "Тест загружен", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void время20СекундToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.valtime = 20;
            labeltime.Text = $"Время: {Data.valtime} сек";
        }

        private void время30СекундToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.valtime = 30;
            labeltime.Text = $"Время: {Data.valtime} сек";
        }

        private void время40СекундToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.valtime = 40;
            labeltime.Text = $"Время: {Data.valtime} сек";
        }

        private void время60СекундToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.valtime = 60;
            labeltime.Text = $"Время: {Data.valtime} сек";
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void время10СекундToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.valtime = 10;
            labeltime.Text = $"Время: {Data.valtime} сек";
        }

        private void тестИдеотизмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listquestions.Clear();
            Listquestions.Add(new Question("В некоторых месяцах 30 дней, в некоторых 31. В скольки месяцах в году 28 дней?", " Во всех месяцах", "В Феврале", "Нет таких"));
            Listquestions.Add(new Question("Что можно видеть с закрытыми глазами?", "Сны", "Темноту", "Ничего"));
            Listquestions.Add(new Question("Что в огне не горит и в воде не тонет??", "Лед", "Бумага", "Нет такого"));
            Listquestions.Add(new Question("Из какой посуды нельзя ничего поесть?", "Из пустой", "Никакой", "Незнаю"));
            Listquestions.Add(new Question("На какой вопрос нельзя ответить «нет»?", "Ты жив?", "Ты мертв", "Незнаю"));
            Listquestions.Add(new Question("Сколько будет 2+2*2?", "Шесть", "Восемь", "12"));
            Data.test_name = "Быстрый";
            label_test_name.Text = Data.test_name;
            button2.Enabled = true;
            Trying = 1;

            progressBar1.Value = numq + 1;

            MessageBox.Show($"Быстрый тест успешно добавлен\nВопросов в списке: {Listquestions.Count} ", "Тест загружен", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (int)Keys.D1)
            //{
            //    radioButton1_Click(null, null);
            //}
            //else if(e.KeyChar == (int)Keys.D2)
            //{
            //    radioButton2_Click_1(null, null);
            //}
            //else if (e.KeyChar == (int)Keys.D3)
            //{
            //    radioButton3_Click(null, null);
            //}
        }

        private void button3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void MainForm_Layout(object sender, LayoutEventArgs e)
        {

        }

    }
}