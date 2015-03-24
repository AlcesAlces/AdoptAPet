namespace AdoptAPet.UserControls
{
    partial class UserControlAdoptCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAdoptCheckOut));
            this.gbToC = new System.Windows.Forms.GroupBox();
            this.txtToC = new System.Windows.Forms.TextBox();
            this.gbAdopter = new System.Windows.Forms.GroupBox();
            this.gbAdopterLocation = new System.Windows.Forms.GroupBox();
            this.txtAdopterZip = new System.Windows.Forms.TextBox();
            this.lblAdopterZip = new System.Windows.Forms.Label();
            this.txtAdopterState = new System.Windows.Forms.TextBox();
            this.lblAdopterState = new System.Windows.Forms.Label();
            this.txtAdopterCity = new System.Windows.Forms.TextBox();
            this.lblAdopterCity = new System.Windows.Forms.Label();
            this.txtAdopterStreetAddress = new System.Windows.Forms.TextBox();
            this.lblAdopterStreetAddress = new System.Windows.Forms.Label();
            this.gbAdopterInformation = new System.Windows.Forms.GroupBox();
            this.lblAdopterName = new System.Windows.Forms.Label();
            this.lblAdopterDoB = new System.Windows.Forms.Label();
            this.lblAdopterEmail = new System.Windows.Forms.Label();
            this.lblHasAdopted = new System.Windows.Forms.Label();
            this.txtAdopterDoB = new System.Windows.Forms.TextBox();
            this.txtHasAdopted = new System.Windows.Forms.TextBox();
            this.txtAdopterEmail = new System.Windows.Forms.TextBox();
            this.txtAdopterName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbAnimalPhoto = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbToC.SuspendLayout();
            this.gbAdopter.SuspendLayout();
            this.gbAdopterLocation.SuspendLayout();
            this.gbAdopterInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimalPhoto)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbToC
            // 
            this.gbToC.Controls.Add(this.txtToC);
            this.gbToC.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToC.Location = new System.Drawing.Point(0, 3);
            this.gbToC.Name = "gbToC";
            this.gbToC.Size = new System.Drawing.Size(1116, 136);
            this.gbToC.TabIndex = 0;
            this.gbToC.TabStop = false;
            this.gbToC.Text = "Terms of Conditions";
            // 
            // txtToC
            // 
            this.txtToC.Enabled = false;
            this.txtToC.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToC.Location = new System.Drawing.Point(6, 36);
            this.txtToC.Multiline = true;
            this.txtToC.Name = "txtToC";
            this.txtToC.Size = new System.Drawing.Size(1104, 92);
            this.txtToC.TabIndex = 0;
            this.txtToC.Text = resources.GetString("txtToC.Text");
            // 
            // gbAdopter
            // 
            this.gbAdopter.Controls.Add(this.gbAdopterInformation);
            this.gbAdopter.Controls.Add(this.gbAdopterLocation);
            this.gbAdopter.Enabled = false;
            this.gbAdopter.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdopter.Location = new System.Drawing.Point(39, 145);
            this.gbAdopter.Name = "gbAdopter";
            this.gbAdopter.Size = new System.Drawing.Size(500, 295);
            this.gbAdopter.TabIndex = 1;
            this.gbAdopter.TabStop = false;
            this.gbAdopter.Text = "Adopter";
            // 
            // gbAdopterLocation
            // 
            this.gbAdopterLocation.Controls.Add(this.txtAdopterZip);
            this.gbAdopterLocation.Controls.Add(this.lblAdopterZip);
            this.gbAdopterLocation.Controls.Add(this.txtAdopterState);
            this.gbAdopterLocation.Controls.Add(this.lblAdopterState);
            this.gbAdopterLocation.Controls.Add(this.txtAdopterCity);
            this.gbAdopterLocation.Controls.Add(this.lblAdopterCity);
            this.gbAdopterLocation.Controls.Add(this.txtAdopterStreetAddress);
            this.gbAdopterLocation.Controls.Add(this.lblAdopterStreetAddress);
            this.gbAdopterLocation.Location = new System.Drawing.Point(6, 167);
            this.gbAdopterLocation.Name = "gbAdopterLocation";
            this.gbAdopterLocation.Size = new System.Drawing.Size(484, 117);
            this.gbAdopterLocation.TabIndex = 13;
            this.gbAdopterLocation.TabStop = false;
            this.gbAdopterLocation.Text = "Location";
            // 
            // txtAdopterZip
            // 
            this.txtAdopterZip.Location = new System.Drawing.Point(399, 76);
            this.txtAdopterZip.Name = "txtAdopterZip";
            this.txtAdopterZip.ReadOnly = true;
            this.txtAdopterZip.Size = new System.Drawing.Size(79, 29);
            this.txtAdopterZip.TabIndex = 7;
            // 
            // lblAdopterZip
            // 
            this.lblAdopterZip.AutoSize = true;
            this.lblAdopterZip.Location = new System.Drawing.Point(358, 79);
            this.lblAdopterZip.Name = "lblAdopterZip";
            this.lblAdopterZip.Size = new System.Drawing.Size(46, 22);
            this.lblAdopterZip.TabIndex = 6;
            this.lblAdopterZip.Text = "Zip:";
            this.lblAdopterZip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAdopterState
            // 
            this.txtAdopterState.Location = new System.Drawing.Point(315, 76);
            this.txtAdopterState.Name = "txtAdopterState";
            this.txtAdopterState.ReadOnly = true;
            this.txtAdopterState.Size = new System.Drawing.Size(37, 29);
            this.txtAdopterState.TabIndex = 5;
            // 
            // lblAdopterState
            // 
            this.lblAdopterState.AutoSize = true;
            this.lblAdopterState.Location = new System.Drawing.Point(257, 79);
            this.lblAdopterState.Name = "lblAdopterState";
            this.lblAdopterState.Size = new System.Drawing.Size(61, 22);
            this.lblAdopterState.TabIndex = 4;
            this.lblAdopterState.Text = "State:";
            this.lblAdopterState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAdopterCity
            // 
            this.txtAdopterCity.Location = new System.Drawing.Point(52, 76);
            this.txtAdopterCity.Name = "txtAdopterCity";
            this.txtAdopterCity.ReadOnly = true;
            this.txtAdopterCity.Size = new System.Drawing.Size(199, 29);
            this.txtAdopterCity.TabIndex = 3;
            // 
            // lblAdopterCity
            // 
            this.lblAdopterCity.AutoSize = true;
            this.lblAdopterCity.Location = new System.Drawing.Point(6, 79);
            this.lblAdopterCity.Name = "lblAdopterCity";
            this.lblAdopterCity.Size = new System.Drawing.Size(52, 22);
            this.lblAdopterCity.TabIndex = 2;
            this.lblAdopterCity.Text = "City:";
            this.lblAdopterCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAdopterStreetAddress
            // 
            this.txtAdopterStreetAddress.Location = new System.Drawing.Point(152, 37);
            this.txtAdopterStreetAddress.Name = "txtAdopterStreetAddress";
            this.txtAdopterStreetAddress.ReadOnly = true;
            this.txtAdopterStreetAddress.Size = new System.Drawing.Size(327, 29);
            this.txtAdopterStreetAddress.TabIndex = 1;
            // 
            // lblAdopterStreetAddress
            // 
            this.lblAdopterStreetAddress.AutoSize = true;
            this.lblAdopterStreetAddress.Location = new System.Drawing.Point(6, 37);
            this.lblAdopterStreetAddress.Name = "lblAdopterStreetAddress";
            this.lblAdopterStreetAddress.Size = new System.Drawing.Size(152, 22);
            this.lblAdopterStreetAddress.TabIndex = 0;
            this.lblAdopterStreetAddress.Text = "Street Address: ";
            // 
            // gbAdopterInformation
            // 
            this.gbAdopterInformation.Controls.Add(this.txtAdopterName);
            this.gbAdopterInformation.Controls.Add(this.txtAdopterEmail);
            this.gbAdopterInformation.Controls.Add(this.txtHasAdopted);
            this.gbAdopterInformation.Controls.Add(this.txtAdopterDoB);
            this.gbAdopterInformation.Controls.Add(this.lblHasAdopted);
            this.gbAdopterInformation.Controls.Add(this.lblAdopterEmail);
            this.gbAdopterInformation.Controls.Add(this.lblAdopterDoB);
            this.gbAdopterInformation.Controls.Add(this.lblAdopterName);
            this.gbAdopterInformation.Location = new System.Drawing.Point(6, 28);
            this.gbAdopterInformation.Name = "gbAdopterInformation";
            this.gbAdopterInformation.Size = new System.Drawing.Size(484, 133);
            this.gbAdopterInformation.TabIndex = 14;
            this.gbAdopterInformation.TabStop = false;
            this.gbAdopterInformation.Text = "Personal Information";
            // 
            // lblAdopterName
            // 
            this.lblAdopterName.AutoSize = true;
            this.lblAdopterName.Location = new System.Drawing.Point(6, 28);
            this.lblAdopterName.Name = "lblAdopterName";
            this.lblAdopterName.Size = new System.Drawing.Size(66, 22);
            this.lblAdopterName.TabIndex = 1;
            this.lblAdopterName.Text = "Name:";
            // 
            // lblAdopterDoB
            // 
            this.lblAdopterDoB.AutoSize = true;
            this.lblAdopterDoB.Location = new System.Drawing.Point(6, 63);
            this.lblAdopterDoB.Name = "lblAdopterDoB";
            this.lblAdopterDoB.Size = new System.Drawing.Size(142, 22);
            this.lblAdopterDoB.TabIndex = 2;
            this.lblAdopterDoB.Text = "Date Of Birth:";
            // 
            // lblAdopterEmail
            // 
            this.lblAdopterEmail.AutoSize = true;
            this.lblAdopterEmail.Location = new System.Drawing.Point(6, 98);
            this.lblAdopterEmail.Name = "lblAdopterEmail";
            this.lblAdopterEmail.Size = new System.Drawing.Size(71, 22);
            this.lblAdopterEmail.TabIndex = 3;
            this.lblAdopterEmail.Text = "Email:";
            // 
            // lblHasAdopted
            // 
            this.lblHasAdopted.AutoSize = true;
            this.lblHasAdopted.Location = new System.Drawing.Point(288, 63);
            this.lblHasAdopted.Name = "lblHasAdopted";
            this.lblHasAdopted.Size = new System.Drawing.Size(131, 22);
            this.lblHasAdopted.TabIndex = 4;
            this.lblHasAdopted.Text = "Has Adopted:";
            // 
            // txtAdopterDoB
            // 
            this.txtAdopterDoB.Enabled = false;
            this.txtAdopterDoB.Location = new System.Drawing.Point(151, 60);
            this.txtAdopterDoB.Name = "txtAdopterDoB";
            this.txtAdopterDoB.Size = new System.Drawing.Size(131, 29);
            this.txtAdopterDoB.TabIndex = 5;
            // 
            // txtHasAdopted
            // 
            this.txtHasAdopted.Enabled = false;
            this.txtHasAdopted.Location = new System.Drawing.Point(419, 60);
            this.txtHasAdopted.Name = "txtHasAdopted";
            this.txtHasAdopted.Size = new System.Drawing.Size(59, 29);
            this.txtHasAdopted.TabIndex = 6;
            // 
            // txtAdopterEmail
            // 
            this.txtAdopterEmail.Enabled = false;
            this.txtAdopterEmail.Location = new System.Drawing.Point(83, 95);
            this.txtAdopterEmail.Name = "txtAdopterEmail";
            this.txtAdopterEmail.Size = new System.Drawing.Size(395, 29);
            this.txtAdopterEmail.TabIndex = 7;
            // 
            // txtAdopterName
            // 
            this.txtAdopterName.Enabled = false;
            this.txtAdopterName.Location = new System.Drawing.Point(78, 25);
            this.txtAdopterName.Name = "txtAdopterName";
            this.txtAdopterName.Size = new System.Drawing.Size(400, 29);
            this.txtAdopterName.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(576, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 518);
            this.panel1.TabIndex = 3;
            // 
            // pbAnimalPhoto
            // 
            this.pbAnimalPhoto.Location = new System.Drawing.Point(39, 447);
            this.pbAnimalPhoto.Name = "pbAnimalPhoto";
            this.pbAnimalPhoto.Size = new System.Drawing.Size(500, 216);
            this.pbAnimalPhoto.TabIndex = 4;
            this.pbAnimalPhoto.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Location = new System.Drawing.Point(216, 694);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 87);
            this.panel2.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(308, 58);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(358, 14);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(308, 58);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // UserControlAdoptCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pbAnimalPhoto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbAdopter);
            this.Controls.Add(this.gbToC);
            this.Name = "UserControlAdoptCheckOut";
            this.Size = new System.Drawing.Size(1119, 806);
            this.gbToC.ResumeLayout(false);
            this.gbToC.PerformLayout();
            this.gbAdopter.ResumeLayout(false);
            this.gbAdopterLocation.ResumeLayout(false);
            this.gbAdopterLocation.PerformLayout();
            this.gbAdopterInformation.ResumeLayout(false);
            this.gbAdopterInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimalPhoto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbToC;
        private System.Windows.Forms.TextBox txtToC;
        private System.Windows.Forms.GroupBox gbAdopter;
        private System.Windows.Forms.GroupBox gbAdopterInformation;
        private System.Windows.Forms.TextBox txtAdopterName;
        private System.Windows.Forms.TextBox txtAdopterEmail;
        private System.Windows.Forms.TextBox txtHasAdopted;
        private System.Windows.Forms.TextBox txtAdopterDoB;
        private System.Windows.Forms.Label lblHasAdopted;
        private System.Windows.Forms.Label lblAdopterEmail;
        private System.Windows.Forms.Label lblAdopterDoB;
        private System.Windows.Forms.Label lblAdopterName;
        private System.Windows.Forms.GroupBox gbAdopterLocation;
        private System.Windows.Forms.TextBox txtAdopterZip;
        private System.Windows.Forms.Label lblAdopterZip;
        private System.Windows.Forms.TextBox txtAdopterState;
        private System.Windows.Forms.Label lblAdopterState;
        private System.Windows.Forms.TextBox txtAdopterCity;
        private System.Windows.Forms.Label lblAdopterCity;
        private System.Windows.Forms.TextBox txtAdopterStreetAddress;
        private System.Windows.Forms.Label lblAdopterStreetAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbAnimalPhoto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
    }
}
