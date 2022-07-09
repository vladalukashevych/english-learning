namespace WinForm.UserControls
{
    partial class UserControlSetChoose
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelWordsCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(22, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(42, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Set";
            this.labelTitle.Click += new System.EventHandler(this.UserControlSetChoose_Click);
            this.labelTitle.MouseEnter += new System.EventHandler(this.UserControlSetChoose_MouseEnter);
            this.labelTitle.MouseLeave += new System.EventHandler(this.UserControlSetChoose_MouseLeave);
            // 
            // labelWordsCount
            // 
            this.labelWordsCount.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWordsCount.ForeColor = System.Drawing.Color.DimGray;
            this.labelWordsCount.Location = new System.Drawing.Point(23, 40);
            this.labelWordsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWordsCount.Name = "labelWordsCount";
            this.labelWordsCount.Size = new System.Drawing.Size(98, 25);
            this.labelWordsCount.TabIndex = 2;
            this.labelWordsCount.Text = "words count";
            this.labelWordsCount.Click += new System.EventHandler(this.UserControlSetChoose_Click);
            this.labelWordsCount.Enter += new System.EventHandler(this.UserControlSetChoose_MouseEnter);
            this.labelWordsCount.Leave += new System.EventHandler(this.UserControlSetChoose_MouseLeave);
            // 
            // UserControlSetChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelWordsCount);
            this.Controls.Add(this.labelTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UserControlSetChoose";
            this.Size = new System.Drawing.Size(217, 74);
            this.Load += new System.EventHandler(this.UserControlSetChoose_Load);
            this.Click += new System.EventHandler(this.UserControlSetChoose_Click);
            this.MouseEnter += new System.EventHandler(this.UserControlSetChoose_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserControlSetChoose_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelWordsCount;
    }
}
