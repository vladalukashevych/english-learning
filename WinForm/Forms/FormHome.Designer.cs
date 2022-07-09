namespace WinForm.Forms
{
    partial class FormHome
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
            this.tbSearchBar = new System.Windows.Forms.TextBox();
            this.flpSets = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSearchBar = new System.Windows.Forms.Panel();
            this.pbSearchButton = new System.Windows.Forms.PictureBox();
            this.labelError = new System.Windows.Forms.Label();
            this.panelSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchButton)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearchBar
            // 
            this.tbSearchBar.BackColor = System.Drawing.SystemColors.Window;
            this.tbSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchBar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbSearchBar.Location = new System.Drawing.Point(19, 16);
            this.tbSearchBar.Margin = new System.Windows.Forms.Padding(0);
            this.tbSearchBar.Name = "tbSearchBar";
            this.tbSearchBar.Size = new System.Drawing.Size(461, 19);
            this.tbSearchBar.TabIndex = 0;
            this.tbSearchBar.Text = "Search";
            this.tbSearchBar.Click += new System.EventHandler(this.tbSearchBar_Click);
            this.tbSearchBar.TextChanged += new System.EventHandler(this.tbSearchBar_TextChanged);
            this.tbSearchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchBar_KeyDown);
            // 
            // flpSets
            // 
            this.flpSets.AutoScroll = true;
            this.flpSets.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpSets.Location = new System.Drawing.Point(55, 129);
            this.flpSets.Margin = new System.Windows.Forms.Padding(0);
            this.flpSets.Name = "flpSets";
            this.flpSets.Size = new System.Drawing.Size(1051, 586);
            this.flpSets.TabIndex = 2;
            // 
            // panelSearchBar
            // 
            this.panelSearchBar.BackColor = System.Drawing.Color.White;
            this.panelSearchBar.Controls.Add(this.pbSearchButton);
            this.panelSearchBar.Controls.Add(this.tbSearchBar);
            this.panelSearchBar.Location = new System.Drawing.Point(311, 28);
            this.panelSearchBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelSearchBar.Name = "panelSearchBar";
            this.panelSearchBar.Size = new System.Drawing.Size(540, 49);
            this.panelSearchBar.TabIndex = 3;
            // 
            // pbSearchButton
            // 
            this.pbSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearchButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbSearchButton.Image = global::WinForm.Properties.Resources.search_32px;
            this.pbSearchButton.Location = new System.Drawing.Point(487, 0);
            this.pbSearchButton.Margin = new System.Windows.Forms.Padding(0);
            this.pbSearchButton.Name = "pbSearchButton";
            this.pbSearchButton.Padding = new System.Windows.Forms.Padding(5);
            this.pbSearchButton.Size = new System.Drawing.Size(53, 49);
            this.pbSearchButton.TabIndex = 1;
            this.pbSearchButton.TabStop = false;
            this.pbSearchButton.Click += new System.EventHandler(this.pbSearchButton_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.Location = new System.Drawing.Point(157, 349);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(847, 54);
            this.labelError.TabIndex = 7;
            this.labelError.Text = "There has to be at least 4 terms to start.";
            this.labelError.Visible = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1161, 752);
            this.Controls.Add(this.panelSearchBar);
            this.Controls.Add(this.flpSets);
            this.Controls.Add(this.labelError);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHome";
            this.Padding = new System.Windows.Forms.Padding(55, 12, 55, 37);
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.panelSearchBar.ResumeLayout(false);
            this.panelSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearchBar;
        private System.Windows.Forms.FlowLayoutPanel flpSets;
        private System.Windows.Forms.Panel panelSearchBar;
        private System.Windows.Forms.PictureBox pbSearchButton;
        private System.Windows.Forms.Label labelError;
    }
}