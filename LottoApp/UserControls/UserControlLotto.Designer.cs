namespace Lotto.UserControls
{
    partial class UserControlLotto
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage649 = new System.Windows.Forms.TabPage();
            this.userControlGamePlaySix49 = new Lotto.UserControls.UserControlGamePlay();
            this.tabPage645 = new System.Windows.Forms.TabPage();
            this.userControlGamePlaySix45 = new Lotto.UserControls.UserControlGamePlay();
            this.tabPage642 = new System.Windows.Forms.TabPage();
            this.userControlGamePlaySix42 = new Lotto.UserControls.UserControlGamePlay();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userControlGamePlaySix55 = new Lotto.UserControls.UserControlGamePlay();
            this.panel1.SuspendLayout();
            this.tabPage649.SuspendLayout();
            this.tabPage645.SuspendLayout();
            this.tabPage642.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(967, 11);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 44);
            this.panel1.TabIndex = 2;
            // 
            // tabPage649
            // 
            this.tabPage649.Controls.Add(this.userControlGamePlaySix49);
            this.tabPage649.Location = new System.Drawing.Point(4, 22);
            this.tabPage649.Name = "tabPage649";
            this.tabPage649.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage649.Size = new System.Drawing.Size(1047, 392);
            this.tabPage649.TabIndex = 2;
            this.tabPage649.Text = "6/49";
            this.tabPage649.UseVisualStyleBackColor = true;
            // 
            // userControlGamePlaySix49
            // 
            this.userControlGamePlaySix49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlGamePlaySix49.Game = ClassGlobal.Game.Six49;
            this.userControlGamePlaySix49.Location = new System.Drawing.Point(3, 3);
            this.userControlGamePlaySix49.Name = "userControlGamePlaySix49";
            this.userControlGamePlaySix49.Size = new System.Drawing.Size(1041, 386);
            this.userControlGamePlaySix49.TabIndex = 0;
            // 
            // tabPage645
            // 
            this.tabPage645.Controls.Add(this.userControlGamePlaySix45);
            this.tabPage645.Location = new System.Drawing.Point(4, 22);
            this.tabPage645.Name = "tabPage645";
            this.tabPage645.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage645.Size = new System.Drawing.Size(1047, 392);
            this.tabPage645.TabIndex = 1;
            this.tabPage645.Text = "6/45";
            this.tabPage645.UseVisualStyleBackColor = true;
            // 
            // userControlGamePlaySix45
            // 
            this.userControlGamePlaySix45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlGamePlaySix45.Game = ClassGlobal.Game.Six45;
            this.userControlGamePlaySix45.Location = new System.Drawing.Point(3, 3);
            this.userControlGamePlaySix45.Name = "userControlGamePlaySix45";
            this.userControlGamePlaySix45.Size = new System.Drawing.Size(1041, 386);
            this.userControlGamePlaySix45.TabIndex = 0;
            // 
            // tabPage642
            // 
            this.tabPage642.Controls.Add(this.userControlGamePlaySix42);
            this.tabPage642.Location = new System.Drawing.Point(4, 22);
            this.tabPage642.Name = "tabPage642";
            this.tabPage642.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage642.Size = new System.Drawing.Size(1047, 392);
            this.tabPage642.TabIndex = 0;
            this.tabPage642.Text = "6/42";
            this.tabPage642.UseVisualStyleBackColor = true;
            // 
            // userControlGamePlaySix42
            // 
            this.userControlGamePlaySix42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlGamePlaySix42.Game = ClassGlobal.Game.Six42;
            this.userControlGamePlaySix42.Location = new System.Drawing.Point(3, 3);
            this.userControlGamePlaySix42.Name = "userControlGamePlaySix42";
            this.userControlGamePlaySix42.Size = new System.Drawing.Size(1041, 386);
            this.userControlGamePlaySix42.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage642);
            this.tabControl1.Controls.Add(this.tabPage645);
            this.tabControl1.Controls.Add(this.tabPage649);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1055, 418);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.userControlGamePlaySix55);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1047, 392);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "6/55";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // userControlGamePlaySix55
            // 
            this.userControlGamePlaySix55.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlGamePlaySix55.Game = ClassGlobal.Game.Six55;
            this.userControlGamePlaySix55.Location = new System.Drawing.Point(3, 3);
            this.userControlGamePlaySix55.Name = "userControlGamePlaySix55";
            this.userControlGamePlaySix55.Size = new System.Drawing.Size(1041, 386);
            this.userControlGamePlaySix55.TabIndex = 0;
            // 
            // UserControlLotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlLotto";
            this.Size = new System.Drawing.Size(1055, 462);
            this.Tag = "Lotto";
            this.panel1.ResumeLayout(false);
            this.tabPage649.ResumeLayout(false);
            this.tabPage645.ResumeLayout(false);
            this.tabPage642.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage649;
        private UserControlGamePlay userControlGamePlaySix49;
        private System.Windows.Forms.TabPage tabPage645;
        private UserControlGamePlay userControlGamePlaySix45;
        private System.Windows.Forms.TabPage tabPage642;
        private UserControlGamePlay userControlGamePlaySix42;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private UserControlGamePlay userControlGamePlaySix55;
    }
}
