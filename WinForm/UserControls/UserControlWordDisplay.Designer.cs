namespace WinForm.UserControls
{
    partial class UserControlWordDisplay
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
            this.labelDefinition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTerm
            // 
            this.labelTerm.AutoSize = true;
            this.labelTerm.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTerm.Location = new System.Drawing.Point(23, 11);
            this.labelTerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(69, 32);
            this.labelTerm.TabIndex = 0;
            this.labelTerm.Text = "Term";
            // 
            // labelDefinition
            // 
            this.labelDefinition.AutoSize = true;
            this.labelDefinition.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefinition.Location = new System.Drawing.Point(24, 53);
            this.labelDefinition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDefinition.Name = "labelDefinition";
            this.labelDefinition.Size = new System.Drawing.Size(98, 28);
            this.labelDefinition.TabIndex = 1;
            this.labelDefinition.Text = "Definition";
            // 
            // UserControlWordDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelDefinition);
            this.Controls.Add(this.labelTerm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlWordDisplay";
            this.Size = new System.Drawing.Size(435, 97);
            this.Load += new System.EventHandler(this.UserControlWordDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTerm;
        private System.Windows.Forms.Label labelDefinition;
    }
}
