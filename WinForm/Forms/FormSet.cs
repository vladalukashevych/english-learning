using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using Business.DataAccessors;
using WinForm.UserControls;
using Business.Entities;

namespace WinForm.Forms
{
    public partial class FormSet : Form
    {
        internal readonly ISetsDataAccessor setsDataAccessor;
        internal readonly IWordsDataAccessor wordsDataAccessor;
        private readonly FormDesktop formDesktop;
        private Button currentButton;
        private Form activeForm;        
        private readonly Set set;
        private int wordCount;
        private UserControlWordDisplay[] wordsList;
        public FormSet(FormDesktop formDesktop, Set set)
        {
            this.formDesktop = formDesktop;
            this.setsDataAccessor = formDesktop.setsDataAccessor;
            this.wordsDataAccessor = formDesktop.wordsDataAccessor;
            this.set = set;
            InitializeComponent();
        }        
        private void FormSet_Load(object sender, EventArgs e)
        {
            PopulateWords();
            Size textSize = TextRenderer.MeasureText(set.Title, labelTitle.Font);
            labelTitle.Location = new Point(panelDisplay.Width / 2 - textSize.Width / 2, 101);
            labelTitle.Text = set.Title;
        }
        private void PopulateWords()
        {
            wordCount = setsDataAccessor.WordsCountInSet(set.Id);
            wordsList = new UserControlWordDisplay[wordCount];
            List<Word> wordsListData = wordsDataAccessor.GetWordsFromSet(set.Id);

            for (int i = 0; i < wordsList.Length; i++)
            {
                wordsList[i] = new UserControlWordDisplay();
                wordsList[i].word = wordsListData[i];
                flpWords.Controls.Add(wordsList[i]);
            }
        }
        private void pbSearchButton_Click(object sender, EventArgs e)
        {
            if (tbSearchBar.Text != "")
            {
                flpWords.Controls.Clear();
                for (int i = 0; i < wordCount; i++)
                {
                    if (wordsList[i].word.Term.ToLower().Contains(tbSearchBar.Text.ToLower()))
                    {
                        flpWords.Controls.Add(wordsList[i]);
                    }
                    else if (wordsList[i].word.Definition.ToLower().Contains(tbSearchBar.Text.ToLower()))
                    {
                        flpWords.Controls.Add(wordsList[i]);
                    }
                }
            }
        }
        private void tbSearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pbSearchButton_Click(sender, e);
            }
        }

        private void tbSearchBar_Click(object sender, EventArgs e)
        {
            if (tbSearchBar.Text == "Search")
            {
                tbSearchBar.Text = "";
                tbSearchBar.ForeColor = Color.Black;
            }
        }

        private void tbSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchBar.Text == "")
            {
                if (flpWords.Controls.Count != wordCount)
                {
                    for (int i = 0; i < wordCount; i++)
                    {
                        flpWords.Controls.Add(wordsList[i]);
                    }
                }
                tbSearchBar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    currentButton.BackColor = Color.FromArgb(127, 122, 203);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(152, 147, 228);
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        public void OpenChildForm(Form childForm, object btnSender)
        {
            panelDisplay.Padding = new Padding(0);
            btnDelete.Hide();
            this.panelDisplay.Controls.Clear();
            if (activeForm != null)
                activeForm.Close();
            if (btnSender != null) 
                ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Add(childForm);
            this.panelDisplay.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (activeForm == null)
                formDesktop.OpenChildForm(new FormMain(formDesktop));
            else
                formDesktop.OpenChildForm(new FormSet(formDesktop, set));
        }
        

        private void btnLearn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSetLearn(this, set), sender);
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSetMatch(this, set), sender);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSetEdit(formDesktop, set), sender);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this set?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                setsDataAccessor.DeleteSet(set.Id);
                this.Close();
                formDesktop.OpenChildForm(new FormMain(formDesktop));
            }
        }

    }
}
