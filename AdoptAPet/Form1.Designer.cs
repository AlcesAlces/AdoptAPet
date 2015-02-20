namespace AdoptAPet
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBreedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adoptAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStripMain.Size = new System.Drawing.Size(1422, 44);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAnimalToolStripMenuItem,
            this.removeAnimalToolStripMenuItem,
            this.addBreedToolStripMenuItem,
            this.adoptAnimalToolStripMenuItem,
            this.addUserToolStripMenuItem,
            this.removeUserToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(67, 36);
            this.testToolStripMenuItem.Text = "Edit";
            // 
            // addAnimalToolStripMenuItem
            // 
            this.addAnimalToolStripMenuItem.Name = "addAnimalToolStripMenuItem";
            this.addAnimalToolStripMenuItem.Size = new System.Drawing.Size(258, 36);
            this.addAnimalToolStripMenuItem.Text = "Add Animal";
            this.addAnimalToolStripMenuItem.Visible = false;
            this.addAnimalToolStripMenuItem.Click += new System.EventHandler(this.addAnimalToolStripMenuItem_Click);
            // 
            // removeAnimalToolStripMenuItem
            // 
            this.removeAnimalToolStripMenuItem.Name = "removeAnimalToolStripMenuItem";
            this.removeAnimalToolStripMenuItem.Size = new System.Drawing.Size(258, 36);
            this.removeAnimalToolStripMenuItem.Text = "Remove Animal";
            this.removeAnimalToolStripMenuItem.Visible = false;
            this.removeAnimalToolStripMenuItem.Click += new System.EventHandler(this.removeAnimalToolStripMenuItem_Click);
            // 
            // addBreedToolStripMenuItem
            // 
            this.addBreedToolStripMenuItem.Name = "addBreedToolStripMenuItem";
            this.addBreedToolStripMenuItem.Size = new System.Drawing.Size(258, 36);
            this.addBreedToolStripMenuItem.Text = "Add Breed";
            this.addBreedToolStripMenuItem.Click += new System.EventHandler(this.addBreedToolStripMenuItem_Click);
            // 
            // adoptAnimalToolStripMenuItem
            // 
            this.adoptAnimalToolStripMenuItem.Name = "adoptAnimalToolStripMenuItem";
            this.adoptAnimalToolStripMenuItem.Size = new System.Drawing.Size(258, 36);
            this.adoptAnimalToolStripMenuItem.Text = "Adopt Animal";
            this.adoptAnimalToolStripMenuItem.Click += new System.EventHandler(this.adoptAnimalToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(258, 36);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Visible = false;
            // 
            // removeUserToolStripMenuItem
            // 
            this.removeUserToolStripMenuItem.Name = "removeUserToolStripMenuItem";
            this.removeUserToolStripMenuItem.Size = new System.Drawing.Size(258, 36);
            this.removeUserToolStripMenuItem.Text = "Remove User";
            this.removeUserToolStripMenuItem.Visible = false;
            this.removeUserToolStripMenuItem.Click += new System.EventHandler(this.removeUserToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.registerToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(74, 36);
            this.userToolStripMenuItem.Text = "User";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(176, 36);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Visible = false;
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(176, 36);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Visible = false;
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(176, 36);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Visible = false;
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(0, 52);
            this.panelMain.Margin = new System.Windows.Forms.Padding(6);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1422, 1008);
            this.panelMain.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 1062);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem addAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adoptAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBreedToolStripMenuItem;

    }
}

