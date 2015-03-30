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
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.lbSerchName = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.clbfFilters = new System.Windows.Forms.CheckedListBox();
            this.bwPopComboBoxes = new System.ComponentModel.BackgroundWorker();
            this.bwListBox = new System.ComponentModel.BackgroundWorker();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.pnlAnimalInfo = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSpecies
            // 
            this.cbSpecies.FormattingEnabled = true;
            this.cbSpecies.Location = new System.Drawing.Point(30, 66);
            this.cbSpecies.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbSpecies.Name = "cbSpecies";
            this.cbSpecies.Size = new System.Drawing.Size(217, 28);
            this.cbSpecies.TabIndex = 0;
            this.cbSpecies.SelectedIndexChanged += new System.EventHandler(this.cbSpecies_SelectedIndexChanged);
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(27, 42);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(66, 20);
            this.lblSpecies.TabIndex = 1;
            this.lblSpecies.Text = "Species";
            // 
            // cbBreed
            // 
            this.cbBreed.FormattingEnabled = true;
            this.cbBreed.Location = new System.Drawing.Point(30, 129);
            this.cbBreed.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbBreed.Name = "cbBreed";
            this.cbBreed.Size = new System.Drawing.Size(217, 28);
            this.cbBreed.TabIndex = 2;
            this.cbBreed.SelectedIndexChanged += new System.EventHandler(this.cbBreed_SelectedIndexChanged);
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(27, 105);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(52, 20);
            this.lblBreed.TabIndex = 3;
            this.lblBreed.Text = "Breed";
            // 
            // lbAnimals
            // 
            this.lbAnimals.FormattingEnabled = true;
            this.lbAnimals.ItemHeight = 20;
            this.lbAnimals.Location = new System.Drawing.Point(560, 66);
            this.lbAnimals.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lbAnimals.Name = "lbAnimals";
            this.lbAnimals.Size = new System.Drawing.Size(457, 144);
            this.lbAnimals.TabIndex = 4;
            this.lbAnimals.SelectedIndexChanged += new System.EventHandler(this.lbAnimals_SelectedIndexChanged);
            // 
            // lblAnimalListName
            // 
            this.lblAnimalListName.AutoSize = true;
            this.lblAnimalListName.Location = new System.Drawing.Point(555, 42);
            this.lblAnimalListName.Name = "lblAnimalListName";
            this.lblAnimalListName.Size = new System.Drawing.Size(51, 20);
            this.lblAnimalListName.TabIndex = 5;
            this.lblAnimalListName.Text = "Name";
            // 
            // tbSearchName
            // 
            this.tbSearchName.Location = new System.Drawing.Point(30, 214);
            this.tbSearchName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(148, 26);
            this.tbSearchName.TabIndex = 8;
            this.tbSearchName.TextChanged += new System.EventHandler(this.tbSearchName_TextChanged);
            // 
            // lbSerchName
            // 
            this.lbSerchName.AutoSize = true;
            this.lbSerchName.Location = new System.Drawing.Point(27, 189);
            this.lbSerchName.Name = "lbSerchName";
            this.lbSerchName.Size = new System.Drawing.Size(128, 20);
            this.lbSerchName.TabIndex = 9;
            this.lbSerchName.Text = "Search By Name";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLabelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 784);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1119, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssLabelStatus
            // 
            this.tssLabelStatus.Name = "tssLabelStatus";
            this.tssLabelStatus.Size = new System.Drawing.Size(0, 0);
            // 
            // btnSearchName
            // 
            this.btnSearchName.Location = new System.Drawing.Point(201, 208);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(171, 37);
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
            this.clbfFilters.Location = new System.Drawing.Point(282, 66);
            this.clbfFilters.Name = "clbfFilters";
            this.clbfFilters.Size = new System.Drawing.Size(180, 88);
            this.clbfFilters.TabIndex = 13;
            this.clbfFilters.SelectedIndexChanged += new System.EventHandler(this.clbfFilters_SelectedIndexChanged);
            // 
            // bwPopComboBoxes
            // 
            this.bwPopComboBoxes.DoWork += new System.ComponentModel.DoWorkEventHandler(this.popComboBoxes_DoWork);
            // 
            // bwListBox
            // 
            this.bwListBox.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwListBox_DoWork);
            // 
            // pbPicture
            // 
            this.pbPicture.ErrorImage = global::AdoptAPet.Properties.Resources.shadow;
            this.pbPicture.Location = new System.Drawing.Point(560, 254);
            this.pbPicture.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(459, 320);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 6;
            this.pbPicture.TabStop = false;
            // 
            // pnlAnimalInfo
            // 
            this.pnlAnimalInfo.Location = new System.Drawing.Point(32, 254);
            this.pnlAnimalInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAnimalInfo.Name = "pnlAnimalInfo";
            this.pnlAnimalInfo.Size = new System.Drawing.Size(507, 518);
            this.pnlAnimalInfo.TabIndex = 14;
            // 
            // UserControlSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAnimalInfo);
            this.Controls.Add(this.clbfFilters);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbSerchName);
            this.Controls.Add(this.tbSearchName);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.lblAnimalListName);
            this.Controls.Add(this.lbAnimals);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.cbBreed);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.cbSpecies);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "UserControlSearch";
            this.Size = new System.Drawing.Size(1119, 806);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.CheckedListBox clbfFilters;
        private System.ComponentModel.BackgroundWorker bwPopComboBoxes;
        private System.Windows.Forms.ToolStripStatusLabel tssLabelStatus;
        private System.ComponentModel.BackgroundWorker bwListBox;
        private System.Windows.Forms.Panel pnlAnimalInfo;

    }
}
