using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lotto
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void lottoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControls.UserControlLotto(), lottoToolStripMenuItem1.Tag.ToString());
        }

        private void combinationGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControls.UserControlCombinationGenerator(), combinationGeneratorToolStripMenuItem.Tag.ToString());
        } 

        private void manageResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControls.UserControlResult(), manageResultToolStripMenuItem.Tag.ToString());
        } 

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            LoadUserControl(new UserControls.UserControlAbout(), aboutToolStripMenuItem.Tag.ToString());
        }
         
        private void LoadUserControl(UserControl uc, string modulePath)
        {
            try
            {
                TabPage tp = new TabPage();
                tp.Text = uc.Tag.ToString();
                UserControls.UserControlMain userControlMain = new UserControls.UserControlMain();
                
                //Check if Module already exists.
                foreach (TabPage t in tabControlMain.TabPages)
                {
                    if (t.Text == uc.Tag.ToString())
                    {
                        tabControlMain.SelectedTab = t;
                        return;
                    } 
                }

                userControlMain.ucModule = uc;
                userControlMain.labelModulePath.Text = modulePath;
                userControlMain.OnClosed += new UserControls.UserControlMain.EventOnClosed(CloseModuleControl);
                tp.Controls.Add(userControlMain);
                userControlMain.Dock = DockStyle.Fill;
                tabControlMain.TabPages.Add(tp);
                tabControlMain.SelectedTab = tp;
                
            }
            catch (Exception)
            { 
                throw;
            } 
        }

        private void CloseModuleControl(string moduleName)
        {
        try 
	    {	         
		    foreach(TabPage t in tabControlMain.TabPages)
            {
                if (t.Text == moduleName)
                {
                    tabControlMain.TabPages.Remove(t);
                    break;
                } 
            }
	    }
	    catch (Exception)
	    { 
		    throw;
	    }
        }
         
        private void importResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (Lotto.Forms.FormImportResult frm = new Forms.FormImportResult())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
