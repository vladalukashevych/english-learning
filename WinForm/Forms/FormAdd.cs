using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.DataAccessors;
using Business.Entities;
using WinForm.UserControls;

namespace WinForm.Forms
{
    public partial class FormAdd : Form
    {
        private readonly ISetsDataAccessor setsDataAccessor;
        private readonly IWordsDataAccessor wordsDataAccessor;
        private readonly FormMain formMain;
        private static int newWordsCount;
        private UserControlWordField[] newWords;
        public FormAdd(FormMain formMain)
        {
            this.formMain = formMain;
            this.setsDataAccessor = formMain.setsDataAccessor;
            this.wordsDataAccessor = formMain.wordsDataAccessor;
            InitializeComponent();
        }
        private void FormAdd_Load(object sender, EventArgs e)
        {
            int setcount = setsDataAccessor.SetCount();
            if (setcount == 70)
            {
                labelError.ForeColor = Color.Black;
                labelError.Show();
                return;
            }
            SetFormDefault();
        }

        private void SetFormDefault()
        {
            newWordsCount = 2;
            newWords = new UserControlWordField[100];
            flpWordsFields.Controls.Clear();
            tbTitle.Text = "Subject, chapter, uni";
            tbTitle.ForeColor = Color.FromArgb(64, 64, 64);
            for (int i = 0; i < newWordsCount; i++)
            {
                newWords[i] = new UserControlWordField(this, wordsDataAccessor);
                flpWordsFields.Controls.Add(newWords[i]);
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
            if (newWordsCount == 100)
                MessageBox.Show("Maximum count of terms in a set is 100", "Count error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else 
                AddWordField();
        }

        private void AddWordField()
        {
            newWords[++newWordsCount-1] = new UserControlWordField(this, wordsDataAccessor);
            flpWordsFields.Controls.Add(newWords[newWordsCount-1]);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text != "Subject, chapter, uni" && tbTitle.Text != "")
            {
                List<Set> sets = new List<Set>();
                sets = setsDataAccessor.GetSets();
                int setCount = setsDataAccessor.SetCount();
                bool error1 = false;
                bool error2 = false;
                for (int i = 0; i < setCount; i++)
                {
                    if (tbTitle.Text == sets[i].Title)
                    {
                        error1 = true;
                        MessageBox.Show("Set with this title already exists", "Title error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                for (int i = 0; i < newWordsCount; i++)
                {
                    error2 = true;
                    if (newWords[i].Term != "" && newWords[i].Definition !="")
                    {
                        error2 = false;
                        break;
                    }
                }
                if (!error1 && !error2)
                { 
                    Set newSet = new Set();
                    newSet.Title = tbTitle.Text;
                    int setId = setsDataAccessor.CreateSet(newSet);
                    Word[] filledWords = new Word[newWordsCount];
                    for (int i = 0; i < newWordsCount; i++)
                    {
                        filledWords[i] = new Word();
                        filledWords[i].Term = newWords[i].Term;
                        filledWords[i].Definition = newWords[i].Definition;
                        filledWords[i].SetId = setId;
                        if (filledWords[i].Term != "" && filledWords[i].Definition != "")
                        {
                            wordsDataAccessor.CreateWord(filledWords[i]);
                        }
                    }
                    formMain.FormMain_Load(null, null);
                }                
            }
        }
    }
}
