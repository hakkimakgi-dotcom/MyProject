namespace CharacterCountWinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.CheckBox chkIgnoreSpaces;
        private System.Windows.Forms.Label lblBoth;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.chkIgnoreSpaces = new System.Windows.Forms.CheckBox();
            this.lblBoth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Multiline = true;
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(460, 200);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // chkIgnoreSpaces
            // 
            this.chkIgnoreSpaces.AutoSize = true;
            this.chkIgnoreSpaces.Location = new System.Drawing.Point(12, 218);
            this.chkIgnoreSpaces.Name = "chkIgnoreSpaces";
            this.chkIgnoreSpaces.Size = new System.Drawing.Size(122, 21);
            this.chkIgnoreSpaces.TabIndex = 1;
            this.chkIgnoreSpaces.Text = "Boşlukları sayma";
            this.chkIgnoreSpaces.UseVisualStyleBackColor = true;
            this.chkIgnoreSpaces.CheckedChanged += new System.EventHandler(this.chkIgnoreSpaces_CheckedChanged);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(12, 246);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(131, 17);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "Karakter sayısı: 0";
            // 
            // lblBoth
            // 
            this.lblBoth.AutoSize = true;
            this.lblBoth.Location = new System.Drawing.Point(12, 270);
            this.lblBoth.Name = "lblBoth";
            this.lblBoth.Size = new System.Drawing.Size(180, 17);
            this.lblBoth.TabIndex = 3;
            this.lblBoth.Text = "Toplam: 0  |  Boşluk hariç: 0";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(484, 301);
            this.Controls.Add(this.lblBoth);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.chkIgnoreSpaces);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karakter Sayacı";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}