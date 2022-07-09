namespace WinForm.UserControls
{
    partial class UserControlDefinitionMatch
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
            this.labelDefinition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDefinition
            // 
            this.labelDefinition.AutoSize = true;
            this.labelDefinition.Font = new System.Drawing.Font("Leelawadee UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefinition.Location = new System.Drawing.Point(73, 16);
            this.labelDefinition.Name = "labelDefinition";
            this.labelDefinition.Size = new System.Drawing.Size(141, 40);
            this.labelDefinition.TabIndex = 1;
            this.labelDefinition.Text = "Definition";
            this.labelDefinition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDefinition.Click += new System.EventHandler(this.UserControlDefinitionMatch_Click);
            this.labelDefinition.MouseEnter += new System.EventHandler(this.UserControlDefinitionMatch_MouseEnter);
            this.labelDefinition.MouseLeave += new System.EventHandler(this.UserControlDefinitionMatch_MouseLeave);
            // 
            // UserControlDefinitionMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelDefinition);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlDefinitionMatch";
            this.Size = new System.Drawing.Size(291, 70);
            this.Load += new System.EventHandler(this.UserControlDefinitionMatch_Load);
            this.Click += new System.EventHandler(this.UserControlDefinitionMatch_Click);
            this.MouseEnter += new System.EventHandler(this.UserControlDefinitionMatch_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserControlDefinitionMatch_MouseLeave);
            this.Controls.SetChildIndex(this.labelDefinition, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDefinition;
    }
}
