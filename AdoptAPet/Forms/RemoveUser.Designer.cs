namespace AdoptAPet.Forms
{
    partial class RemoveUser
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
            this.lbRemoveUser = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRemoveUser
            // 
            this.lbRemoveUser.FormattingEnabled = true;
            this.lbRemoveUser.ItemHeight = 25;
            this.lbRemoveUser.Location = new System.Drawing.Point(12, 22);
            this.lbRemoveUser.Name = "lbRemoveUser";
            this.lbRemoveUser.Size = new System.Drawing.Size(419, 279);
            this.lbRemoveUser.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(178, 329);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(128, 43);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // RemoveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 402);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbRemoveUser);
            this.Name = "RemoveUser";
            this.Text = "RemoveUser";
            this.Load += new System.EventHandler(this.RemoveUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbRemoveUser;
        private System.Windows.Forms.Button btnRemove;
    }
}