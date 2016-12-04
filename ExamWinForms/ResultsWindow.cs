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
    public partial class ResultsWindow : Form
    {
       private BindingList<Result> lresults;
        private string FileName = null;
        public ResultsWindow(BindingList<Result> listresults)
        {
           lresults = listresults;
           InitializeComponent();
           dataGridViewResults.DataSource = lresults;
        }
        private void resultBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void очиститьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            lresults.Clear();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Файли XML (*.xml)|*.xml";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.OverwritePrompt = true;            
            saveFileDialog1.FileName = FileName ?? "ResultsList";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            FileName = Path.GetFullPath(saveFileDialog1.FileName);
            XmlTextWriter writer = null;
            try
            {
                writer = new XmlTextWriter(FileName, Encoding.Unicode);
                writer.WriteStartDocument();

                writer.WriteStartElement("ResultsList");
                foreach (Result res in lresults)
                {
                    writer.WriteStartElement("Result");
                    writer.WriteAttributeString("Name", res.username);
                    writer.WriteAttributeString("Result", res.result.ToString());
                    writer.WriteAttributeString("Trying", res.trying.ToString());
                    writer.WriteAttributeString("Tru", res.answeredQ);
                    writer.WriteAttributeString("Date", res.date);
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
                        if (reader.Name == "Result")
                        {
                            Result res  = new Result();
                            {
                                res.username = reader.GetAttribute("Name");
                                res.result = Convert.ToUInt16(reader.GetAttribute("Result"));
                                res.trying = Convert.ToUInt16(reader.GetAttribute("Trying"));
                                res.answeredQ = reader.GetAttribute("Tru");
                                res.date = reader.GetAttribute("Date");
                            }
                            
                            lresults.Add(res);

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
            }
        }
    }
}
