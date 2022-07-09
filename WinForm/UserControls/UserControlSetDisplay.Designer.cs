namespace WinForm
{
    partial class UserControlSetDisplay
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelWordsCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(23, 21);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(285, 42);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            this.labelName.MouseEnter += new System.EventHandler(this.UserControlSetDisplay_MouseEnter);
            this.labelName.MouseLeave += new System.EventHandler(this.UserControlSetDisplay_MouseLeave);
            // 
            // labelWordsCount
            // 
            this.labelWordsCount.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWordsCount.ForeColor = System.Drawing.Color.DimGray;
            this.labelWordsCount.Location = new System.Drawing.Point(24, 63);
            this.labelWordsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWordsCount.Name = "labelWordsCount";
            this.labelWordsCount.Size = new System.Drawing.Size(133, 28);
            this.labelWordsCount.TabIndex = 1;
            this.labelWordsCount.Text = "words count";
            this.labelWordsCount.MouseEnter += new System.EventHandler(this.UserControlSetDisplay_MouseEnter);
            this.labelWordsCount.MouseLeave += new System.EventHandler(this.UserControlSetDisplay_MouseLeave);
            // 
            // UserControlSetDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelWordsCount);
            this.Controls.Add(this.labelName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlSetDisplay";
            this.Size = new System.Drawing.Size(335, 139);
            this.Load += new System.EventHandler(this.UserControlSetDisplay_Load);
            this.Click += new System.EventHandler(this.UserControlSetDisplay_Click);
            this.MouseEnter += new System.EventHandler(this.UserControlSetDisplay_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserControlSetDisplay_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelWordsCount;
    }
}
