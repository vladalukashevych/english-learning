namespace WinForm.Forms
{
    partial class FormTestWritten
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.panelDeco = new System.Windows.Forms.Panel();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.panelDeco.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Leelawadee UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(513, 214);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(216, 62);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Question";
            // 
            // panelDeco
            // 
            this.panelDeco.BackColor = System.Drawing.Color.White;
            this.panelDeco.Controls.Add(this.tbAnswer);
            this.panelDeco.Location = new System.Drawing.Point(349, 334);
            this.panelDeco.Margin = new System.Windows.Forms.Padding(4);
            this.panelDeco.Name = "panelDeco";
            this.panelDeco.Size = new System.Drawing.Size(501, 72);
            this.panelDeco.TabIndex = 4;
            // 
            // tbAnswer
            // 
            this.tbAnswer.BackColor = System.Drawing.SystemColors.Window;
            this.tbAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAnswer.Font = new System.Drawing.Font("Leelawadee UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnswer.ForeColor = System.Drawing.Color.Black;
            this.tbAnswer.Location = new System.Drawing.Point(19, 16);
            this.tbAnswer.Margin = new System.Windows.Forms.Padding(0);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(461, 44);
            this.tbAnswer.TabIndex = 0;
            this.tbAnswer.Text = "Answer";
            this.tbAnswer.Click += new System.EventHandler(this.tbAnswer_Click);
            this.tbAnswer.TextChanged += new System.EventHandler(this.tbAnswer_TextChanged);
            this.tbAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAnswer_KeyDown);
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(147)))), ((int)(((byte)(228)))));
            this.btnAction.FlatAppearance.BorderSize = 0;
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAction.ForeColor = System.Drawing.Color.White;
            this.btnAction.Location = new System.Drawing.Point(462, 603);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(280, 70);
            this.btnAction.TabIndex = 5;
            this.btnAction.Text = "Skip";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // FormTestWritten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 752);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.panelDeco);
            this.Controls.Add(this.labelQuestion);
            this.Name = "FormTestWritten";
            this.Text = "FormTestWritten";
            this.Load += new System.EventHandler(this.FormTestWritten_Load);
            this.panelDeco.ResumeLayout(false);
            this.panelDeco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Panel panelDeco;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Button btnAction;
    }
}