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
    public partial class UserControlDefinitionMatch : UserControlMatchItem
    {
        private readonly FormSetMatch formSetMatch;
        public UserControlDefinitionMatch(FormSetMatch formSetMatch)
        {
            this.formSetMatch = formSetMatch;
            InitializeComponent();
        }

        private void UserControlDefinitionMatch_Load(object sender, EventArgs e)
        {
            labelDefinition.Text = word.Definition;
            Size textSize = TextRenderer.MeasureText(word.Definition, labelDefinition.Font);
            labelDefinition.Location = new Point(this.Location.X + this.Width / 2 - textSize.Width / 2, this.Location.Y + this.Height / 2 - textSize.Height / 2);
        }

        private void UserControlDefinitionMatch_Click(object sender, EventArgs e)
        {
            formSetMatch.UserControlMatch_Click(this, e);
        }

        private void UserControlDefinitionMatch_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void UserControlDefinitionMatch_MouseLeave(object sender, EventArgs e)
        {
            if (formSetMatch.firstClicked != this)
            {
                this.BackColor = Color.White;
            }
        }
    }
}
