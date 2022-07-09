namespace WinForm.Forms
{
    partial class FormAdd
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.flpWordsFields = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBorderBottom = new System.Windows.Forms.Panel();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.pbAddButton = new System.Windows.Forms.PictureBox();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddButton)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitle.Location = new System.Drawing.Point(209, 76);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(47, 18);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "TITLE";
            // 
            // flpWordsFields
            // 
            this.flpWordsFields.AutoScroll = true;
            this.flpWordsFields.Location = new System.Drawing.Point(209, 122);
            this.flpWordsFields.Margin = new System.Windows.Forms.Padding(4);
            this.flpWordsFields.Name = "flpWordsFields";
            this.flpWordsFields.Size = new System.Drawing.Size(589, 559);
            this.flpWordsFields.TabIndex = 2;
            // 
            // panelBorderBottom
            // 
            this.panelBorderBottom.BackColor = System.Drawing.Color.Black;
            this.panelBorderBottom.Location = new System.Drawing.Point(209, 74);
            this.panelBorderBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBorderBottom.Name = "panelBorderBottom";
            this.panelBorderBottom.Size = new System.Drawing.Size(563, 2);
            this.panelBorderBottom.TabIndex = 3;
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitle.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.tbTitle.Location = new System.Drawing.Point(209, 33);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(4);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(563, 40);
            this.tbTitle.TabIndex = 4;
            this.tbTitle.Text = "Subject, chapter, uni";
            this.tbTitle.Click += new System.EventHandler(this.tbTitle_Click);
            this.tbTitle.Leave += new System.EventHandler(this.tbTitle_Leave);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(147)))), ((int)(((byte)(228)))));
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(845, 313);
            this.btnDone.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(268, 71);
            this.btnDone.TabIndex = 6;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // pbAddButton
            // 
            this.pbAddButton.BackColor = System.Drawing.Color.Transparent;
            this.pbAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddButton.Image = global::WinForm.Properties.Resources.plus_filled_42px;
            this.pbAddButton.Location = new System.Drawing.Point(469, 688);
            this.pbAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.pbAddButton.Name = "pbAddButton";
            this.pbAddButton.Size = new System.Drawing.Size(52, 51);
            this.pbAddButton.TabIndex = 5;
            this.pbAddButton.TabStop = false;
            this.pbAddButton.Click += new System.EventHandler(this.pbAddButton_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.SystemColors.Control;
            this.labelError.Location = new System.Drawing.Point(179, 359);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(746, 54);
            this.labelError.TabIndex = 14;
            this.labelError.Text = "You can not add more that 70 sets.";
            this.labelError.Visible = false;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 752);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.pbAddButton);
            this.Controls.Add(this.panelBorderBottom);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.flpWordsFields);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelError);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.FlowLayoutPanel flpWordsFields;
        private System.Windows.Forms.Panel panelBorderBottom;
        private System.Windows.Forms.TextBox tbTitle;
        private UserControls.UserControlWordField userControlWordsFilling1;
        private UserControls.UserControlWordField userControlWordsFilling2;
        private System.Windows.Forms.PictureBox pbAddButton;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label labelError;
    }
}