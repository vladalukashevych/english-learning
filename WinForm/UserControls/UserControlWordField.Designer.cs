namespace WinForm.UserControls
{
    partial class UserControlWordField
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
            this.tbTerm = new System.Windows.Forms.TextBox();
            this.panelBorderBottom = new System.Windows.Forms.Panel();
            this.labelTerm = new System.Windows.Forms.Label();
            this.labelDefinition = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbDefinition = new System.Windows.Forms.TextBox();
            this.pbCloseButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTerm
            // 
            this.tbTerm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTerm.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTerm.Location = new System.Drawing.Point(17, 22);
            this.tbTerm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTerm.Name = "tbTerm";
            this.tbTerm.Size = new System.Drawing.Size(493, 32);
            this.tbTerm.TabIndex = 0;
            // 
            // panelBorderBottom
            // 
            this.panelBorderBottom.BackColor = System.Drawing.Color.Black;
            this.panelBorderBottom.Location = new System.Drawing.Point(17, 55);
            this.panelBorderBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBorderBottom.Name = "panelBorderBottom";
            this.panelBorderBottom.Size = new System.Drawing.Size(493, 2);
            this.panelBorderBottom.TabIndex = 4;
            // 
            // labelTerm
            // 
            this.labelTerm.AutoSize = true;
            this.labelTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTerm.Location = new System.Drawing.Point(13, 62);
            this.labelTerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(42, 15);
            this.labelTerm.TabIndex = 5;
            this.labelTerm.Text = "TERM";
            // 
            // labelDefinition
            // 
            this.labelDefinition.AutoSize = true;
            this.labelDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDefinition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDefinition.Location = new System.Drawing.Point(13, 139);
            this.labelDefinition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDefinition.Name = "labelDefinition";
            this.labelDefinition.Size = new System.Drawing.Size(74, 15);
            this.labelDefinition.TabIndex = 8;
            this.labelDefinition.Text = "DEFINITION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(17, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 2);
            this.panel1.TabIndex = 7;
            // 
            // tbDefinition
            // 
            this.tbDefinition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDefinition.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefinition.Location = new System.Drawing.Point(17, 100);
            this.tbDefinition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDefinition.Name = "tbDefinition";
            this.tbDefinition.Size = new System.Drawing.Size(493, 32);
            this.tbDefinition.TabIndex = 6;
            // 
            // pbCloseButton
            // 
            this.pbCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCloseButton.Image = global::WinForm.Properties.Resources.close_20px;
            this.pbCloseButton.Location = new System.Drawing.Point(528, 7);
            this.pbCloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCloseButton.Name = "pbCloseButton";
            this.pbCloseButton.Size = new System.Drawing.Size(27, 25);
            this.pbCloseButton.TabIndex = 9;
            this.pbCloseButton.TabStop = false;
            this.pbCloseButton.Click += new System.EventHandler(this.pbCloseButton_Click);
            // 
            // UserControlWordField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pbCloseButton);
            this.Controls.Add(this.labelDefinition);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbDefinition);
            this.Controls.Add(this.labelTerm);
            this.Controls.Add(this.panelBorderBottom);
            this.Controls.Add(this.tbTerm);
            this.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.Name = "UserControlWordField";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Size = new System.Drawing.Size(563, 185);
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTerm;
        private System.Windows.Forms.Panel panelBorderBottom;
        private System.Windows.Forms.Label labelTerm;
        private System.Windows.Forms.Label labelDefinition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbDefinition;
        private System.Windows.Forms.PictureBox pbCloseButton;
    }
}
