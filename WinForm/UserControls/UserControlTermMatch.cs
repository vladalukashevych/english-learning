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
using WinForm.Forms;

namespace WinForm.UserControls
{
    public partial class UserControlTermMatch : UserControlMatchItem
    {
        private readonly FormSetMatch formSetMatch;
        public UserControlTermMatch(FormSetMatch formSetMatch)
        {
            this.formSetMatch = formSetMatch;   
            InitializeComponent();
        }

        private void UserControlTermMatch_Load(object sender, EventArgs e)
        {
            labelTerm.Text = word.Term;
            Size textSize = TextRenderer.MeasureText(word.Term, labelTerm.Font);
            labelTerm.Location = new Point(this.Location.X + this.Width / 2 - textSize.Width / 2, this.Location.Y + this.Height / 2 - textSize.Height / 2);
        }

        private void UserControlTermMatch_Click(object sender, EventArgs e)
        {         
            formSetMatch.UserControlMatch_Click(this, e);
        }

        private void UserControlTermMatch_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void UserControlTermMatch_MouseLeave(object sender, EventArgs e)
        {
            if (formSetMatch.firstClicked != this)
            {
                this.BackColor = Color.White;
            }
        }

    }
}
