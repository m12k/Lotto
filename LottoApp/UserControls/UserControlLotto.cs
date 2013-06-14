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
    public partial class UserControlLotto : UserControl
    {
        
        public EventHandler OnCloseControl;
        
        public UserControlLotto()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            OnCloseControl(sender,e);
        }
    }
}
