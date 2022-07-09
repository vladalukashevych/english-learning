namespace WinForm.Forms
{
    partial class FormTest
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
            this.labelChooseSets = new System.Windows.Forms.Label();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.flpSets = new System.Windows.Forms.FlowLayoutPanel();
            this.labelError = new System.Windows.Forms.Label();
            this.numUpDownQuestionCount = new System.Windows.Forms.NumericUpDown();
            this.labelQuestionCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQuestionCount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChooseSets
            // 
            this.labelChooseSets.AutoSize = true;
            this.labelChooseSets.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseSets.Location = new System.Drawing.Point(43, 31);
            this.labelChooseSets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChooseSets.Name = "labelChooseSets";
            this.labelChooseSets.Size = new System.Drawing.Size(179, 32);
            this.labelChooseSets.TabIndex = 1;
            this.labelChooseSets.Text = "Choose sets:";
            this.labelChooseSets.Visible = false;
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAll.Location = new System.Drawing.Point(1072, 33);
            this.cbAll.Margin = new System.Windows.Forms.Padding(4);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(62, 33);
            this.cbAll.TabIndex = 2;
            this.cbAll.Text = "All";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.Visible = false;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(147)))), ((int)(((byte)(228)))));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(359, 391);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(445, 132);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // flpSets
            // 
            this.flpSets.AutoScroll = true;
            this.flpSets.Location = new System.Drawing.Point(12, 73);
            this.flpSets.Name = "flpSets";
            this.flpSets.Size = new System.Drawing.Size(1137, 160);
            this.flpSets.TabIndex = 8;
            this.flpSets.Visible = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.Location = new System.Drawing.Point(292, 113);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(558, 54);
            this.labelError.TabIndex = 9;
            this.labelError.Text = "Create some sets to start.";
            this.labelError.Visible = false;
            // 
            // numUpDownQuestionCount
            // 
            this.numUpDownQuestionCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDownQuestionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDownQuestionCount.Location = new System.Drawing.Point(240, 251);
            this.numUpDownQuestionCount.Name = "numUpDownQuestionCount";
            this.numUpDownQuestionCount.Size = new System.Drawing.Size(120, 30);
            this.numUpDownQuestionCount.TabIndex = 10;
            this.numUpDownQuestionCount.Visible = false;
            this.numUpDownQuestionCount.ValueChanged += new System.EventHandler(this.numUpDownQuestionCount_ValueChanged);
            // 
            // labelQuestionCount
            // 
            this.labelQuestionCount.AutoSize = true;
            this.labelQuestionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestionCount.Location = new System.Drawing.Point(43, 252);
            this.labelQuestionCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestionCount.Name = "labelQuestionCount";
            this.labelQuestionCount.Size = new System.Drawing.Size(180, 29);
            this.labelQuestionCount.TabIndex = 11;
            this.labelQuestionCount.Text = "Question count:";
            this.labelQuestionCount.Visible = false;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 752);
            this.Controls.Add(this.labelQuestionCount);
            this.Controls.Add(this.numUpDownQuestionCount);
            this.Controls.Add(this.flpSets);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbAll);
            this.Controls.Add(this.labelChooseSets);
            this.Controls.Add(this.labelError);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQuestionCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelChooseSets;
        private System.Windows.Forms.CheckBox cbAll;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.FlowLayoutPanel flpSets;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.NumericUpDown numUpDownQuestionCount;
        private System.Windows.Forms.Label labelQuestionCount;
    }
}