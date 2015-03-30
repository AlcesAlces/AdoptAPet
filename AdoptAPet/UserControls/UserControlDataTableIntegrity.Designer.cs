namespace AdoptAPet.UserControls
{
    partial class UserControlDataTableIntegrity
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbSelectTable = new System.Windows.Forms.GroupBox();
            this.lsbTableSelection = new System.Windows.Forms.ListBox();
            this.gbSelectAction = new System.Windows.Forms.GroupBox();
            this.gbManualEntry = new System.Windows.Forms.GroupBox();
            this.gbLoadFile = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbSelectTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Table Integrity: Table Management";
            // 
            // gbSelectTable
            // 
            this.gbSelectTable.Controls.Add(this.lsbTableSelection);
            this.gbSelectTable.Location = new System.Drawing.Point(9, 37);
            this.gbSelectTable.Name = "gbSelectTable";
            this.gbSelectTable.Size = new System.Drawing.Size(433, 284);
            this.gbSelectTable.TabIndex = 1;
            this.gbSelectTable.TabStop = false;
            this.gbSelectTable.Text = "SELECT TABLE";
            // 
            // lsbTableSelection
            // 
            this.lsbTableSelection.FormattingEnabled = true;
            this.lsbTableSelection.ItemHeight = 20;
            this.lsbTableSelection.Location = new System.Drawing.Point(6, 25);
            this.lsbTableSelection.Name = "lsbTableSelection";
            this.lsbTableSelection.Size = new System.Drawing.Size(421, 244);
            this.lsbTableSelection.TabIndex = 0;
            // 
            // gbSelectAction
            // 
            this.gbSelectAction.Location = new System.Drawing.Point(9, 327);
            this.gbSelectAction.Name = "gbSelectAction";
            this.gbSelectAction.Size = new System.Drawing.Size(433, 180);
            this.gbSelectAction.TabIndex = 2;
            this.gbSelectAction.TabStop = false;
            this.gbSelectAction.Text = "SELECT ACTION";
            // 
            // gbManualEntry
            // 
            this.gbManualEntry.Location = new System.Drawing.Point(448, 42);
            this.gbManualEntry.Name = "gbManualEntry";
            this.gbManualEntry.Size = new System.Drawing.Size(641, 465);
            this.gbManualEntry.TabIndex = 3;
            this.gbManualEntry.TabStop = false;
            this.gbManualEntry.Text = "MANUAL ENTRY";
            // 
            // gbLoadFile
            // 
            this.gbLoadFile.Location = new System.Drawing.Point(9, 513);
            this.gbLoadFile.Name = "gbLoadFile";
            this.gbLoadFile.Size = new System.Drawing.Size(1080, 178);
            this.gbLoadFile.TabIndex = 4;
            this.gbLoadFile.TabStop = false;
            this.gbLoadFile.Text = "AUTO ENTRY : LOAD FILE";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(494, 729);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 56);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // UserControlDataTableIntegrity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbLoadFile);
            this.Controls.Add(this.gbManualEntry);
            this.Controls.Add(this.gbSelectAction);
            this.Controls.Add(this.gbSelectTable);
            this.Controls.Add(this.label1);
            this.Name = "UserControlDataTableIntegrity";
            this.Size = new System.Drawing.Size(1119, 806);
            this.gbSelectTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSelectTable;
        private System.Windows.Forms.ListBox lsbTableSelection;
        private System.Windows.Forms.GroupBox gbSelectAction;
        private System.Windows.Forms.GroupBox gbManualEntry;
        private System.Windows.Forms.GroupBox gbLoadFile;
        private System.Windows.Forms.Button btnBack;
    }
}
