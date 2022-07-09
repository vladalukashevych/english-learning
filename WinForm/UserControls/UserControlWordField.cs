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
using Business.DataAccessors;

namespace WinForm.UserControls
{
    public partial class UserControlWordField : UserControl
    {
        private readonly Form currentForm;
        private readonly IWordsDataAccessor wordsDataAccessor;
        #region Properties
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string term;
        public string Term
        {
            get { return tbTerm.Text; }
            set { term = value; tbTerm.Text = term; }
        }
        
        private string definition;
        public string Definition
        {
            get { return tbDefinition.Text; }
            set { definition = value; tbDefinition.Text = definition; }
        }
        #endregion

        public UserControlWordField(Form currentForm, IWordsDataAccessor wordsDataAccessor)
        {
            this.currentForm = currentForm;
            this.wordsDataAccessor = wordsDataAccessor;
            InitializeComponent();
        }

        private void pbCloseButton_Click(object sender, EventArgs e)
        {
            if (currentForm is FormSetEdit && Id != 0)
            {
                wordsDataAccessor.DeleteWord(Id);
                this.Hide();
            }
            else
            {
                Term = "";
                Definition = "";
                this.Hide();
            }
        }
    }
}
