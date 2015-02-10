namespace AdoptAPet
{
    partial class AddAnimal
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSpecies = new System.Windows.Forms.ComboBox();
            this.cbBreed = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ofdAddAnimal = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowseIMage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFriendly = new System.Windows.Forms.CheckBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbFixed = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(12, 64);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(35, 20);
            this.txtAge.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // cbSpecies
            // 
            this.cbSpecies.FormattingEnabled = true;
            this.cbSpecies.Location = new System.Drawing.Point(12, 163);
            this.cbSpecies.Name = "cbSpecies";
            this.cbSpecies.Size = new System.Drawing.Size(121, 21);
            this.cbSpecies.TabIndex = 4;
            this.cbSpecies.SelectedIndexChanged += new System.EventHandler(this.cbSpecies_SelectedIndexChanged_1);
            // 
            // cbBreed
            // 
            this.cbBreed.FormattingEnabled = true;
            this.cbBreed.Location = new System.Drawing.Point(12, 203);
            this.cbBreed.Name = "cbBreed";
            this.cbBreed.Size = new System.Drawing.Size(121, 21);
            this.cbBreed.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Species";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Breed";
            // 
            // ofdAddAnimal
            // 
            this.ofdAddAnimal.FileName = "ofdAddAnimal";
            this.ofdAddAnimal.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdAddAnimal_FileOk);
            // 
            // btnBrowseIMage
            // 
            this.btnBrowseIMage.Location = new System.Drawing.Point(12, 245);
            this.btnBrowseIMage.Name = "btnBrowseIMage";
            this.btnBrowseIMage.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseIMage.TabIndex = 8;
            this.btnBrowseIMage.Text = "Browse...";
            this.btnBrowseIMage.UseVisualStyleBackColor = true;
            this.btnBrowseIMage.Click += new System.EventHandler(this.btnBrowseIMage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select an Image";
            // 
            // pbPreview
            // 
            this.pbPreview.Location = new System.Drawing.Point(487, 9);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(248, 199);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreview.TabIndex = 10;
            this.pbPreview.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Age";
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "female",
            "male"});
            this.cbSex.Location = new System.Drawing.Point(12, 103);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(65, 21);
            this.cbSex.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sex";
            // 
            // cbFriendly
            // 
            this.cbFriendly.AutoSize = true;
            this.cbFriendly.Location = new System.Drawing.Point(169, 25);
            this.cbFriendly.Name = "cbFriendly";
            this.cbFriendly.Size = new System.Drawing.Size(68, 17);
            this.cbFriendly.TabIndex = 14;
            this.cbFriendly.Text = "Friendly?";
            this.cbFriendly.UseVisualStyleBackColor = true;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(169, 203);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(197, 61);
            this.rtbDescription.TabIndex = 15;
            this.rtbDescription.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Short Description";
            // 
            // cbFixed
            // 
            this.cbFixed.AutoSize = true;
            this.cbFixed.Location = new System.Drawing.Point(169, 48);
            this.cbFixed.Name = "cbFixed";
            this.cbFixed.Size = new System.Drawing.Size(57, 17);
            this.cbFixed.TabIndex = 17;
            this.cbFixed.Text = "Fixed?";
            this.cbFixed.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(487, 241);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AddAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 283);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbFixed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.cbFriendly);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBrowseIMage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBreed);
            this.Controls.Add(this.cbSpecies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Name = "AddAnimal";
            this.Text = "AddAnimal";
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSpecies;
        private System.Windows.Forms.ComboBox cbBreed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog ofdAddAnimal;
        private System.Windows.Forms.Button btnBrowseIMage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbFriendly;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbFixed;
        private System.Windows.Forms.Button btnSubmit;
    }
}