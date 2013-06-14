using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto.Forms
{
    public partial class FormImportResult : Form
    {
        public FormImportResult()
        {
            InitializeComponent();
        }

        private Classes.Result result;
        private string[] rows;

        private void FormImportResult_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxGame.SelectedIndex = 0;
                result = new Classes.Result();
            }
            catch (Exception)
            {
                throw;
            } 
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = "Select File";
                    dlg.Filter = ".csv|*.csv";
                    if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        textBoxFileName.Text = dlg.FileName;
                        CountRows();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CountRows()
        {
            try
            { 
                rows = System.IO.File.ReadAllLines(textBoxFileName.Text);
                StringBuilder sb = new StringBuilder();
                sb.Append("Records Found: ").Append((rows.Count() -1).ToString());
                labelRowCount.Text = sb.ToString(); 
                progressBar.Maximum = rows.Count(); 
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            try
            {
                ClassGlobal.Game game; 

                if (comboBoxGame.Text.Equals("6/42"))
                    game = ClassGlobal.Game.Six42;
                else if(comboBoxGame.Text.Equals("6/45"))
                    game = ClassGlobal.Game.Six45;
                else if(comboBoxGame.Text.Equals("6/49"))
                    game = ClassGlobal.Game.Six49;
                else// 6/55
                    game = ClassGlobal.Game.Six55;

                int index = 0;

                foreach (string s in rows)
                {
                    if (index.Equals(0))
                    {
                        index++;
                        continue;
                    }
                    string[] splt = s.Split(',');

                    result.One =Convert.ToInt32(splt[0]);
                    result.Two = Convert.ToInt32(splt[1]);
                    result.Three = Convert.ToInt32(splt[2]);
                    result.Four = Convert.ToInt32(splt[3]);
                    result.Five = Convert.ToInt32(splt[4]);
                    result.Six = Convert.ToInt32(splt[5]);
                    result.DrawDate = Convert.ToDateTime(splt[6]);
                    result.Jackpot = Convert.ToDecimal(splt[7]);
                    result.Game = game;
                    result.SaveResult();
                    progressBar.Value++;
                }

                progressBar.Value = 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

       
    }
}
