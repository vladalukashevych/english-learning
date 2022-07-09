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
using WinForm.AdditionalClases;

namespace WinForm.Forms
{
    public partial class FormSetLearn : Form
    {
        private readonly IWordsDataAccessor wordsDataAccessor;
        private readonly ISetsDataAccessor setsDataAccessor;
        private readonly Set set;
        private Word[] words;
        private int wordCount;

        private Word currentWord;
        private int currentWordIndex = 0;
        private Random rand = new Random();
        private Word[] displayWords = new Word[4];
        

        public FormSetLearn(FormSet formSet, Set set)
        {
            this.wordsDataAccessor = formSet.wordsDataAccessor;
            this.setsDataAccessor = formSet.setsDataAccessor;
            this.set = set;
            LoadData();
            InitializeComponent();
        }


        private void FormSetLearn_Load(object sender, EventArgs e)
        {   
            wordCount = setsDataAccessor.WordsCountInSet(set.Id);
            if (wordCount < 4)
            {
                panelAnswers.Hide();
                labelWord.Hide();
                labelError.ForeColor = Color.Black;
                labelError.Show();
                return;
            }           
            LoadData();
            WordsActions.ShuffleArray(words);
            if (currentWordIndex >= wordCount - 1 - 2)
            {
                currentWordIndex = 0;
                if (words[currentWordIndex] == currentWord)
                    currentWordIndex++;
            }
            FillControlsAndLabel();
        }

        private void LoadData()
        {
            List<Word> wordsData = new List<Word>();
            wordsData = wordsDataAccessor.GetWordsFromSet(set.Id);
            words = new Word[wordCount];
            for (int i = 0; i < wordCount; i++)
            {
                words[i] = new Word();
                words[i] = wordsData[i];
            }        
        }

        private void FillControlsAndLabel()
        {
            currentWord = words[currentWordIndex];
            labelWord.Text = currentWord.Term;

            for (int i = 0; i < 4; i++)
            {
                displayWords[i] = words[currentWordIndex + i];
            }
            WordsActions.ShuffleArray(displayWords);            

            btnAnswer1.Text = displayWords[0].Definition;
            btnAnswer2.Text = displayWords[1].Definition;
            btnAnswer3.Text = displayWords[2].Definition;
            btnAnswer4.Text = displayWords[3].Definition;

            currentWordIndex += 3;
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            CheckOnAnswer(sender as Button);
            FormSetLearn_Load(null, null);
        }

        private void CheckOnAnswer(Button btn)
        {
            if (btn.Text != currentWord.Definition)
            {
                string message = $"Correct answer is {currentWord.Definition}.";
                MessageBox.Show(message, "Incorrect");
            }
        }

    }
}
