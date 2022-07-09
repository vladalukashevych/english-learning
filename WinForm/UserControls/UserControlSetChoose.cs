using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Forms;
using Business.Entities;
using Business.DataAccessors;

namespace WinForm.UserControls
{
    public partial class UserControlSetChoose : UserControl
    {
        private readonly FormTest formTest;
        private readonly ISetsDataAccessor setsDataAccessor;
        public bool chosen = false;
        public Set set;
        public int wordsCount;
        public UserControlSetChoose(FormTest formTest)
        {
            this.formTest = formTest;
            this.setsDataAccessor = formTest.setsDataAccessor;
            InitializeComponent();
        }

        private void UserControlSetChoose_Load(object sender, EventArgs e)
        {
            wordsCount = setsDataAccessor.WordsCountInSet(set.Id);
            labelTitle.Text = set.Title;
            labelWordsCount.Text = wordsCount.ToString() + " terms";
        }
        private void UserControlSetChoose_Click(object sender, EventArgs e)
        {
            if (setsDataAccessor.WordsCountInSet(set.Id) < 4)
            {
                MessageBox.Show("You can not choose set with less than 4 words.", "Sorry");
                return;
            }
            chosen = chosen ? false : true;
            formTest.UserControlSetChoose_Click(this, e);
        }

        public void UserControlSetChooseForAll()
        {
            chosen = chosen ? false : true;
            this.BackColor = chosen ? Color.LightGray : Color.White;
            formTest.UserControlSetChoose_Click(this, null);
        }

        private void UserControlSetChoose_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void UserControlSetChoose_MouseLeave(object sender, EventArgs e)
        {
            if (!chosen)
            {
                this.BackColor = Color.White;
            }
        }
    }
}
