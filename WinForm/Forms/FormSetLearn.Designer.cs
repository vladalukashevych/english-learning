namespace WinForm.Forms
{
    partial class FormSetLearn
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
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.labelWord = new System.Windows.Forms.Label();
            this.panelAnswers = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.panelAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.BackColor = System.Drawing.Color.White;
            this.btnAnswer1.FlatAppearance.BorderSize = 0;
            this.btnAnswer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer1.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer1.ForeColor = System.Drawing.Color.Black;
            this.btnAnswer1.Location = new System.Drawing.Point(10, 6);
            this.btnAnswer1.Margin = new System.Windows.Forms.Padding(5);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(472, 74);
            this.btnAnswer1.TabIndex = 0;
            this.btnAnswer1.Tag = "";
            this.btnAnswer1.Text = "word1";
            this.btnAnswer1.UseVisualStyleBackColor = false;
            this.btnAnswer1.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.BackColor = System.Drawing.Color.White;
            this.btnAnswer4.FlatAppearance.BorderSize = 0;
            this.btnAnswer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer4.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer4.ForeColor = System.Drawing.Color.Black;
            this.btnAnswer4.Location = new System.Drawing.Point(492, 89);
            this.btnAnswer4.Margin = new System.Windows.Forms.Padding(5);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(472, 74);
            this.btnAnswer4.TabIndex = 1;
            this.btnAnswer4.Tag = "";
            this.btnAnswer4.Text = "word4";
            this.btnAnswer4.UseVisualStyleBackColor = false;
            this.btnAnswer4.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.BackColor = System.Drawing.Color.White;
            this.btnAnswer3.FlatAppearance.BorderSize = 0;
            this.btnAnswer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer3.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer3.ForeColor = System.Drawing.Color.Black;
            this.btnAnswer3.Location = new System.Drawing.Point(10, 90);
            this.btnAnswer3.Margin = new System.Windows.Forms.Padding(5);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(472, 74);
            this.btnAnswer3.TabIndex = 2;
            this.btnAnswer3.Tag = "";
            this.btnAnswer3.Text = "word3";
            this.btnAnswer3.UseVisualStyleBackColor = false;
            this.btnAnswer3.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.BackColor = System.Drawing.Color.White;
            this.btnAnswer2.FlatAppearance.BorderSize = 0;
            this.btnAnswer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer2.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer2.ForeColor = System.Drawing.Color.Black;
            this.btnAnswer2.Location = new System.Drawing.Point(492, 5);
            this.btnAnswer2.Margin = new System.Windows.Forms.Padding(5);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(472, 74);
            this.btnAnswer2.TabIndex = 3;
            this.btnAnswer2.Tag = "";
            this.btnAnswer2.Text = "word2";
            this.btnAnswer2.UseVisualStyleBackColor = false;
            this.btnAnswer2.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Leelawadee UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWord.Location = new System.Drawing.Point(92, 220);
            this.labelWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(141, 60);
            this.labelWord.TabIndex = 4;
            this.labelWord.Text = "Word";
            // 
            // panelAnswers
            // 
            this.panelAnswers.Controls.Add(this.btnAnswer1);
            this.panelAnswers.Controls.Add(this.btnAnswer4);
            this.panelAnswers.Controls.Add(this.btnAnswer2);
            this.panelAnswers.Controls.Add(this.btnAnswer3);
            this.panelAnswers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnswers.Location = new System.Drawing.Point(103, 476);
            this.panelAnswers.Margin = new System.Windows.Forms.Padding(4);
            this.panelAnswers.Name = "panelAnswers";
            this.panelAnswers.Size = new System.Drawing.Size(975, 169);
            this.panelAnswers.TabIndex = 5;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.SystemColors.Control;
            this.labelError.Location = new System.Drawing.Point(134, 304);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(847, 54);
            this.labelError.TabIndex = 6;
            this.labelError.Text = "There has to be at least 4 terms to start.";
            this.labelError.Visible = false;
            // 
            // FormSetLearn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 752);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.panelAnswers);
            this.Controls.Add(this.labelWord);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSetLearn";
            this.Padding = new System.Windows.Forms.Padding(53, 49, 53, 49);
            this.Text = "FormLearn";
            this.Load += new System.EventHandler(this.FormSetLearn_Load);
            this.panelAnswers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Panel panelAnswers;
        private System.Windows.Forms.Label labelError;
    }
}