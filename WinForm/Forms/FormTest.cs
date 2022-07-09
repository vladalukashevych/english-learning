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
using WinForm.AdditionalClases;

namespace WinForm.Forms
{
    public partial class FormTest : Form
    {
        internal readonly IWordsDataAccessor wordsDataAccessor;
        internal readonly ISetsDataAccessor setsDataAccessor;
        internal readonly FormMain formMain;
        private List<Set> chosenSets = new List<Set>();
        private UserControlSetChoose[] setsDisplay;
        internal List<TestWord> answeredWords = new List<TestWord>();
        private List<Word> allWords = new List<Word>();
        internal List<Word> displayWords = new List<Word>();
        internal int currentQuestionIndex = 0;
        private int wordCountFromChoosenSets = 0;
        private int questionCount = 0;
        private Form activeForm;
        int setsCount;

        internal FormTest(FormMain formMain)
        {
            this.formMain = formMain;
            this.wordsDataAccessor = formMain.wordsDataAccessor;
            this.setsDataAccessor = formMain.setsDataAccessor;
            InitializeComponent();
        }
        internal void FormTest_Load(object sender, EventArgs e)
        {
            setsCount = setsDataAccessor.SetCount();
            if (setsCount == 0)
            {                
                labelError.Show();
                return;
            }
            labelChooseSets.Show();
            cbAll.Show();
            btnStart.Show();
            flpSets.Show();
            numUpDownQuestionCount.Show();
            labelQuestionCount.Show();
            PopulateSetFields();
        }

        private void PopulateSetFields()
        {                      
            setsDisplay = new UserControlSetChoose[setsCount];
            List<Set> setsData = setsDataAccessor.GetSets();

            for (int i = 0; i < setsCount; i++)
            {
                setsDisplay[i] = new UserControlSetChoose(this);
                setsDisplay[i].set = setsData[i];
                flpSets.Controls.Add(setsDisplay[i]);
            }
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (wordCountFromChoosenSets < questionCount)
            {
                MessageBox.Show($"Term count in sets chosen is less than {questionCount}, please choose more.", "Count error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chosenSets.Count == 0)
            {
                MessageBox.Show("Choose at least one set to start.", "Count error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GetTestWords();
            ShowQuestion();
        }

        private void GetTestWords()
        {
            for (int i = 0; i < chosenSets.Count; i++)
            {
                List<Word> wordsDataList = new List<Word>();
                wordsDataList = wordsDataAccessor.GetWordsFromSet(chosenSets[i].Id);
                for (int j = 0; j < wordsDataList.Count; j++)
                {
                    allWords.Add(wordsDataList[j]);
                }
            }
            WordsActions.ShuffleList(allWords);

            for (int i = 0; i < questionCount; i++)
            {
                displayWords.Add(allWords[i]);                
            }
        }

        internal void UserControlSetChoose_Click(object sender, EventArgs e)
        {
            var set = sender as UserControlSetChoose;
            if (set.chosen)
            { 
                chosenSets.Add(set.set);
                wordCountFromChoosenSets += setsDataAccessor.WordsCountInSet(set.set.Id);
            }
            else
            { 
                chosenSets.Remove(set.set);
                wordCountFromChoosenSets -= setsDataAccessor.WordsCountInSet(set.set.Id);
            }
        }

        internal void ShowQuestion()
        {
            if (currentQuestionIndex == questionCount)
            {
                OpenChildForm(new FormTestResults(this, answeredWords));
                return;
            }
            Form childForm = new Form();
            Random rand = new Random();
            switch (rand.Next(3))
            {
                case 0:
                    childForm = new FormTestTrueFalse(this, displayWords[currentQuestionIndex++]);
                    break;

                case 1:
                    childForm = new FormTestMultipleChoises(this, displayWords[currentQuestionIndex++]);
                    break;

                case 2:
                    childForm = new FormTestWritten(this, displayWords[currentQuestionIndex++]);
                    break;
            }

            OpenChildForm(childForm);
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            activeForm = childForm;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < setsDisplay.Count(); i++)
            {
                if (setsDisplay[i].wordsCount < 4)
                    continue;
                if (cbAll.Checked == setsDisplay[i].chosen)
                    continue;
                setsDisplay[i].UserControlSetChooseForAll();
            }
            if (cbAll.Checked) numUpDownQuestionCount.Value = 20;
        }

        private void numUpDownQuestionCount_ValueChanged(object sender, EventArgs e)
        {
            var numeric = sender as NumericUpDown;
            if (numeric.Value > wordCountFromChoosenSets)
            {
                MessageBox.Show("There can not be more questions than all terms from sets chosen.", "Count error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            questionCount = (Int32)numeric.Value;
        }
    }
}
