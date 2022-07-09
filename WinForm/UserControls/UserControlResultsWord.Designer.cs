namespace WinForm.UserControls
{
    partial class UserControlResultsWord
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.labelRightAnswer = new System.Windows.Forms.Label();
            this.panelResult = new System.Windows.Forms.Panel();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelTrueFalseDefinition = new System.Windows.Forms.Label();
            this.panelResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(89, 78);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(111, 31);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Question";
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer.Location = new System.Drawing.Point(104, 127);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(75, 28);
            this.labelAnswer.TabIndex = 1;
            this.labelAnswer.Text = "Answer";
            // 
            // labelRightAnswer
            // 
            this.labelRightAnswer.AutoSize = true;
            this.labelRightAnswer.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRightAnswer.ForeColor = System.Drawing.Color.Green;
            this.labelRightAnswer.Location = new System.Drawing.Point(83, 274);
            this.labelRightAnswer.Name = "labelRightAnswer";
            this.labelRightAnswer.Size = new System.Drawing.Size(122, 28);
            this.labelRightAnswer.TabIndex = 2;
            this.labelRightAnswer.Text = "RightAnswer";
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.LightGray;
            this.panelResult.Controls.Add(this.labelResult);
            this.panelResult.Location = new System.Drawing.Point(37, 314);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(217, 49);
            this.panelResult.TabIndex = 3;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(68, 14);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(75, 22);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Skipped";
            // 
            // labelTrueFalseDefinition
            // 
            this.labelTrueFalseDefinition.AutoSize = true;
            this.labelTrueFalseDefinition.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrueFalseDefinition.Location = new System.Drawing.Point(61, 173);
            this.labelTrueFalseDefinition.Name = "labelTrueFalseDefinition";
            this.labelTrueFalseDefinition.Size = new System.Drawing.Size(179, 28);
            this.labelTrueFalseDefinition.TabIndex = 4;
            this.labelTrueFalseDefinition.Text = "TrueFalseDefinition";
            // 
            // UserControlResultsWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelTrueFalseDefinition);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.labelRightAnswer);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.labelQuestion);
            this.Name = "UserControlResultsWord";
            this.Size = new System.Drawing.Size(296, 396);
            this.Load += new System.EventHandler(this.UserControlResultsWord_Load);
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Label labelRightAnswer;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelTrueFalseDefinition;
    }
}
