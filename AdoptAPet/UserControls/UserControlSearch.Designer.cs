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
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.lbSerchName = new System.Windows.Forms.Label();
            this.gbAnimale_Information = new System.Windows.Forms.GroupBox();
            this.pbIsAdoptedPicture_Information = new System.Windows.Forms.PictureBox();
            this.btnAdopt_Information = new System.Windows.Forms.Button();
            this.txtAnimalDes_Information = new System.Windows.Forms.TextBox();
            this.txtAnimalBreed_Information = new System.Windows.Forms.TextBox();
            this.txtAnimalSpecies_Infomation = new System.Windows.Forms.TextBox();
            this.txtAnimalName_Information = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAnimalBreed = new System.Windows.Forms.Label();
            this.lblAnimalSpecies = new System.Windows.Forms.Label();
            this.lblAnimalName = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Sat_UserLoginStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.clbfFilters = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.gbAnimale_Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsAdoptedPicture_Information)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSpecies
            // 
            this.cbSpecies.FormattingEnabled = true;
            this.cbSpecies.Location = new System.Drawing.Point(20, 43);
            this.cbSpecies.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbSpecies.Name = "cbSpecies";
            this.cbSpecies.Size = new System.Drawing.Size(146, 21);
            this.cbSpecies.TabIndex = 0;
            this.cbSpecies.SelectedIndexChanged += new System.EventHandler(this.cbSpecies_SelectedIndexChanged);
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(18, 27);
            this.lblSpecies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(45, 13);
            this.lblSpecies.TabIndex = 1;
            this.lblSpecies.Text = "Species";
            // 
            // cbBreed
            // 
            this.cbBreed.FormattingEnabled = true;
            this.cbBreed.Location = new System.Drawing.Point(20, 84);
            this.cbBreed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbBreed.Name = "cbBreed";
            this.cbBreed.Size = new System.Drawing.Size(146, 21);
            this.cbBreed.TabIndex = 2;
            this.cbBreed.SelectedIndexChanged += new System.EventHandler(this.cbBreed_SelectedIndexChanged);
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(18, 68);
            this.lblBreed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(35, 13);
            this.lblBreed.TabIndex = 3;
            this.lblBreed.Text = "Breed";
            // 
            // lbAnimals
            // 
            this.lbAnimals.FormattingEnabled = true;
            this.lbAnimals.Location = new System.Drawing.Point(360, 43);
            this.lbAnimals.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbAnimals.Name = "lbAnimals";
            this.lbAnimals.Size = new System.Drawing.Size(306, 95);
            this.lbAnimals.TabIndex = 4;
            this.lbAnimals.SelectedIndexChanged += new System.EventHandler(this.lbAnimals_SelectedIndexChanged);
            // 
            // lblAnimalListName
            // 
            this.lblAnimalListName.AutoSize = true;
            this.lblAnimalListName.Location = new System.Drawing.Point(360, 26);
            this.lblAnimalListName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnimalListName.Name = "lblAnimalListName";
            this.lblAnimalListName.Size = new System.Drawing.Size(35, 13);
            this.lblAnimalListName.TabIndex = 5;
            this.lblAnimalListName.Text = "Name";
            // 
            // pbPicture
            // 
            this.pbPicture.ErrorImage = global::AdoptAPet.Properties.Resources.shadow;
            this.pbPicture.Location = new System.Drawing.Point(360, 158);
            this.pbPicture.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(306, 208);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 6;
            this.pbPicture.TabStop = false;
            // 
            // tbSearchName
            // 
            this.tbSearchName.Location = new System.Drawing.Point(20, 139);
            this.tbSearchName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(100, 20);
            this.tbSearchName.TabIndex = 8;
            this.tbSearchName.TextChanged += new System.EventHandler(this.tbSearchName_TextChanged);
            // 
            // lbSerchName
            // 
            this.lbSerchName.AutoSize = true;
            this.lbSerchName.Location = new System.Drawing.Point(18, 123);
            this.lbSerchName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSerchName.Name = "lbSerchName";
            this.lbSerchName.Size = new System.Drawing.Size(87, 13);
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
            this.gbAnimale_Information.Location = new System.Drawing.Point(16, 217);
            this.gbAnimale_Information.Margin = new System.Windows.Forms.Padding(2);
            this.gbAnimale_Information.Name = "gbAnimale_Information";
            this.gbAnimale_Information.Padding = new System.Windows.Forms.Padding(2);
            this.gbAnimale_Information.Size = new System.Drawing.Size(322, 149);
            this.gbAnimale_Information.TabIndex = 10;
            this.gbAnimale_Information.TabStop = false;
            this.gbAnimale_Information.Text = "Animal Information";
            // 
            // pbIsAdoptedPicture_Information
            // 
            this.pbIsAdoptedPicture_Information.Image = ((System.Drawing.Image)(resources.GetObject("pbIsAdoptedPicture_Information.Image")));
            this.pbIsAdoptedPicture_Information.Location = new System.Drawing.Point(228, 15);
            this.pbIsAdoptedPicture_Information.Margin = new System.Windows.Forms.Padding(2);
            this.pbIsAdoptedPicture_Information.Name = "pbIsAdoptedPicture_Information";
            this.pbIsAdoptedPicture_Information.Size = new System.Drawing.Size(82, 72);
            this.pbIsAdoptedPicture_Information.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIsAdoptedPicture_Information.TabIndex = 9;
            this.pbIsAdoptedPicture_Information.TabStop = false;
            // 
            // btnAdopt_Information
            // 
            this.btnAdopt_Information.Location = new System.Drawing.Point(246, 98);
            this.btnAdopt_Information.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdopt_Information.Name = "btnAdopt_Information";
            this.btnAdopt_Information.Size = new System.Drawing.Size(50, 29);
            this.btnAdopt_Information.TabIndex = 8;
            this.btnAdopt_Information.Text = "Adopt";
            this.btnAdopt_Information.UseVisualStyleBackColor = true;
            // 
            // txtAnimalDes_Information
            // 
            this.txtAnimalDes_Information.Enabled = false;
            this.txtAnimalDes_Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimalDes_Information.Location = new System.Drawing.Point(8, 88);
            this.txtAnimalDes_Information.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnimalDes_Information.Multiline = true;
            this.txtAnimalDes_Information.Name = "txtAnimalDes_Information";
            this.txtAnimalDes_Information.Size = new System.Drawing.Size(212, 50);
            this.txtAnimalDes_Information.TabIndex = 7;
            // 
            // txtAnimalBreed_Information
            // 
            this.txtAnimalBreed_Information.Enabled = false;
            this.txtAnimalBreed_Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimalBreed_Information.Location = new System.Drawing.Point(108, 55);
            this.txtAnimalBreed_Information.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnimalBreed_Information.Name = "txtAnimalBreed_Information";
            this.txtAnimalBreed_Information.Size = new System.Drawing.Size(110, 23);
            this.txtAnimalBreed_Information.TabIndex = 6;
            // 
            // txtAnimalSpecies_Infomation
            // 
            this.txtAnimalSpecies_Infomation.Enabled = false;
            this.txtAnimalSpecies_Infomation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimalSpecies_Infomation.Location = new System.Drawing.Point(108, 34);
            this.txtAnimalSpecies_Infomation.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnimalSpecies_Infomation.Name = "txtAnimalSpecies_Infomation";
            this.txtAnimalSpecies_Infomation.Size = new System.Drawing.Size(110, 23);
            this.txtAnimalSpecies_Infomation.TabIndex = 5;
            // 
            // txtAnimalName_Information
            // 
            this.txtAnimalName_Information.Enabled = false;
            this.txtAnimalName_Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimalName_Information.Location = new System.Drawing.Point(108, 15);
            this.txtAnimalName_Information.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnimalName_Information.Name = "txtAnimalName_Information";
            this.txtAnimalName_Information.Size = new System.Drawing.Size(110, 23);
            this.txtAnimalName_Information.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(4, 73);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(97, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Animal Description:";
            // 
            // lblAnimalBreed
            // 
            this.lblAnimalBreed.AutoSize = true;
            this.lblAnimalBreed.Location = new System.Drawing.Point(6, 55);
            this.lblAnimalBreed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnimalBreed.Name = "lblAnimalBreed";
            this.lblAnimalBreed.Size = new System.Drawing.Size(72, 13);
            this.lblAnimalBreed.TabIndex = 2;
            this.lblAnimalBreed.Text = "Animal Breed:";
            // 
            // lblAnimalSpecies
            // 
            this.lblAnimalSpecies.AutoSize = true;
            this.lblAnimalSpecies.Location = new System.Drawing.Point(6, 34);
            this.lblAnimalSpecies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnimalSpecies.Name = "lblAnimalSpecies";
            this.lblAnimalSpecies.Size = new System.Drawing.Size(82, 13);
            this.lblAnimalSpecies.TabIndex = 1;
            this.lblAnimalSpecies.Text = "Animal Species:";
            // 
            // lblAnimalName
            // 
            this.lblAnimalName.AutoSize = true;
            this.lblAnimalName.Location = new System.Drawing.Point(6, 15);
            this.lblAnimalName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnimalName.Name = "lblAnimalName";
            this.lblAnimalName.Size = new System.Drawing.Size(72, 13);
            this.lblAnimalName.TabIndex = 0;
            this.lblAnimalName.Text = "Animal Name:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sat_UserLoginStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(746, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Sat_UserLoginStatus
            // 
            this.Sat_UserLoginStatus.Name = "Sat_UserLoginStatus";
            this.Sat_UserLoginStatus.Size = new System.Drawing.Size(62, 17);
            this.Sat_UserLoginStatus.Text = "UserName";
            // 
            // btnSearchName
            // 
            this.btnSearchName.Location = new System.Drawing.Point(134, 135);
            this.btnSearchName.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(114, 24);
            this.btnSearchName.TabIndex = 12;
            this.btnSearchName.Text = "Search With Name";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // clbfFilters
            // 
            this.clbfFilters.CheckOnClick = true;
            this.clbfFilters.FormattingEnabled = true;
            this.clbfFilters.Items.AddRange(new object[] {
            "Adopted",
            "Fixed",
            "Friendly"});
            this.clbfFilters.Location = new System.Drawing.Point(188, 43);
            this.clbfFilters.Margin = new System.Windows.Forms.Padding(2);
            this.clbfFilters.Name = "clbfFilters";
            this.clbfFilters.Size = new System.Drawing.Size(121, 64);
            this.clbfFilters.TabIndex = 13;
            this.clbfFilters.SelectedIndexChanged += new System.EventHandler(this.clbfFilters_SelectedIndexChanged);
            // 
            // UserControlSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clbfFilters);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbAnimale_Information);
            this.Controls.Add(this.lbSerchName);
            this.Controls.Add(this.tbSearchName);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.lblAnimalListName);
            this.Controls.Add(this.lbAnimals);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.cbBreed);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.cbSpecies);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "UserControlSearch";
            this.Size = new System.Drawing.Size(746, 464);
            this.Load += new System.EventHandler(this.UserControlSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.gbAnimale_Information.ResumeLayout(false);
            this.gbAnimale_Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsAdoptedPicture_Information)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.CheckedListBox clbfFilters;

    }
}
