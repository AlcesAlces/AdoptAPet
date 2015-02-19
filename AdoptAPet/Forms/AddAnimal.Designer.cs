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
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.panelAddess = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(24, 48);
            this.txtName.Margin = new System.Windows.Forms.Padding(6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 31);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // cbSpecies
            // 
            this.cbSpecies.FormattingEnabled = true;
            this.cbSpecies.Location = new System.Drawing.Point(24, 313);
            this.cbSpecies.Margin = new System.Windows.Forms.Padding(6);
            this.cbSpecies.Name = "cbSpecies";
            this.cbSpecies.Size = new System.Drawing.Size(238, 33);
            this.cbSpecies.TabIndex = 4;
            this.cbSpecies.SelectedIndexChanged += new System.EventHandler(this.cbSpecies_SelectedIndexChanged_1);
            // 
            // cbBreed
            // 
            this.cbBreed.FormattingEnabled = true;
            this.cbBreed.Location = new System.Drawing.Point(24, 390);
            this.cbBreed.Margin = new System.Windows.Forms.Padding(6);
            this.cbBreed.Name = "cbBreed";
            this.cbBreed.Size = new System.Drawing.Size(238, 33);
            this.cbBreed.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 283);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Species";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 360);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
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
            this.btnBrowseIMage.Location = new System.Drawing.Point(24, 637);
            this.btnBrowseIMage.Margin = new System.Windows.Forms.Padding(6);
            this.btnBrowseIMage.Name = "btnBrowseIMage";
            this.btnBrowseIMage.Size = new System.Drawing.Size(150, 44);
            this.btnBrowseIMage.TabIndex = 8;
            this.btnBrowseIMage.Text = "Browse...";
            this.btnBrowseIMage.UseVisualStyleBackColor = true;
            this.btnBrowseIMage.Click += new System.EventHandler(this.btnBrowseIMage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 606);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select an Image";
            // 
            // pbPreview
            // 
            this.pbPreview.Location = new System.Drawing.Point(974, 17);
            this.pbPreview.Margin = new System.Windows.Forms.Padding(6);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(496, 383);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreview.TabIndex = 10;
            this.pbPreview.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Age";
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Select Sex",
            "Female",
            "Male"});
            this.cbSex.Location = new System.Drawing.Point(24, 198);
            this.cbSex.Margin = new System.Windows.Forms.Padding(6);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(196, 33);
            this.cbSex.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sex";
            // 
            // cbFriendly
            // 
            this.cbFriendly.AutoSize = true;
            this.cbFriendly.Location = new System.Drawing.Point(338, 48);
            this.cbFriendly.Margin = new System.Windows.Forms.Padding(6);
            this.cbFriendly.Name = "cbFriendly";
            this.cbFriendly.Size = new System.Drawing.Size(133, 29);
            this.cbFriendly.TabIndex = 14;
            this.cbFriendly.Text = "Friendly?";
            this.cbFriendly.UseVisualStyleBackColor = true;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(337, 567);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(6);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(390, 114);
            this.rtbDescription.TabIndex = 15;
            this.rtbDescription.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 536);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Short Description";
            // 
            // cbFixed
            // 
            this.cbFixed.AutoSize = true;
            this.cbFixed.Location = new System.Drawing.Point(338, 92);
            this.cbFixed.Margin = new System.Windows.Forms.Padding(6);
            this.cbFixed.Name = "cbFixed";
            this.cbFixed.Size = new System.Drawing.Size(109, 29);
            this.cbFixed.TabIndex = 17;
            this.cbFixed.Text = "Fixed?";
            this.cbFixed.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(974, 463);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 44);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(24, 473);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(238, 33);
            this.cbColor.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Color";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(24, 123);
            this.txtAge.Margin = new System.Windows.Forms.Padding(6);
            this.txtAge.MaxLength = 3;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(66, 31);
            this.txtAge.TabIndex = 1;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // panelAddess
            // 
            this.panelAddess.Location = new System.Drawing.Point(531, 64);
            this.panelAddess.Name = "panelAddess";
            this.panelAddess.Size = new System.Drawing.Size(415, 155);
            this.panelAddess.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(531, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Address Info";
            // 
            // AddAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 696);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panelAddess);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbColor);
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
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddAnimal";
            this.Text = "AddAnimal";
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
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
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Panel panelAddess;
        private System.Windows.Forms.Label label9;
    }
}