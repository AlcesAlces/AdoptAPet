namespace AdoptAPet
{
    partial class UserControlSearch
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
            this.cbSpecies = new System.Windows.Forms.ComboBox();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.cbBreed = new System.Windows.Forms.ComboBox();
            this.lblBreed = new System.Windows.Forms.Label();
            this.lbAnimals = new System.Windows.Forms.ListBox();
            this.lblAnimalListName = new System.Windows.Forms.Label();
            this.cbAdopted = new System.Windows.Forms.CheckBox();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.lbSerchName = new System.Windows.Forms.Label();
            this.gbAnimale_Information = new System.Windows.Forms.GroupBox();
            this.lbAnimalName = new System.Windows.Forms.Label();
            this.lbAnimalSpecies = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.gbAnimale_Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSpecies
            // 
            this.cbSpecies.FormattingEnabled = true;
            this.cbSpecies.Location = new System.Drawing.Point(30, 66);
            this.cbSpecies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSpecies.Name = "cbSpecies";
            this.cbSpecies.Size = new System.Drawing.Size(217, 28);
            this.cbSpecies.TabIndex = 0;
            this.cbSpecies.SelectedIndexChanged += new System.EventHandler(this.cbSpecies_SelectedIndexChanged);
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(26, 42);
            this.lblSpecies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(66, 20);
            this.lblSpecies.TabIndex = 1;
            this.lblSpecies.Text = "Species";
            // 
            // cbBreed
            // 
            this.cbBreed.FormattingEnabled = true;
            this.cbBreed.Location = new System.Drawing.Point(30, 129);
            this.cbBreed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBreed.Name = "cbBreed";
            this.cbBreed.Size = new System.Drawing.Size(217, 28);
            this.cbBreed.TabIndex = 2;
            this.cbBreed.SelectedIndexChanged += new System.EventHandler(this.cbBreed_SelectedIndexChanged);
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(26, 105);
            this.lblBreed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(52, 20);
            this.lblBreed.TabIndex = 3;
            this.lblBreed.Text = "Breed";
            // 
            // lbAnimals
            // 
            this.lbAnimals.FormattingEnabled = true;
            this.lbAnimals.ItemHeight = 20;
            this.lbAnimals.Location = new System.Drawing.Point(540, 66);
            this.lbAnimals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbAnimals.Name = "lbAnimals";
            this.lbAnimals.Size = new System.Drawing.Size(456, 144);
            this.lbAnimals.TabIndex = 4;
            this.lbAnimals.SelectedIndexChanged += new System.EventHandler(this.lbAnimals_SelectedIndexChanged);
            // 
            // lblAnimalListName
            // 
            this.lblAnimalListName.AutoSize = true;
            this.lblAnimalListName.Location = new System.Drawing.Point(540, 40);
            this.lblAnimalListName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnimalListName.Name = "lblAnimalListName";
            this.lblAnimalListName.Size = new System.Drawing.Size(51, 20);
            this.lblAnimalListName.TabIndex = 5;
            this.lblAnimalListName.Text = "Name";
            // 
            // cbAdopted
            // 
            this.cbAdopted.AutoSize = true;
            this.cbAdopted.Location = new System.Drawing.Point(24, 272);
            this.cbAdopted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAdopted.Name = "cbAdopted";
            this.cbAdopted.Size = new System.Drawing.Size(152, 24);
            this.cbAdopted.TabIndex = 7;
            this.cbAdopted.Text = "Include Adopted";
            this.cbAdopted.UseVisualStyleBackColor = true;
            // 
            // pbPicture
            // 
            this.pbPicture.ErrorImage = global::AdoptAPet.Properties.Resources.shadow;
            this.pbPicture.Location = new System.Drawing.Point(540, 243);
            this.pbPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(458, 320);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 6;
            this.pbPicture.TabStop = false;
            // 
            // tbSearchName
            // 
            this.tbSearchName.Location = new System.Drawing.Point(30, 214);
            this.tbSearchName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(148, 26);
            this.tbSearchName.TabIndex = 8;
            // 
            // lbSerchName
            // 
            this.lbSerchName.AutoSize = true;
            this.lbSerchName.Location = new System.Drawing.Point(26, 189);
            this.lbSerchName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSerchName.Name = "lbSerchName";
            this.lbSerchName.Size = new System.Drawing.Size(128, 20);
            this.lbSerchName.TabIndex = 9;
            this.lbSerchName.Text = "Search By Name";
            // 
            // gbAnimale_Information
            // 
            this.gbAnimale_Information.Controls.Add(this.lb);
            this.gbAnimale_Information.Controls.Add(this.lbAnimalSpecies);
            this.gbAnimale_Information.Controls.Add(this.lbAnimalName);
            this.gbAnimale_Information.Location = new System.Drawing.Point(24, 334);
            this.gbAnimale_Information.Name = "gbAnimale_Information";
            this.gbAnimale_Information.Size = new System.Drawing.Size(484, 177);
            this.gbAnimale_Information.TabIndex = 10;
            this.gbAnimale_Information.TabStop = false;
            this.gbAnimale_Information.Text = "Animal Information";
            // 
            // lbAnimalName
            // 
            this.lbAnimalName.AutoSize = true;
            this.lbAnimalName.Location = new System.Drawing.Point(7, 26);
            this.lbAnimalName.Name = "lbAnimalName";
            this.lbAnimalName.Size = new System.Drawing.Size(107, 20);
            this.lbAnimalName.TabIndex = 0;
            this.lbAnimalName.Text = "Animal Name:";
            // 
            // lbAnimalSpecies
            // 
            this.lbAnimalSpecies.AutoSize = true;
            this.lbAnimalSpecies.Location = new System.Drawing.Point(8, 55);
            this.lbAnimalSpecies.Name = "lbAnimalSpecies";
            this.lbAnimalSpecies.Size = new System.Drawing.Size(122, 20);
            this.lbAnimalSpecies.TabIndex = 1;
            this.lbAnimalSpecies.Text = "Animal Species:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(8, 86);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(122, 20);
            this.lb.TabIndex = 2;
            this.lb.Text = "Animal Species:";
            // 
            // UserControlSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAnimale_Information);
            this.Controls.Add(this.lbSerchName);
            this.Controls.Add(this.tbSearchName);
            this.Controls.Add(this.cbAdopted);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.lblAnimalListName);
            this.Controls.Add(this.lbAnimals);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.cbBreed);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.cbSpecies);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlSearch";
            this.Size = new System.Drawing.Size(1118, 714);
            this.Load += new System.EventHandler(this.UserControlSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.gbAnimale_Information.ResumeLayout(false);
            this.gbAnimale_Information.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSpecies;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.ComboBox cbBreed;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.ListBox lbAnimals;
        private System.Windows.Forms.Label lblAnimalListName;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.CheckBox cbAdopted;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.Label lbSerchName;
        private System.Windows.Forms.GroupBox gbAnimale_Information;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbAnimalSpecies;
        private System.Windows.Forms.Label lbAnimalName;

    }
}
