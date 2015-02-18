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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlSearch));
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
            this.lblAnimalName = new System.Windows.Forms.Label();
            this.lblAnimalSpecies = new System.Windows.Forms.Label();
            this.lblAnimalBreed = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtAnimalName_Information = new System.Windows.Forms.TextBox();
            this.txtAnimalSpecies_Infomation = new System.Windows.Forms.TextBox();
            this.txtAnimalBreed_Information = new System.Windows.Forms.TextBox();
            this.txtAnimalDes_Information = new System.Windows.Forms.TextBox();
            this.btnAdopt_Information = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Sat_UserLoginStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbIsAdoptedPicture_Information = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.gbAnimale_Information.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsAdoptedPicture_Information)).BeginInit();
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
            this.cbAdopted.CheckedChanged += new System.EventHandler(this.cbAdopted_CheckedChanged);
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
            this.tbSearchName.TextChanged += new System.EventHandler(this.tbSearchName_TextChanged);
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
            this.gbAnimale_Information.Controls.Add(this.pbIsAdoptedPicture_Information);
            this.gbAnimale_Information.Controls.Add(this.btnAdopt_Information);
            this.gbAnimale_Information.Controls.Add(this.txtAnimalDes_Information);
            this.gbAnimale_Information.Controls.Add(this.txtAnimalBreed_Information);
            this.gbAnimale_Information.Controls.Add(this.txtAnimalSpecies_Infomation);
            this.gbAnimale_Information.Controls.Add(this.txtAnimalName_Information);
            this.gbAnimale_Information.Controls.Add(this.lblDescription);
            this.gbAnimale_Information.Controls.Add(this.lblAnimalBreed);
            this.gbAnimale_Information.Controls.Add(this.lblAnimalSpecies);
            this.gbAnimale_Information.Controls.Add(this.lblAnimalName);
            this.gbAnimale_Information.Location = new System.Drawing.Point(24, 334);
            this.gbAnimale_Information.Name = "gbAnimale_Information";
            this.gbAnimale_Information.Size = new System.Drawing.Size(484, 229);
            this.gbAnimale_Information.TabIndex = 10;
            this.gbAnimale_Information.TabStop = false;
            this.gbAnimale_Information.Text = "Animal Information";
            // 
            // lblAnimalName
            // 
            this.lblAnimalName.AutoSize = true;
            this.lblAnimalName.Location = new System.Drawing.Point(8, 22);
            this.lblAnimalName.Name = "lblAnimalName";
            this.lblAnimalName.Size = new System.Drawing.Size(107, 20);
            this.lblAnimalName.TabIndex = 0;
            this.lblAnimalName.Text = "Animal Name:";
            // 
            // lblAnimalSpecies
            // 
            this.lblAnimalSpecies.AutoSize = true;
            this.lblAnimalSpecies.Location = new System.Drawing.Point(8, 53);
            this.lblAnimalSpecies.Name = "lblAnimalSpecies";
            this.lblAnimalSpecies.Size = new System.Drawing.Size(122, 20);
            this.lblAnimalSpecies.TabIndex = 1;
            this.lblAnimalSpecies.Text = "Animal Species:";
            // 
            // lblAnimalBreed
            // 
            this.lblAnimalBreed.AutoSize = true;
            this.lblAnimalBreed.Location = new System.Drawing.Point(8, 84);
            this.lblAnimalBreed.Name = "lblAnimalBreed";
            this.lblAnimalBreed.Size = new System.Drawing.Size(108, 20);
            this.lblAnimalBreed.TabIndex = 2;
            this.lblAnimalBreed.Text = "Animal Breed:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(7, 112);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(145, 20);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Animal Description:";
            // 
            // txtAnimalName_Information
            // 
            this.txtAnimalName_Information.Enabled = false;
            this.txtAnimalName_Information.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimalName_Information.Location = new System.Drawing.Point(163, 22);
            this.txtAnimalName_Information.Name = "txtAnimalName_Information";
            this.txtAnimalName_Information.Size = new System.Drawing.Size(164, 29);
            this.txtAnimalName_Information.TabIndex = 4;
            // 
            // txtAnimalSpecies_Infomation
            // 
            this.txtAnimalSpecies_Infomation.Enabled = false;
            this.txtAnimalSpecies_Infomation.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimalSpecies_Infomation.Location = new System.Drawing.Point(163, 53);
            this.txtAnimalSpecies_Infomation.Name = "txtAnimalSpecies_Infomation";
            this.txtAnimalSpecies_Infomation.Size = new System.Drawing.Size(164, 29);
            this.txtAnimalSpecies_Infomation.TabIndex = 5;
            // 
            // txtAnimalBreed_Information
            // 
            this.txtAnimalBreed_Information.Enabled = false;
            this.txtAnimalBreed_Information.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimalBreed_Information.Location = new System.Drawing.Point(163, 84);
            this.txtAnimalBreed_Information.Name = "txtAnimalBreed_Information";
            this.txtAnimalBreed_Information.Size = new System.Drawing.Size(164, 29);
            this.txtAnimalBreed_Information.TabIndex = 6;
            // 
            // txtAnimalDes_Information
            // 
            this.txtAnimalDes_Information.Enabled = false;
            this.txtAnimalDes_Information.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimalDes_Information.Location = new System.Drawing.Point(12, 135);
            this.txtAnimalDes_Information.Multiline = true;
            this.txtAnimalDes_Information.Name = "txtAnimalDes_Information";
            this.txtAnimalDes_Information.Size = new System.Drawing.Size(315, 75);
            this.txtAnimalDes_Information.TabIndex = 7;
            // 
            // btnAdopt_Information
            // 
            this.btnAdopt_Information.Location = new System.Drawing.Point(368, 150);
            this.btnAdopt_Information.Name = "btnAdopt_Information";
            this.btnAdopt_Information.Size = new System.Drawing.Size(75, 44);
            this.btnAdopt_Information.TabIndex = 8;
            this.btnAdopt_Information.Text = "Adopt";
            this.btnAdopt_Information.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sat_UserLoginStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 684);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1118, 30);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Sat_UserLoginStatus
            // 
            this.Sat_UserLoginStatus.Name = "Sat_UserLoginStatus";
            this.Sat_UserLoginStatus.Size = new System.Drawing.Size(94, 25);
            this.Sat_UserLoginStatus.Text = "UserName";
            // 
            // pbIsAdoptedPicture_Information
            // 
            this.pbIsAdoptedPicture_Information.Image = ((System.Drawing.Image)(resources.GetObject("pbIsAdoptedPicture_Information.Image")));
            this.pbIsAdoptedPicture_Information.Location = new System.Drawing.Point(343, 22);
            this.pbIsAdoptedPicture_Information.Name = "pbIsAdoptedPicture_Information";
            this.pbIsAdoptedPicture_Information.Size = new System.Drawing.Size(124, 110);
            this.pbIsAdoptedPicture_Information.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIsAdoptedPicture_Information.TabIndex = 9;
            this.pbIsAdoptedPicture_Information.TabStop = false;
            // 
            // UserControlSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsAdoptedPicture_Information)).EndInit();
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
        private System.Windows.Forms.Label lblAnimalBreed;
        private System.Windows.Forms.Label lblAnimalSpecies;
        private System.Windows.Forms.Label lblAnimalName;
        private System.Windows.Forms.Button btnAdopt_Information;
        private System.Windows.Forms.TextBox txtAnimalDes_Information;
        private System.Windows.Forms.TextBox txtAnimalBreed_Information;
        private System.Windows.Forms.TextBox txtAnimalSpecies_Infomation;
        private System.Windows.Forms.TextBox txtAnimalName_Information;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Sat_UserLoginStatus;
        private System.Windows.Forms.PictureBox pbIsAdoptedPicture_Information;

    }
}
