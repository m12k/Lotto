using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Lotto.UserControls
{
    public partial class UserControlCombinationGenerator : UserControl
    {
        public UserControlCombinationGenerator()
        {
            InitializeComponent();
        }

        Lotto.Classes.Combination combination;
        Thread thCombination; 
        StringBuilder sbTimer;
        long counter;
        long idCounter;
        long LastCombinationId;
        DataTable dtData;
        public EventHandler OnCloseControl;
        private BindingSource bsCombination = new BindingSource();
         
        #region "EventHandlers"

        private void UserControlCombinationGenerator_Load(object sender, EventArgs e)
        {
            try
            {
                //idCounter = 1;
                combination = new Lotto.Classes.Combination();
                sbTimer = new StringBuilder();
                InitializeGrid();

                //LastCombinationId = (long)transaction.GetCombinationLastId();
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
         
        private void buttonLoadSave_Click(object sender, EventArgs e)
        {
            try
            { 
                //thClock = new Thread(new ThreadStart(ClockStart));
                //thClock.Start();
                 
                //thCombination = new Thread(new ThreadStart(LoadCombination));
                //thCombination.Start(); 
                LoadCombination();
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            try
            { 
                if (!thCombination.IsAlive) timer.Stop();
                sbTimer.Clear();
                counter++; 
                sbTimer.Append(counter / 3600).Append(":").Append((counter - ((counter / 3600) * 3600)) / 60).Append(":").Append(counter - (60 * ((int)counter / 60)));
                labelTime.Text = sbTimer.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
          
        #region "Methods"

        private void InitializeGrid()
        { 
            try 
            {
                dtData = new DataTable("Combination");
                
                dtData.Columns.Add("one");
                dtData.Columns.Add("two");
                dtData.Columns.Add("three");
                dtData.Columns.Add("four");
                dtData.Columns.Add("five");
                dtData.Columns.Add("six");
                 
                bsCombination.DataSource = dtData;
                bindingNavigatorData.BindingSource = bsCombination;
                dataGridViewData.DataSource = bsCombination; 
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
                foreach(DataGridViewColumn col in dataGridViewData.Columns) 
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
                }
            }
            catch (Exception)
            { 
                throw;
            }
        }

        private void LoadCombination()
        { 
            DAddCombination d = new DAddCombination(AddCombination);
                
            int one = 0;
            int two = 0 ;
            int three = 0;
            int four = 0;
            int five = 0;
            int six = 12;
              
            try
            { 
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
                                        Invoke(d, new object[] { one, two, three, four, five, six });
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
            }

            catch (Exception)
            {  
                throw;
            } 
        }

        private void ClockStart()
        {
            try
            {
                DTimer dTimer = new DTimer(StartClock);
                Invoke(dTimer);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private delegate void DAddCombination(int one, int two, int three, int four, int five, int six);
        private void AddCombination(int one, int two, int three, int four, int five, int six) 
        {
            try 
            {
                //dtData.Rows.Add(one, two, three, four, five, six);
                combination.One = one;
                combination.Two = two;
                combination.Three = three;
                combination.Four = four;
                combination.Five = five;
                combination.Six = six; 

                //if (idCounter > LastCombinationId)
                    combination.SaveCombination();  

                //idCounter++;
            }
            catch (Exception)
            { 
            throw;
            }
        }

        private delegate void DTimer();
        private void StartClock()
        {
            try 
            {
                timer.Start(); 
            }
            catch (Exception)
            { 
		    throw;
	        }
        }

        #endregion 
         
    }
}
