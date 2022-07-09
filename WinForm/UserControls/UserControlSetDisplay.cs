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
using WinForm.Forms;

namespace WinForm
{
    public partial class UserControlSetDisplay : UserControl
    {
        private readonly FormDesktop formDesktop;
        private readonly ISetsDataAccessor setsDataAccessor;
        public UserControlSetDisplay(FormDesktop formDesktop)
        {
            this.formDesktop = formDesktop;
            this.setsDataAccessor = formDesktop.setsDataAccessor;
            InitializeComponent();
        }
        public Set set;

        private void UserControlSetDisplay_Load(object sender, EventArgs e)
        {
            labelName.Text = set.Title;
            labelWordsCount.Text = setsDataAccessor.WordsCountInSet(set.Id).ToString() + " terms";
        }

        private void UserControlSetDisplay_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void UserControlSetDisplay_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void UserControlSetDisplay_Click(object sender, EventArgs e)
        {
            formDesktop.OpenChildForm(new FormSet(formDesktop, set));
        }

    }
}
