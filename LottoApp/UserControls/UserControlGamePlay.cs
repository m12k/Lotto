using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto.UserControls
{
    public partial class UserControlGamePlay : UserControl
    {
        public UserControlGamePlay()
        {
            InitializeComponent();
        }

        #region "Declaration"

        private Classes.Combination transaction;

        private DataTable dtResult;
        private DataTable dtGenerated;
        private BindingSource bsSearchResult = new BindingSource();
        private BindingSource bsGenerateCombination = new BindingSource();
        private Classes.GamePlay gamePlay;
        Dictionary<int, int> combination = new Dictionary<int, int>();

        #endregion

        #region "Properties"

        private ClassGlobal.Game _Game = ClassGlobal.Game.Six42;
        public ClassGlobal.Game Game { get { return _Game; } set { _Game = value; } }
         
        #endregion

        #region "Event Handlers"

        private void UserControlGamePlay_Load(object sender, EventArgs e)
        {
            try
            {
                if (DesignMode.Equals(false)) 
                    gamePlay = new Classes.GamePlay();
                 
                Initialize();
                labelTopNumbers.Text = ""; 
                comboBoxTop.SelectedIndex = 0;
                buttonGenerateCombination.Enabled = false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void buttonGetTopNumbers_Click(object sender, EventArgs e)
        {
            try
            { 

                IEnumerable<Context.GetTopNumberResult> result = gamePlay.GetTopNumber(int.Parse(comboBoxTop.Text), dateTimePickerFromDate.Value, _Game);

                StringBuilder sb = new StringBuilder();

                int i =1;

                combination.Clear();
                foreach (Context.GetTopNumberResult value in result)
                {
                    combination.Add(i, value.number);
                    sb.Append(value.number).Append("-");
                    i++;
                }

                if (sb.Length > 0)
                {
                    labelTopNumbers.Text = sb.ToString().Substring(0, sb.Length - 1);
                    buttonGenerateCombination.Enabled = true;

                    //result.Select(detail => 
                    //{ 
                    //    DataRow row = dtNumber.NewRow();
                    //    row["number"] = detail.number;
                    //    return row;
                    //}).CopyToDataTable(dtNumber, LoadOption.PreserveChanges);
                    
                }
                else
                {
                    buttonGenerateCombination.Enabled = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {  
                IEnumerable<Context.GetGameResultResult> var = transaction.GetGameResult(dateTimePickerStartDate.Value, dateTimePickerEndDate.Value, _Game);
                bsSearchResult.DataSource = var.ToList(); 
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void buttonGenerateCombination_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtCombination = new DataTable();

                dtCombination.Columns.Add("one");
                dtCombination.Columns.Add("two");
                dtCombination.Columns.Add("three");
                dtCombination.Columns.Add("four");
                dtCombination.Columns.Add("five");
                dtCombination.Columns.Add("six");


                int one;
                int two;
                int three;
                int four;
                int five;
                int six = combination.Count;
            
                while (six > 0)
                {
                    five = six - 1;
                    while (five > 0)
                    {
                        four = five - 1;
                        while (four > 0)
                        {
                            three = four - 1;
                            while (three > 0)
                            {
                                two = three - 1;
                                while (two > 0)
                                {
                                    one = two - 1;
                                    while (one > 0)
                                    {
                                        //dtCombination.Rows.Add(combination[one], combination[two], combination[three], combination[four], combination[five], combination[six]);
                                        dtGenerated.Rows.Add(combination[one], combination[two], combination[three], combination[four], combination[five], combination[six]);
                                        one--;
                                    }
                                    two--;
                                }
                                three--;
                            }
                            four--;
                        }
                        five--;
                    }
                    six--;
                }

                bsGenerateCombination.DataSource = dtGenerated;


            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region "Methods"

        private void Initialize()
        {
            try
            { 
                if (DesignMode.Equals(false))
                    transaction = new Classes.Combination();

                dtResult = new DataTable("Results");
                dtResult.Columns.Add("id", typeof(long));
                dtResult.Columns.Add("one");
                dtResult.Columns.Add("two");
                dtResult.Columns.Add("three");
                dtResult.Columns.Add("four");
                dtResult.Columns.Add("five");
                dtResult.Columns.Add("six");
                dtResult.Columns.Add("jackpot");
                dtResult.Columns.Add("draw_date", typeof(DateTime));

                bsSearchResult.DataSource = dtResult;
                bindingNavigatorSearchResult.BindingSource = bsSearchResult;
                dataGridViewResult.DataSource = bsSearchResult; 
                 
                dtGenerated = new DataTable("Results");
                dtGenerated.Columns.Add("one");
                dtGenerated.Columns.Add("two");
                dtGenerated.Columns.Add("three");
                dtGenerated.Columns.Add("four");
                dtGenerated.Columns.Add("five");
                dtGenerated.Columns.Add("six");
                dtGenerated.Columns.Add("eliminate", typeof(Boolean));
                 
                bsGenerateCombination.DataSource = dtResult;
                bindingNavigatorGenerateCombination.BindingSource = bsGenerateCombination;
                dataGridViewGeneratedCombination.DataSource = bsGenerateCombination;
                
                InitializeGridLayout();
            }
            catch (Exception)
            {
                throw;
            }
        }
         
        private void InitializeGridLayout()
        {
            try
            {
                foreach (DataGridViewColumn col in dataGridViewResult.Columns)
                { 
                    if (col.Name.Equals("one"))
                    {
                        col.HeaderText = "One"; 
                    }
                    else if (col.Name.Equals("two"))
                    {
                        col.HeaderText = "Two"; 
                    }
                    else if (col.Name.Equals("three"))
                    {
                        col.HeaderText = "Three"; 
                    }
                    else if (col.Name.Equals("four"))
                    {
                        col.HeaderText = "Four"; 
                    }
                    else if (col.Name.Equals("five"))
                    {
                        col.HeaderText = "Five"; 
                    }
                    else if (col.Name.Equals("six"))
                    {
                        col.HeaderText = "Six"; 
                    }
                    else if (col.Name.Equals("jackpot"))
                    {
                        col.HeaderText = "Jackpot"; 
                        
                    }
                    else if (col.Name.Equals("draw_date"))
                    {
                        col.HeaderText = "Draw Date";
                    }
                    else
                    {
                        col.Visible = false;
                    }
                }

                foreach (DataGridViewColumn col in dataGridViewGeneratedCombination.Columns)
                {
                    if (col.Name.Equals("one"))
                    {
                        col.HeaderText = "One";
                        col.ReadOnly = true;
                    }
                    else if (col.Name.Equals("two"))
                    {
                        col.HeaderText = "Two";
                        col.ReadOnly = true;
                    }
                    else if (col.Name.Equals("three"))
                    {
                        col.HeaderText = "Three";
                        col.ReadOnly = true;
                    }
                    else if (col.Name.Equals("four"))
                    {
                        col.HeaderText = "Four";
                        col.ReadOnly = true;
                    }
                    else if (col.Name.Equals("five"))
                    {
                        col.HeaderText = "Five";
                        col.ReadOnly = true;
                    }
                    else if (col.Name.Equals("six"))
                    {
                        col.HeaderText = "Six";
                        col.ReadOnly = true;
                    }
                    else if (col.Name.Equals("eliminate"))
                    {
                        col.HeaderText = "Eliminate";
                    }

                    else
                    {
                        col.Visible = false;
                    }
                }
                //dataGridViewGeneratedCombination.Columns["eliminate"].SortMode = DataGridViewColumnSortMode.Automatic;

                
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        
        
    }
}
 