namespace WinForm.Forms
{
    partial class FormSetEdit
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
            this.btnDone = new System.Windows.Forms.Button();
            this.pbAddButton = new System.Windows.Forms.PictureBox();
            this.panelBorderBottom = new System.Windows.Forms.Panel();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.flpWordsFields = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddButton)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(147)))), ((int)(((byte)(228)))));
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(847, 310);
            this.btnDone.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(268, 71);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // pbAddButton
            // 
            this.pbAddButton.BackColor = System.Drawing.Color.Transparent;
            this.pbAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddButton.Image = global::WinForm.Properties.Resources.plus_filled_42px;
            this.pbAddButton.Location = new System.Drawing.Point(477, 686);
            this.pbAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.pbAddButton.Name = "pbAddButton";
            this.pbAddButton.Size = new System.Drawing.Size(57, 53);
            this.pbAddButton.TabIndex = 11;
            this.pbAddButton.TabStop = false;
            this.pbAddButton.Click += new System.EventHandler(this.pbAddButton_Click);
            // 
            // panelBorderBottom
            // 
            this.panelBorderBottom.BackColor = System.Drawing.Color.Black;
            this.panelBorderBottom.Location = new System.Drawing.Point(211, 71);
            this.panelBorderBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBorderBottom.Name = "panelBorderBottom";
            this.panelBorderBottom.Size = new System.Drawing.Size(563, 2);
            this.panelBorderBottom.TabIndex = 9;
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitle.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.tbTitle.Location = new System.Drawing.Point(211, 31);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(4);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(563, 40);
            this.tbTitle.TabIndex = 10;
            this.tbTitle.Text = "Subject, chapter, uni";
            this.tbTitle.Click += new System.EventHandler(this.tbTitle_Click);
            this.tbTitle.Leave += new System.EventHandler(this.tbTitle_Leave);
            // 
            // flpWordsFields
            // 
            this.flpWordsFields.AutoScroll = true;
            this.flpWordsFields.Location = new System.Drawing.Point(211, 119);
            this.flpWordsFields.Margin = new System.Windows.Forms.Padding(4, 4, 4, 11);
            this.flpWordsFields.Name = "flpWordsFields";
            this.flpWordsFields.Size = new System.Drawing.Size(589, 551);
            this.flpWordsFields.TabIndex = 8;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitle.Location = new System.Drawing.Point(211, 74);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(47, 18);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "TITLE";
            // 
            // FormSetEdit
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSetEdit";
            this.Text = "FormEdit";
            this.Load += new System.EventHandler(this.FormSetEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.PictureBox pbAddButton;
        private System.Windows.Forms.Panel panelBorderBottom;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.FlowLayoutPanel flpWordsFields;
        private System.Windows.Forms.Label labelTitle;
    }
}