namespace WinForm.Forms
{
    partial class FormTestResults
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
            this.flpWords = new System.Windows.Forms.FlowLayoutPanel();
            this.labelResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpWords
            // 
            this.flpWords.AutoScroll = true;
            this.flpWords.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpWords.Location = new System.Drawing.Point(29, 175);
            this.flpWords.Name = "flpWords";
            this.flpWords.Size = new System.Drawing.Size(1120, 424);
            this.flpWords.TabIndex = 0;
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Leelawadee UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResults.Location = new System.Drawing.Point(473, 58);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(184, 62);
            this.labelResults.TabIndex = 1;
            this.labelResults.Text = "Results";
            // 
            // FormTestResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 752);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.flpWords);
            this.Name = "FormTestResults";
            this.Text = "FormTestResults";
            this.Load += new System.EventHandler(this.FormTestResults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpWords;
        private System.Windows.Forms.Label labelResults;
    }
}