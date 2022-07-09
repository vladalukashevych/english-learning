namespace WinForm.Forms
{
    partial class FormSet
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbSearchButton = new System.Windows.Forms.PictureBox();
            this.tbSearchBar = new System.Windows.Forms.TextBox();
            this.flpWords = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu.SuspendLayout();
            this.panelDisplay.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(147)))), ((int)(((byte)(228)))));
            this.panelMenu.Controls.Add(this.btnDelete);
            this.panelMenu.Controls.Add(this.btnEdit);
            this.panelMenu.Controls.Add(this.btnMatch);
            this.panelMenu.Controls.Add(this.btnLearn);
            this.panelMenu.Controls.Add(this.btnBack);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(284, 752);
            this.panelMenu.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Image = global::WinForm.Properties.Resources.delete_40px;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(0, 660);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(284, 92);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Image = global::WinForm.Properties.Resources.edit_60px;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(0, 276);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnEdit.Size = new System.Drawing.Size(284, 92);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnMatch
            // 
            this.btnMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMatch.FlatAppearance.BorderSize = 0;
            this.btnMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatch.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold);
            this.btnMatch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMatch.Image = global::WinForm.Properties.Resources.quiz_64px;
            this.btnMatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatch.Location = new System.Drawing.Point(0, 184);
            this.btnMatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnMatch.Size = new System.Drawing.Size(284, 92);
            this.btnMatch.TabIndex = 3;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // btnLearn
            // 
            this.btnLearn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLearn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLearn.FlatAppearance.BorderSize = 0;
            this.btnLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLearn.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold);
            this.btnLearn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLearn.Image = global::WinForm.Properties.Resources.stars_64px;
            this.btnLearn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLearn.Location = new System.Drawing.Point(0, 92);
            this.btnLearn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnLearn.Size = new System.Drawing.Size(284, 92);
            this.btnLearn.TabIndex = 2;
            this.btnLearn.Text = "Learn";
            this.btnLearn.UseVisualStyleBackColor = true;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Image = global::WinForm.Properties.Resources.arrow_64px;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnBack.Size = new System.Drawing.Size(284, 92);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelDisplay
            // 
            this.panelDisplay.Controls.Add(this.labelTitle);
            this.panelDisplay.Controls.Add(this.panel1);
            this.panelDisplay.Controls.Add(this.flpWords);
            this.panelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplay.Location = new System.Drawing.Point(284, 0);
            this.panelDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Padding = new System.Windows.Forms.Padding(125, 0, 125, 37);
            this.panelDisplay.Size = new System.Drawing.Size(1161, 752);
            this.panelDisplay.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Leelawadee", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(520, 124);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(91, 41);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Title";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pbSearchButton);
            this.panel1.Controls.Add(this.tbSearchBar);
            this.panel1.Location = new System.Drawing.Point(311, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 49);
            this.panel1.TabIndex = 10;
            // 
            // pbSearchButton
            // 
            this.pbSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearchButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbSearchButton.Image = global::WinForm.Properties.Resources.search_32px;
            this.pbSearchButton.Location = new System.Drawing.Point(487, 0);
            this.pbSearchButton.Margin = new System.Windows.Forms.Padding(0);
            this.pbSearchButton.Name = "pbSearchButton";
            this.pbSearchButton.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pbSearchButton.Size = new System.Drawing.Size(53, 49);
            this.pbSearchButton.TabIndex = 1;
            this.pbSearchButton.TabStop = false;
            this.pbSearchButton.Click += new System.EventHandler(this.pbSearchButton_Click);
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
            // flpWords
            // 
            this.flpWords.AutoScroll = true;
            this.flpWords.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpWords.Location = new System.Drawing.Point(125, 189);
            this.flpWords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpWords.Name = "flpWords";
            this.flpWords.Size = new System.Drawing.Size(911, 526);
            this.flpWords.TabIndex = 9;
            // 
            // FormSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 752);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSet";
            this.Text = "FormSet";
            this.Load += new System.EventHandler(this.FormSet_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelDisplay.ResumeLayout(false);
            this.panelDisplay.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbSearchButton;
        private System.Windows.Forms.TextBox tbSearchBar;
        private System.Windows.Forms.FlowLayoutPanel flpWords;
    }
}