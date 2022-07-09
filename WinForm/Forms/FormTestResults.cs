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
using WinForm.UserControls;

namespace WinForm.Forms
{
    public partial class FormTestResults : Form
    {
        private readonly FormTest formTest;
        private readonly List<TestWord> words;
        private UserControlResultsWord[] resultsWords;

        public FormTestResults(FormTest formTest, List<TestWord> words)
        {
            this.formTest = formTest;
            this.words = words;
            InitializeComponent();
        }
        private void FormTestResults_Load(object sender, EventArgs e)
        {
            resultsWords = new UserControlResultsWord[words.Count];
            for (int i = 0; i < words.Count; i++)
            {
                resultsWords[i] = new UserControlResultsWord(words[i]);
                flpWords.Controls.Add(resultsWords[i]);
            }
        }

    }
}
