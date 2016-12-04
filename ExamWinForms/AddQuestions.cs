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

        //public AddQuestions()
        //{
        //}

        bool iftyping()
        {
            if (string.IsNullOrWhiteSpace(richTextBoxAddQuestions.Text)|| string.IsNullOrWhiteSpace(richTexAddTruAnsw.Text)
                || string.IsNullOrWhiteSpace(richTextBoxAddAnsw1.Text)|| string.IsNullOrWhiteSpace(richTextBoxAddAnsw2.Text))
            {
                //richTextBoxAddQuestions.BackColor = Color.Chocolate;
                MessageBox.Show("Заполните все поля", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
            return true;
        }
        private void btAddQ_Click(object sender, EventArgs e)
        {
            if (iftyping())
            {
                 list.Add(new Question(richTextBoxAddQuestions.Text,richTexAddTruAnsw.Text,
                richTextBoxAddAnsw1.Text,richTextBoxAddAnsw2.Text));
            }         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Clear();
            list.Add(new Question("Американский Танк Т-32 имеет классификацию?", "Тяжёлого танка", "Среднего танка", "Лёгкого танка"));
            list.Add(new Question("На противотанковую самоходную артиллерийскую установку ИСУ-152, устанавливались орудия...", " 152 мм ", "152 мм и 155 мм ", "152 мм, 100 мм "));
            list.Add(new Question("Какой танк считается символом Второй Мировой войны?", "Т-34 и его модификация Т-34-85", "Немецкий Тигр", "Американский М4 \"Шерман\""));
            list.Add(new Question("Советский тяжелый танк раннего периода войны ,существовал до  и после появления Т-34", "КВ-1", "ИС", "Т-28"));
            list.Add(new Question("Немецкий тяжелый танк, впервые сошел с конвеера фирмы «Хеншель» 1942 года", "PzKpfw VI Ausf. H1 «Tiger»", "КВ-1", "PzKpfw V «Panther»"));
            list.Add(new Question("«Ягдпантера» (Jagdpanther) это ?", " Тяжёлая по массе немецкая самоходно-артиллерийская установка (САУ) класса истребителей танков времён Второй мировой войны.", "Немецкий средний танк периода Второй мировой войны. ", "Советский средний танк периода Второй мировой войны"));
            list.Add(new Question("M4 «Шерман» (M4 Sherman) — основной [ выбрать пропущеное ] средний танк периода Второй мировой войны. ", "американский", "немецкий", "советский"));
            list.Add(new Question("«Фердина́нд» (Ferdinand) — это ? ", "Немецкая тяжёлая самоходно-артиллерийская установка периода Второй мировой войны класса истребителей танков.", "Советская тяжёлая самоходно-артиллерийская установка периода Второй мировой войны класса истребителей танков.", "Американская тяжёлая самоходно-артиллерийская установка периода Второй мировой войны класса истребителей танков."));
            list.Add(new Question("Отличительная особенность «Фердина́нд» (Ferdinand) ", "Гибридная (электродвигатели + бензогенераторы) установка", "4 пары гусениц", "Два основных орудия"));
            list.Add(new Question("ИС-1 это ?", "Советский тяжёлый танк периода Второй мировой войны. ", "Немецкий тяжёлый танк периода Второй мировой войны. ", "Советский легкий танк периода Второй мировой войны. "));
            list.Add(new Question("Аббревиатура танков серии ИС означает", "«Иосиф Сталин» ", "«Иосиф Кабзон» ", "Ничего не означает"));
            list.Add(new Question("ИС-3 (Объект 703) — советский тяжёлый танк разработки периода Великой Отечественной войны участвовал в боях ", "Не участвовал в Великой Отечественной", "Участвовал начиная с битвы под Сталинградом", "Штурмовал Берлин"));
            list.Add(new Question("ИС-3 (Объект 703) имеет особенност(и)ь ", "Щучий нос и гладкую каплевидную башню", "Щучий нос", "Гладкую каплевидную башню"));
            list.Add(new Question("«Ягдтигр» (Jagdtiger) это ?", "Германская самоходная артиллерийская установка (САУ) периода Второй мировой войны, класса истребителей танков.", "Японская самоходная артиллерийская установка (САУ) периода Второй мировой войны, класса истребителей танков.", "Американская самоходная артиллерийская установка (САУ) периода Второй мировой войны, класса истребителей танков."));
            list.Add(new Question("M46 (танк) Имел также название «Генерал Паттон» (англ. General Patton) в честь Джорджа Паттона", "Американский средний танк второй половины 1940-х годов. ", " Средний танк Японии второй половины 1940-х годов. ", " Средний танк Великобритании второй половины 1940-х годов. "));
            list.Add(new Question("Первый советский танк ", "МС-1", "Т-28", "Т-26"));
            list.Add(new Question("M3/M5 «Стюарт»", "Легкий танк США", "Средний танк США", "Легкий танк СССР"));
            list.Add(new Question("Т-50 советский танк по класификации", "Легкий", "Средний", "Тяжелый"));
            this.Close();
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
