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

namespace WinForm.UserControls
{
    public partial class UserControlWordDisplay : UserControl
    {
        public Word word;
        public UserControlWordDisplay()
        {
            InitializeComponent();
        }

        private void UserControlWordDisplay_Load(object sender, EventArgs e)
        {
            labelTerm.Text = word.Term;
            labelDefinition.Text = word.Definition;
        }
    }
}
