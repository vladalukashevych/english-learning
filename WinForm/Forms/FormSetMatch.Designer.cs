namespace WinForm.Forms
{
    partial class FormSetMatch
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.labelTimerName = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.stopwatch = new System.Windows.Forms.Timer(this.components);
            this.flpGame = new System.Windows.Forms.FlowLayoutPanel();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(147)))), ((int)(((byte)(228)))));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(361, 271);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(445, 132);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labelTimerName
            // 
            this.labelTimerName.AutoSize = true;
            this.labelTimerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelTimerName.Location = new System.Drawing.Point(432, 80);
            this.labelTimerName.Name = "labelTimerName";
            this.labelTimerName.Size = new System.Drawing.Size(119, 39);
            this.labelTimerName.TabIndex = 4;
            this.labelTimerName.Text = "Timer:";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Leelawadee", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(567, 80);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(158, 41);
            this.labelTimer.TabIndex = 5;
            this.labelTimer.Text = "00:11:903";
            this.labelTimer.Visible = false;
            // 
            // stopwatch
            // 
            this.stopwatch.Interval = 173;
            this.stopwatch.Tick += new System.EventHandler(this.stopwatch_Tick);
            // 
            // flpGame
            // 
            this.flpGame.Location = new System.Drawing.Point(148, 184);
            this.flpGame.Margin = new System.Windows.Forms.Padding(116, 4, 116, 4);
            this.flpGame.Name = "flpGame";
            this.flpGame.Size = new System.Drawing.Size(888, 450);
            this.flpGame.TabIndex = 6;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.SystemColors.Control;
            this.labelError.Location = new System.Drawing.Point(134, 304);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(847, 54);
            this.labelError.TabIndex = 7;
            this.labelError.Text = "There has to be at least 4 terms to start.";
            this.labelError.Visible = false;
            // 
            // FormSetMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 752);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelTimerName);
            this.Controls.Add(this.flpGame);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSetMatch";
            this.Text = "FormMatch";
            this.Load += new System.EventHandler(this.FormSetMatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labelTimerName;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Timer stopwatch;
        private System.Windows.Forms.FlowLayoutPanel flpGame;
        private System.Windows.Forms.Label labelError;
    }
}