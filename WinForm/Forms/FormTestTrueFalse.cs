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
    public partial class FormTestTrueFalse : Form
    {
        private readonly IWordsDataAccessor wordsDataAccessor;
        private readonly FormTest formTest;
        private readonly Word currentWord;
        private TestWord testWord = new TestWord();
        private Word randomWord = new Word();
        private bool correctAnswer;

        public FormTestTrueFalse(FormTest formTest, Word currentWord)
        {
            this.wordsDataAccessor = formTest.wordsDataAccessor;
            this.formTest = formTest;
            this.currentWord = currentWord;
            InitializeComponent();
        }

        private void FormTestTrueFalse_Load(object sender, EventArgs e)
        {
            WordToTestWord.TransferData(currentWord, testWord);
            PopulateLabels();
            LocateLabels();
        }

        private void LocateLabels()
        {
            Size textSize = TextRenderer.MeasureText(labelTerm.Text, labelTerm.Font);
            labelTerm.Location = new Point(this.Location.X + this.Width / 2 - textSize.Width / 2, labelTerm.Location.Y);
            textSize = TextRenderer.MeasureText(labelDefinition.Text, labelDefinition.Font);
            labelDefinition.Location = new Point(this.Location.X + this.Width / 2 - textSize.Width / 2, labelDefinition.Location.Y);
        }

        private void PopulateLabels()
        {
            labelTerm.Text = currentWord.Term;
            testWord.Displayed = "Term";
            Random rand = new Random();
            switch (rand.Next(2))
            {
                case 0: 
                    labelDefinition.Text = currentWord.Definition;
                    correctAnswer = true;
                    testWord.Displayed = "Both";
                    testWord.TrueFalseDefinition = currentWord.Definition;
                    break;

                case 1:
                    randomWord = GetRandomWord(); 
                    labelDefinition.Text = randomWord.Definition;
                    testWord.TrueFalseDefinition = randomWord.Definition;
                    correctAnswer = false;
                    testWord.Displayed = "Term";
                    break;
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            CheckAnswer(sender as Button);
            formTest.answeredWords.Add(testWord);
            formTest.ShowQuestion();
        }

        private void CheckAnswer(Button btn)
        {
            bool answer = true;
            if (btn.Text == "False") answer = false;
            testWord.Answer = answer.ToString();
            if (answer != correctAnswer)
            {
                testWord.Correct = false;
                return;
            }
            testWord.Correct = true;
        }

        private Word GetRandomWord()
        {
            Word word = new Word();
            List <Word> wordsData = wordsDataAccessor.GetWordsFromSet(currentWord.SetId);
            Random rand = new Random();
            do
            {
                word = wordsData[rand.Next(wordsData.Count)];
            } while (word == currentWord);
            return word;
        }
    }
}
