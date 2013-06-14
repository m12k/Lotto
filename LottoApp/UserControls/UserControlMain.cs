using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lotto.UserControls
{
    public partial class UserControlMain : UserControl
    {
        public delegate void EventOnClosed(string ModuleName);
        public EventOnClosed OnClosed;
         
        private UserControl _uc;
        public UserControl ucModule
        {
            set {
                _uc = value;
                panelControl.Controls.Add(_uc);
                _uc.Dock = DockStyle.Fill;
                AddCloseEventHandler(_uc);} 
        }

        public UserControlMain()
        {
            InitializeComponent();
        }

        private void AddCloseEventHandler(UserControl uc)
        {
            try
            { 
                switch (uc.Tag.ToString())
                { 
                    case "Lotto": (uc as UserControlLotto).OnCloseControl += new EventHandler(OnCloseControl);
                        break;
                    case "About": (uc as UserControlAbout).OnCloseControl += new EventHandler(OnCloseControl);
                        break;
                    case "Combination Generator": (uc as UserControlCombinationGenerator).OnCloseControl += new EventHandler(OnCloseControl);
                        break;
                    case "Manage Result": (uc as UserControlResult).OnCloseControl += new EventHandler(OnCloseControl);
                        break; 
                }
            }
            catch (Exception)
            { 
                throw;
            }
        }

        private void OnCloseControl(object sender, EventArgs e)
        {
            try
            {
                OnClosed(_uc.Tag.ToString());
            }
            catch (Exception)
            { 
                throw;
            }
           
        }
    }
}
