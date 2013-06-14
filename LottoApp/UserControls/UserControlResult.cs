using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace Lotto.UserControls
{
    public partial class UserControlResult : UserControl 
    {
        public UserControlResult() 
        {
            InitializeComponent();
        }

        #region "Declaration"

        private Classes.Combination transaction;

        private DataTable dtResult;
        private DataTable dtGenerated;
        private BindingSource bsSearchResult = new BindingSource();
        private BindingSource bsGenerateCombination = new BindingSource();
        public EventHandler OnCloseControl;

        DataContext dc; 


        #endregion
  
        #region "Event Handlers"

        private void UserControlGamePlay_Load(object sender, EventArgs e)
        {
            try
            {
                Initialize();
                comboBoxGame.SelectedIndex = 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
            
        private void buttonClose_Click(object sender, EventArgs e)
        {
            OnCloseControl(sender, e);
        }

        private void comboBoxGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception)
            {
                throw;
            }
        }
       
        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxGame.Text.Equals("6/42"))
                { 
                    var result = from s in dc.GetTable<Context.Result_six_42>()
                             where s.Draw_date >= dateTimePickerStartDate.Value && s.Draw_date <= dateTimePickerEndDate.Value
                             select s;
                    bsSearchResult.DataSource = result;
                }
                else if (comboBoxGame.Text.Equals("6/45"))
                {
                    var result = from s in dc.GetTable<Context.Result_six_45>()
                                 where s.Draw_date >= dateTimePickerStartDate.Value && s.Draw_date <= dateTimePickerEndDate.Value
                                 select s;
                    bsSearchResult.DataSource = result;
                }
                else if (comboBoxGame.Text.Equals("6/49"))
                {
                    var result = from s in dc.GetTable<Context.Result_six_49>()
                                 where s.Draw_date >= dateTimePickerStartDate.Value && s.Draw_date <= dateTimePickerEndDate.Value
                                 select s;
                    bsSearchResult.DataSource = result;
                }
                else// 6/55
                {
                    var result = from s in dc.GetTable<Context.Result_six_55>()
                                 where s.Draw_date >= dateTimePickerStartDate.Value && s.Draw_date <= dateTimePickerEndDate.Value
                                 select s;
                    bsSearchResult.DataSource = result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
         
        private void UpdateChanges_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Updated!");
                dc.SubmitChanges();
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
                dc = new DataContext(System.Configuration.ConfigurationManager.ConnectionStrings["lottoConnectionString"].ToString());

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
                dtResult.Columns.Add("created_date", typeof(DateTime));
                dtResult.Columns.Add("timestamp");
                 
                bsSearchResult.DataSource = dtResult; 
                bindingNavigatorGenerateCombination.BindingSource = bsSearchResult;
                dataGridViewGeneratedCombination.DataSource = bsSearchResult;
                 
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
                foreach (DataGridViewColumn col in dataGridViewGeneratedCombination.Columns)
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
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
          
    }
}
 