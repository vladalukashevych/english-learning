namespace WinForm.UserControls
{
    partial class UserControlTermMatch
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
            this.labelTerm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTerm
            // 
            this.labelTerm.AutoSize = true;
            this.labelTerm.Font = new System.Drawing.Font("Leelawadee UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTerm.Location = new System.Drawing.Point(100, 15);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(89, 40);
            this.labelTerm.TabIndex = 0;
            this.labelTerm.Text = "Term";
            this.labelTerm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTerm.Click += new System.EventHandler(this.UserControlTermMatch_Click);
            this.labelTerm.MouseEnter += new System.EventHandler(this.UserControlTermMatch_MouseEnter);
            this.labelTerm.MouseLeave += new System.EventHandler(this.UserControlTermMatch_MouseLeave);
            // 
            // UserControlTermMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelTerm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlTermMatch";
            this.Size = new System.Drawing.Size(291, 70);
            this.Load += new System.EventHandler(this.UserControlTermMatch_Load);
            this.Click += new System.EventHandler(this.UserControlTermMatch_Click);
            this.Controls.SetChildIndex(this.labelTerm, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTerm;
    }
}
