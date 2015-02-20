namespace AdoptAPet.UserControls
{
    partial class UserControlCustomerRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCustomerRecord));
            this.gbCustomer_Information = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.gbCustomerLocation = new System.Windows.Forms.GroupBox();
            this.txtCustomerZip = new System.Windows.Forms.TextBox();
            this.lblCustomerZip = new System.Windows.Forms.Label();
            this.txtCustomerState = new System.Windows.Forms.TextBox();
            this.lblCustomerState = new System.Windows.Forms.Label();
            this.txtCustomerCity = new System.Windows.Forms.TextBox();
            this.lblCustomerCity = new System.Windows.Forms.Label();
            this.txtCustomerStreetAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerStreetAddress = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.GroupBox();
            this.tbTermOfService = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.gbCustomer_Information.SuspendLayout();
            this.gbCustomerLocation.SuspendLayout();
            this.lblCheckOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCustomer_Information
            // 
            this.gbCustomer_Information.Controls.Add(this.textBox1);
            this.gbCustomer_Information.Controls.Add(this.label1);
            this.gbCustomer_Information.Controls.Add(this.txtCustomerEmail);
            this.gbCustomer_Information.Controls.Add(this.txtCustomerName);
            this.gbCustomer_Information.Controls.Add(this.lblCustomerName);
            this.gbCustomer_Information.Location = new System.Drawing.Point(3, 11);
            this.gbCustomer_Information.Name = "gbCustomer_Information";
            this.gbCustomer_Information.Size = new System.Drawing.Size(490, 117);
            this.gbCustomer_Information.TabIndex = 12;
            this.gbCustomer_Information.TabStop = false;
            this.gbCustomer_Information.Text = "Customer Information";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(85, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(385, 30);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email:";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Enabled = false;
            this.txtCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerEmail.Location = new System.Drawing.Point(85, 61);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.ReadOnly = true;
            this.txtCustomerEmail.Size = new System.Drawing.Size(385, 30);
            this.txtCustomerEmail.TabIndex = 6;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(85, 33);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(385, 30);
            this.txtCustomerName.TabIndex = 4;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(9, 40);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(55, 20);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Name:";
            // 
            // gbCustomerLocation
            // 
            this.gbCustomerLocation.Controls.Add(this.txtCustomerZip);
            this.gbCustomerLocation.Controls.Add(this.lblCustomerZip);
            this.gbCustomerLocation.Controls.Add(this.txtCustomerState);
            this.gbCustomerLocation.Controls.Add(this.lblCustomerState);
            this.gbCustomerLocation.Controls.Add(this.txtCustomerCity);
            this.gbCustomerLocation.Controls.Add(this.lblCustomerCity);
            this.gbCustomerLocation.Controls.Add(this.txtCustomerStreetAddress);
            this.gbCustomerLocation.Controls.Add(this.lblCustomerStreetAddress);
            this.gbCustomerLocation.Location = new System.Drawing.Point(503, 11);
            this.gbCustomerLocation.Name = "gbCustomerLocation";
            this.gbCustomerLocation.Size = new System.Drawing.Size(382, 117);
            this.gbCustomerLocation.TabIndex = 13;
            this.gbCustomerLocation.TabStop = false;
            this.gbCustomerLocation.Text = "Customer Location";
            // 
            // txtCustomerZip
            // 
            this.txtCustomerZip.Location = new System.Drawing.Point(295, 78);
            this.txtCustomerZip.Name = "txtCustomerZip";
            this.txtCustomerZip.ReadOnly = true;
            this.txtCustomerZip.Size = new System.Drawing.Size(79, 26);
            this.txtCustomerZip.TabIndex = 7;
            // 
            // lblCustomerZip
            // 
            this.lblCustomerZip.AutoSize = true;
            this.lblCustomerZip.Location = new System.Drawing.Point(254, 78);
            this.lblCustomerZip.Name = "lblCustomerZip";
            this.lblCustomerZip.Size = new System.Drawing.Size(35, 20);
            this.lblCustomerZip.TabIndex = 6;
            this.lblCustomerZip.Text = "Zip:";
            this.lblCustomerZip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCustomerState
            // 
            this.txtCustomerState.Location = new System.Drawing.Point(211, 78);
            this.txtCustomerState.Name = "txtCustomerState";
            this.txtCustomerState.ReadOnly = true;
            this.txtCustomerState.Size = new System.Drawing.Size(37, 26);
            this.txtCustomerState.TabIndex = 5;
            // 
            // lblCustomerState
            // 
            this.lblCustomerState.AutoSize = true;
            this.lblCustomerState.Location = new System.Drawing.Point(153, 79);
            this.lblCustomerState.Name = "lblCustomerState";
            this.lblCustomerState.Size = new System.Drawing.Size(52, 20);
            this.lblCustomerState.TabIndex = 4;
            this.lblCustomerState.Text = "State:";
            this.lblCustomerState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCustomerCity
            // 
            this.txtCustomerCity.Location = new System.Drawing.Point(51, 78);
            this.txtCustomerCity.Name = "txtCustomerCity";
            this.txtCustomerCity.ReadOnly = true;
            this.txtCustomerCity.Size = new System.Drawing.Size(101, 26);
            this.txtCustomerCity.TabIndex = 3;
            // 
            // lblCustomerCity
            // 
            this.lblCustomerCity.AutoSize = true;
            this.lblCustomerCity.Location = new System.Drawing.Point(6, 78);
            this.lblCustomerCity.Name = "lblCustomerCity";
            this.lblCustomerCity.Size = new System.Drawing.Size(39, 20);
            this.lblCustomerCity.TabIndex = 2;
            this.lblCustomerCity.Text = "City:";
            this.lblCustomerCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCustomerStreetAddress
            // 
            this.txtCustomerStreetAddress.Location = new System.Drawing.Point(131, 37);
            this.txtCustomerStreetAddress.Name = "txtCustomerStreetAddress";
            this.txtCustomerStreetAddress.ReadOnly = true;
            this.txtCustomerStreetAddress.Size = new System.Drawing.Size(245, 26);
            this.txtCustomerStreetAddress.TabIndex = 1;
            // 
            // lblCustomerStreetAddress
            // 
            this.lblCustomerStreetAddress.AutoSize = true;
            this.lblCustomerStreetAddress.Location = new System.Drawing.Point(6, 37);
            this.lblCustomerStreetAddress.Name = "lblCustomerStreetAddress";
            this.lblCustomerStreetAddress.Size = new System.Drawing.Size(124, 20);
            this.lblCustomerStreetAddress.TabIndex = 0;
            this.lblCustomerStreetAddress.Text = "Street Address: ";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.Controls.Add(this.tbTermOfService);
            this.lblCheckOut.Controls.Add(this.label2);
            this.lblCheckOut.Location = new System.Drawing.Point(4, 135);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(881, 243);
            this.lblCheckOut.TabIndex = 14;
            this.lblCheckOut.TabStop = false;
            this.lblCheckOut.Text = "Check Out";
            // 
            // tbTermOfService
            // 
            this.tbTermOfService.Enabled = false;
            this.tbTermOfService.Location = new System.Drawing.Point(84, 70);
            this.tbTermOfService.Name = "tbTermOfService";
            this.tbTermOfService.ReadOnly = true;
            this.tbTermOfService.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbTermOfService.Size = new System.Drawing.Size(672, 106);
            this.tbTermOfService.TabIndex = 3;
            this.tbTermOfService.Text = resources.GetString("tbTermOfService.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Term of Service";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // UserControlCustomerRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.gbCustomerLocation);
            this.Controls.Add(this.gbCustomer_Information);
            this.Name = "UserControlCustomerRecord";
            this.Size = new System.Drawing.Size(894, 381);
            this.gbCustomer_Information.ResumeLayout(false);
            this.gbCustomer_Information.PerformLayout();
            this.gbCustomerLocation.ResumeLayout(false);
            this.gbCustomerLocation.PerformLayout();
            this.lblCheckOut.ResumeLayout(false);
            this.lblCheckOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustomer_Information;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCustomerLocation;
        private System.Windows.Forms.TextBox txtCustomerZip;
        private System.Windows.Forms.Label lblCustomerZip;
        private System.Windows.Forms.TextBox txtCustomerState;
        private System.Windows.Forms.Label lblCustomerState;
        private System.Windows.Forms.TextBox txtCustomerCity;
        private System.Windows.Forms.Label lblCustomerCity;
        private System.Windows.Forms.TextBox txtCustomerStreetAddress;
        private System.Windows.Forms.Label lblCustomerStreetAddress;
        private System.Windows.Forms.GroupBox lblCheckOut;
        private System.Windows.Forms.RichTextBox tbTermOfService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}
