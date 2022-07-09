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

namespace WinForm.Forms
{
    public partial class FormMain : Form
    {
        internal readonly ISetsDataAccessor setsDataAccessor;
        internal readonly IWordsDataAccessor wordsDataAccessor;
        internal readonly FormDesktop formDesktop;
        private Button currentButton;
        private Form activeForm;

        public FormMain(FormDesktop formDesktop)
        {
            this.formDesktop = formDesktop;
            this.setsDataAccessor = formDesktop.setsDataAccessor;
            this.wordsDataAccessor = formDesktop.wordsDataAccessor;
            InitializeComponent();
           
        }
        internal void FormMain_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FormHome(formDesktop), btnHome);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    currentButton.BackColor = Color.FromArgb(127, 122, 203);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(152, 147, 228);
                    previousBtn.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        internal void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;           
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;            
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHome(formDesktop), sender);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAdd(this), sender);
        }

        public void btnTest_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTest(this), sender);
        }

    }
}
