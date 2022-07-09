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

namespace WinForm.UserControls
{
    public partial class UserControlResultsWord : UserControl
    {
        private readonly TestWord testWord;
        public UserControlResultsWord(TestWord testWord)
        {
            this.testWord = testWord;
            InitializeComponent();
        }

        private void UserControlResultsWord_Load(object sender, EventArgs e)
        {
            labelTrueFalseDefinition.Hide();
            labelQuestion.Text = testWord.Displayed == "Definition" ? testWord.Definition : testWord.Term;
            string rightAnswer = testWord.Displayed == "Term" ? testWord.Definition : testWord.Term;
            labelRightAnswer.Text = rightAnswer;

            if (testWord.Skipped)
            {
                labelAnswer.Hide();
                panelResult.BackColor = Color.LightGray;
                labelResult.Text = "Skipped";
            }
            else if (testWord.Correct)
            {
                labelAnswer.Text = testWord.Answer;
                labelRightAnswer.Hide();
                if (labelAnswer.Text != "True" && labelAnswer.Text != "False")
                    labelAnswer.ForeColor = Color.Green;
                panelResult.BackColor = Color.FromArgb(192, 255, 192);
                labelResult.Text = "Correct";
            }
            else {
                labelAnswer.Text = testWord.Answer;
                labelAnswer.ForeColor = Color.Red;
                panelResult.BackColor = Color.FromArgb(255, 192, 192);
                labelResult.Text = "Inсorrect";
                if (testWord.Definition == testWord.TrueFalseDefinition)
                {
                    labelRightAnswer.Hide();
                }
                if (labelAnswer.Text == "True" && labelAnswer.Text == "False")
                {
                    labelAnswer.ForeColor = Color.Red;
                    labelAnswer.Font = new Font(labelAnswer.Font, labelAnswer.Font.Style | FontStyle.Italic);
                }
            }

            Size textSize = TextRenderer.MeasureText(labelQuestion.Text, labelQuestion.Font);
            labelQuestion.Location = new Point(this.Location.X + this.Width / 2 - textSize.Width / 2, labelQuestion.Location.Y);
            textSize = TextRenderer.MeasureText(labelAnswer.Text, labelAnswer.Font);
            labelAnswer.Location = new Point(this.Location.X + this.Width / 2 - textSize.Width / 2, labelAnswer.Location.Y);
            textSize = TextRenderer.MeasureText(labelRightAnswer.Text, labelRightAnswer.Font);
            labelRightAnswer.Location = new Point(this.Location.X + this.Width / 2 - textSize.Width / 2, labelRightAnswer.Location.Y);

            if (testWord.Answer == "True" || testWord.Answer == "False")
            {
                labelAnswer.Text = testWord.Answer;
                labelTrueFalseDefinition.Show();
                labelTrueFalseDefinition.Text = testWord.TrueFalseDefinition;
                

                int locationLabelAnswer = labelAnswer.Location.Y;
                labelAnswer.Location = new Point(labelAnswer.Location.X, labelTrueFalseDefinition.Location.Y);
                textSize = TextRenderer.MeasureText(labelTrueFalseDefinition.Text, labelTrueFalseDefinition.Font);
                labelTrueFalseDefinition.Location = new Point(this.Location.X + this.Width / 2 - textSize.Width / 2, locationLabelAnswer);

            }


        }

    }
}
