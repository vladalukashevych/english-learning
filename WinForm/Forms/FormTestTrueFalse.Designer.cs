namespace WinForm.Forms
{
    partial class FormTestTrueFalse
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
            this.panelAnswers = new System.Windows.Forms.Panel();
            this.btnFalse = new System.Windows.Forms.Button();
            this.btnTrue = new System.Windows.Forms.Button();
            this.labelTerm = new System.Windows.Forms.Label();
            this.labelDefinition = new System.Windows.Forms.Label();
            this.panelBorderBottom = new System.Windows.Forms.Panel();
            this.panelAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAnswers
            // 
            this.panelAnswers.Controls.Add(this.btnFalse);
            this.panelAnswers.Controls.Add(this.btnTrue);
            this.panelAnswers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnswers.Location = new System.Drawing.Point(95, 550);
            this.panelAnswers.Margin = new System.Windows.Forms.Padding(4);
            this.panelAnswers.Name = "panelAnswers";
            this.panelAnswers.Size = new System.Drawing.Size(966, 87);
            this.panelAnswers.TabIndex = 9;
            // 
            // btnFalse
            // 
            this.btnFalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFalse.FlatAppearance.BorderSize = 0;
            this.btnFalse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFalse.ForeColor = System.Drawing.Color.Black;
            this.btnFalse.Location = new System.Drawing.Point(487, 5);
            this.btnFalse.Margin = new System.Windows.Forms.Padding(5);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(472, 74);
            this.btnFalse.TabIndex = 1;
            this.btnFalse.Tag = "";
            this.btnFalse.Text = "False";
            this.btnFalse.UseVisualStyleBackColor = false;
            this.btnFalse.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnTrue
            // 
            this.btnTrue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTrue.FlatAppearance.BorderSize = 0;
            this.btnTrue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrue.ForeColor = System.Drawing.Color.Black;
            this.btnTrue.Location = new System.Drawing.Point(5, 5);
            this.btnTrue.Margin = new System.Windows.Forms.Padding(5);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(472, 74);
            this.btnTrue.TabIndex = 2;
            this.btnTrue.Tag = "";
            this.btnTrue.Text = "True";
            this.btnTrue.UseVisualStyleBackColor = false;
            this.btnTrue.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // labelTerm
            // 
            this.labelTerm.AutoSize = true;
            this.labelTerm.Font = new System.Drawing.Font("Leelawadee UI", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTerm.Location = new System.Drawing.Point(486, 175);
            this.labelTerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(179, 85);
            this.labelTerm.TabIndex = 8;
            this.labelTerm.Text = "Term";
            // 
            // labelDefinition
            // 
            this.labelDefinition.AutoSize = true;
            this.labelDefinition.Font = new System.Drawing.Font("Leelawadee UI", 22.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefinition.Location = new System.Drawing.Point(478, 269);
            this.labelDefinition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDefinition.Name = "labelDefinition";
            this.labelDefinition.Size = new System.Drawing.Size(188, 52);
            this.labelDefinition.TabIndex = 10;
            this.labelDefinition.Text = "Definition";
            // 
            // panelBorderBottom
            // 
            this.panelBorderBottom.BackColor = System.Drawing.Color.Black;
            this.panelBorderBottom.Location = new System.Drawing.Point(341, 264);
            this.panelBorderBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBorderBottom.Name = "panelBorderBottom";
            this.panelBorderBottom.Size = new System.Drawing.Size(493, 2);
            this.panelBorderBottom.TabIndex = 11;
            // 
            // FormTestTrueFalse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 752);
            this.Controls.Add(this.panelBorderBottom);
            this.Controls.Add(this.labelDefinition);
            this.Controls.Add(this.panelAnswers);
            this.Controls.Add(this.labelTerm);
            this.Name = "FormTestTrueFalse";
            this.Text = "FormTestTrueFalse";
            this.Load += new System.EventHandler(this.FormTestTrueFalse_Load);
            this.panelAnswers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAnswers;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Label labelTerm;
        private System.Windows.Forms.Label labelDefinition;
        private System.Windows.Forms.Panel panelBorderBottom;
    }
}