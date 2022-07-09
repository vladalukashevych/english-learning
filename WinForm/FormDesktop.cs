using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.DataAccessors;
using WinForm.Forms;

namespace WinForm
{
    public partial class FormDesktop : Form
    {
        public readonly ISetsDataAccessor setsDataAccessor;
        public readonly IWordsDataAccessor wordsDataAccessor;
        private Form activeForm;

        public FormDesktop(ISetsDataAccessor setsDataAccessor, IWordsDataAccessor wordsDataAccessor)
        {
            this.setsDataAccessor = setsDataAccessor;
            this.wordsDataAccessor = wordsDataAccessor;
            InitializeComponent();            
        }

        private void FormDesktop_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FormMain(this));
        }

        internal void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            activeForm = childForm;
        }
    }
}
