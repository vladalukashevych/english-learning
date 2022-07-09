using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.AdditionalClases;
using Business.Entities;
using Business.DataAccessors;

namespace WinForm.Forms
{
    public partial class FormTestMultipleChoises : Form
    {
        private readonly IWordsDataAccessor wordsDataAccessor;
        private readonly FormTest formTest;
        private readonly Word currentWord;
        private TestWord testWord = new TestWord();

        public FormTestMultipleChoises(FormTest formTest, Word currentWord)
        {
            this.formTest = formTest;
            this.wordsDataAccessor = formTest.wordsDataAccessor;
            this.currentWord = currentWord;
            InitializeComponent();
        }

        private void FormTestMultipleChoises_Load(object sender, EventArgs e)
        {
            WordToTestWord.TransferData(currentWord, testWord);
            FillControlsAndLabel();
        }

        private void FillControlsAndLabel()
        {
            List<Word> wordsData = wordsDataAccessor.GetWordsFromSet(currentWord.SetId);
            WordsActions.ShuffleList(wordsData);
            Word[] words = new Word[4];
            for (int i = 0, j = 0; i < 3; i++, j++)
            {
                if (wordsData[i].Id == currentWord.Id) j++;
                words[i] = wordsData[j];
            }
            words[3] = currentWord;
            WordsActions.ShuffleArray(words);

            Random rand = new Random();
            switch (rand.Next(2))
            {
                case 0:
                    TermToGuess(words);
                    break;

                case 1:
                    DefinitionToGuess(words);
                    break;
            }            
        }

        private void DefinitionToGuess(Word[] words)
        {
            testWord.Displayed = "Term";
            labelWord.Text = currentWord.Term;
            btnAnswer1.Text = words[0].Definition;
            btnAnswer2.Text = words[1].Definition;
            btnAnswer3.Text = words[2].Definition;
            btnAnswer4.Text = words[3].Definition;
        }

        private void TermToGuess(Word[] words)
        {
            testWord.Displayed = "Definition";
            labelWord.Text = currentWord.Definition;
            btnAnswer1.Text = words[0].Term;
            btnAnswer2.Text = words[1].Term;
            btnAnswer3.Text = words[2].Term;
            btnAnswer4.Text = words[3].Term;
        }
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            CheckAnswer(sender as Button);           
            formTest.answeredWords.Add(testWord);
            formTest.ShowQuestion();
        }
        private void CheckAnswer(Button btn)
        {
            testWord.Answer = btn.Text;
            if (btn.Text != currentWord.Definition && btn.Text != currentWord.Term)
            {                
                testWord.Correct = false;
                return;
            }
            testWord.Correct = true;
        }
    }
}
