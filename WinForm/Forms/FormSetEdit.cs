using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.DataAccessors;
using WinForm.UserControls;

namespace WinForm.Forms
{
    public partial class FormSetEdit : Form
    {
        private readonly ISetsDataAccessor setsDataAccessor;
        private readonly IWordsDataAccessor wordsDataAccessor;
        private readonly FormDesktop formDesktop;
        private readonly Set set;
        private int wordCount;
        private UserControlWordField[] words;
        public FormSetEdit(FormDesktop formDesktop, Set set)
        {
            this.formDesktop = formDesktop;
            this.setsDataAccessor = formDesktop.setsDataAccessor;
            this.wordsDataAccessor = formDesktop.wordsDataAccessor;
            this.set = set;
            InitializeComponent();
        }
        private void FormSetEdit_Load(object sender, EventArgs e)
        {
            PopulateWordsAndTitle();
        }

        private void PopulateWordsAndTitle()
        { 
            wordCount = setsDataAccessor.WordsCountInSet(set.Id);
            words = new UserControlWordField[100];
            List<Word> wordsDataList = new List<Word>();
            wordsDataList = wordsDataAccessor.GetWordsFromSet(set.Id);
            tbTitle.Text = set.Title;
            tbTitle.ForeColor = Color.Black;
            for (int i = 0; i < wordCount; i++)
            {
                words[i] = new UserControlWordField(this, wordsDataAccessor);
                words[i].Id = wordsDataList[i].Id;
                words[i].Term = wordsDataList[i].Term;
                words[i].Definition = wordsDataList[i].Definition;
                flpWordsFields.Controls.Add(words[i]);
            }
        }

        private void tbTitle_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text == "Subject, chapter, uni")
            {
                tbTitle.Text = "";
                tbTitle.ForeColor = Color.Black;
            }
        }

        private void tbTitle_Leave(object sender, EventArgs e)
        {
            if (tbTitle.Text == "")
            {
                tbTitle.Text = "Subject, chapter, uni";
                tbTitle.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void pbAddButton_Click(object sender, EventArgs e)
        {
            if (wordCount == 100)
                MessageBox.Show("Maximum count of terms in set is 100", "Count error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else           
                AddWordField();            
        }

        private void AddWordField()
        {
            words[++wordCount - 1] = new UserControlWordField(this, wordsDataAccessor);
            words[wordCount - 1].Id = 0;
            flpWordsFields.Controls.Add(words[wordCount - 1]);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text != "Subject, chapter, uni" && tbTitle.Text != "")
            {
                List<Set> sets = new List<Set>();
                sets = setsDataAccessor.GetSets();
                int setCount = setsDataAccessor.SetCount();
                bool error = false;
                for (int i = 0; i < setCount; i++)
                {

                    if (tbTitle.Text == sets[i].Title && tbTitle.Text != set.Title)
                    {
                        error = true;
                        MessageBox.Show("Set with this title already exists", "Title error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (!error)
                {
                    set.Title = tbTitle.Text;
                    setsDataAccessor.EditSet(set);
                    Word[] newWords = new Word[wordCount];
                    for (int i = 0; i < wordCount; i++)
                    {
                        newWords[i] = new Word();
                        newWords[i].Id = words[i].Id;
                        newWords[i].Term = words[i].Term;
                        newWords[i].Definition = words[i].Definition;
                        newWords[i].SetId = set.Id;
                        if (newWords[i].Term != "" && newWords[i].Definition != "")
                        {
                            if (words[i].Id == 0) 
                                wordsDataAccessor.CreateWord(newWords[i]);
                            else 
                                wordsDataAccessor.EditWord(newWords[i]);
                            
                        }
                    }
                }
                formDesktop.OpenChildForm(new FormSet(formDesktop, set));
            }

        }
    }
}
