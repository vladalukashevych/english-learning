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
    public partial class FormSetMatch : Form
    {
        private readonly IWordsDataAccessor wordsDataAccessor;
        private readonly ISetsDataAccessor setsDataAccessor;
        private readonly Set set;
        private UserControlTermMatch[] terms;
        private UserControlDefinitionMatch[] definitions;
        private Word[] wordsDisplay;
        private int wordCount = 0;
        private int wordsDisplayCount = 9;

        public UserControlMatchItem firstClicked;
        public UserControlMatchItem secondClicked;
        DateTime date;

        public FormSetMatch(FormSet formSet, Set set)
        {
            this.wordsDataAccessor = formSet.wordsDataAccessor;
            this.setsDataAccessor = formSet.setsDataAccessor;
            this.set = set;
            InitializeComponent();
        }
        private void FormSetMatch_Load(object sender, EventArgs e)
        {
            wordCount = setsDataAccessor.WordsCountInSet(set.Id);
            if (wordCount < 2)
            {
                btnStart.Hide();
                labelTimerName.Hide();
                labelError.ForeColor = Color.Black;
                labelError.Show();
                return;
            }
            btnStart.Show();
            flpGame.Hide();
            labelTimer.Hide();
            labelTimerName.Hide();
            labelTimer.Text = "";
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            date = new DateTime(0, 0);
            btnStart.Hide();
            flpGame.Show();
            labelTimer.Show();
            labelTimerName.Show();            
            PopulateWords();
            ControlsRandomDisplay();
            stopwatch.Start();
        }

        private void PopulateWords()
        {            
            if (wordCount < 9) wordsDisplayCount = wordCount;
            List<Word> wordsData = new List<Word>();
            wordsData = wordsDataAccessor.GetWordsFromSet(set.Id);
            terms = new UserControlTermMatch[wordsDisplayCount];
            definitions = new UserControlDefinitionMatch[wordsDisplayCount];
            wordsDisplay = new Word[wordsDisplayCount];
            int[] randomNumbers = new int[wordsDisplayCount];

            randomNumbers = GetUniqueRandomNumbers(randomNumbers);

            for (int i = 0; i < wordsDisplayCount; i++)
            {
                wordsDisplay[i] = new Word();
                wordsDisplay[i] = wordsData[randomNumbers[i]];
            }

            for (int i = 0; i < wordsDisplayCount; i++)
            {
                terms[i] = new UserControlTermMatch(this);
                definitions[i] = new UserControlDefinitionMatch(this);
                terms[i].word = wordsDisplay[i];
                definitions[i].word = wordsDisplay[i];
                flpGame.Controls.Add(terms[i]);
                flpGame.Controls.Add(definitions[i]);
            }
        }

        private int[] GetUniqueRandomNumbers(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length;)
            {
                bool stop = false;
                arr[i] = rand.Next(arr.Length);

                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        stop = true;
                        break;
                    }
                }
                if (!stop)
                    i++;
            }
            return arr;
        }

        private void ControlsRandomDisplay()
        {
            var ctrls = new List<Control>();

            foreach (Control c in flpGame.Controls)
            {
                ctrls.Add(c);
            }

            Random rand = new Random();

            foreach (Control c in ctrls.OrderBy(c => rand.Next()))
            {
                flpGame.Controls.Remove(c);
                flpGame.Controls.Add(c);
            }
        }

        public void UserControlMatch_Click(object sender, EventArgs e)
        {
            if (firstClicked == null)
            {
                if (sender is UserControlTermMatch) firstClicked = sender as UserControlTermMatch;
                if (sender is UserControlDefinitionMatch) firstClicked = sender as UserControlDefinitionMatch;

                firstClicked.BackColor = Color.LightGray;
                return;
            }

            if (sender is UserControlTermMatch) secondClicked = sender as UserControlTermMatch;
            if (sender is UserControlDefinitionMatch) secondClicked = sender as UserControlDefinitionMatch;

            if (firstClicked.word == secondClicked.word)
            {
                flpGame.Controls.Remove(firstClicked);
                flpGame.Controls.Remove(secondClicked);  
            }
            firstClicked.BackColor = Color.White;
            firstClicked = null;
            secondClicked = null;

            if (flpGame.Controls.Count == 0) EndGame();
        }

        private void stopwatch_Tick(object sender, EventArgs e)
        {
            date = date.AddMilliseconds(173);
            labelTimer.Text = date.ToString("mm:ss:fff");
            if (date.Minute == 1) EndGame();
        }

        private void EndGame()
        {
            stopwatch.Stop();
            if (date.Minute == 1)
            {
                MessageBox.Show("Your time has run.", "Game is over", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show($"Congratulation, it took you {date.ToString("mm:ss:fff")} to match all words.", "Game is over", MessageBoxButtons.OK);
            }
            FormSetMatch_Load(null, null);
        }
    }
}
