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

namespace WinForm.Forms
{
    public partial class FormTestWritten : Form
    {
        private readonly FormTest formTest;
        private readonly Word currentWord;
        private TestWord testWord = new TestWord();

        public FormTestWritten(FormTest formTest, Word currentWord)
        {
            this.formTest = formTest;
            this.currentWord = currentWord;
            InitializeComponent();
        }
        private void FormTestWritten_Load(object sender, EventArgs e)
        {
            WordToTestWord.TransferData(currentWord, testWord);
            PopulateAndLocateLabel();
        }
        private void PopulateAndLocateLabel()
        {
            labelQuestion.Text = currentWord.Term;
            Random rand = new Random();
            switch (rand.Next(2))
            {
                case 0:
                    labelQuestion.Text = currentWord.Term;
                    testWord.Displayed = "Term";
                    break;

                case 1:
                    labelQuestion.Text = currentWord.Definition;
                    testWord.Displayed = "Definition";
                    break;
            }

            Size textSize = TextRenderer.MeasureText(labelQuestion.Text, labelQuestion.Font);
            labelQuestion.Location = new Point(this.Location.X + this.Width / 2 - textSize.Width / 2, labelQuestion.Location.Y);
        }
        private void tbAnswer_Click(object sender, EventArgs e)
        {
            if (tbAnswer.Text == "Answer")
                tbAnswer.Text = "";
        }

        private void tbAnswer_TextChanged(object sender, EventArgs e)
        {
            btnAction.Text = tbAnswer.Text == "" ? "Skip" : "Answer";
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (tbAnswer.Text == labelQuestion.Text)
                return;
            Button btn = sender as Button;
            if (btn.Text == "Skip")
            {
                testWord.Skipped = true;
            }
            else { 
                testWord.Correct = (tbAnswer.Text.ToLower() == currentWord.Definition.ToLower() || 
                tbAnswer.Text.ToLower() == currentWord.Term.ToLower()) ? true : false;
                testWord.Answer = tbAnswer.Text;
            }
            formTest.answeredWords.Add(testWord);
            formTest.ShowQuestion();
        }

        private void tbAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAction_Click(btnAction, e);
            }
        }
    }
}
