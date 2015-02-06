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
            this.pbPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSpecies
            // 
            this.cbSpecies.FormattingEnabled = true;
            this.cbSpecies.Location = new System.Drawing.Point(20, 43);
            this.cbSpecies.Name = "cbSpecies";
            this.cbSpecies.Size = new System.Drawing.Size(146, 21);
            this.cbSpecies.TabIndex = 0;
            this.cbSpecies.SelectedIndexChanged += new System.EventHandler(this.cbSpecies_SelectedIndexChanged);
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(17, 27);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(45, 13);
            this.lblSpecies.TabIndex = 1;
            this.lblSpecies.Text = "Species";
            // 
            // cbBreed
            // 
            this.cbBreed.FormattingEnabled = true;
            this.cbBreed.Location = new System.Drawing.Point(20, 84);
            this.cbBreed.Name = "cbBreed";
            this.cbBreed.Size = new System.Drawing.Size(146, 21);
            this.cbBreed.TabIndex = 2;
            this.cbBreed.SelectedIndexChanged += new System.EventHandler(this.cbBreed_SelectedIndexChanged);
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(17, 68);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(35, 13);
            this.lblBreed.TabIndex = 3;
            this.lblBreed.Text = "Breed";
            // 
            // lbAnimals
            // 
            this.lbAnimals.FormattingEnabled = true;
            this.lbAnimals.Location = new System.Drawing.Point(360, 43);
            this.lbAnimals.Name = "lbAnimals";
            this.lbAnimals.Size = new System.Drawing.Size(305, 95);
            this.lbAnimals.TabIndex = 4;
            this.lbAnimals.SelectedIndexChanged += new System.EventHandler(this.lbAnimals_SelectedIndexChanged);
            // 
            // lblAnimalListName
            // 
            this.lblAnimalListName.AutoSize = true;
            this.lblAnimalListName.Location = new System.Drawing.Point(360, 26);
            this.lblAnimalListName.Name = "lblAnimalListName";
            this.lblAnimalListName.Size = new System.Drawing.Size(35, 13);
            this.lblAnimalListName.TabIndex = 5;
            this.lblAnimalListName.Text = "Name";
            // 
            // pbPicture
            // 
            this.pbPicture.ErrorImage = global::AdoptAPet.Properties.Resources.shadow;
            this.pbPicture.Location = new System.Drawing.Point(360, 144);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(305, 208);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 6;
            this.pbPicture.TabStop = false;
            // 
            // UserControlSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.lblAnimalListName);
            this.Controls.Add(this.lbAnimals);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.cbBreed);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.cbSpecies);
            this.Name = "UserControlSearch";
            this.Size = new System.Drawing.Size(745, 464);
            this.Load += new System.EventHandler(this.UserControlSearch_Load);
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

    }
}
