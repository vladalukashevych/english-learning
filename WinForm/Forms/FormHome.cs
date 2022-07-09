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
using Business.Entities;


namespace WinForm.Forms
{
    public partial class FormHome : Form
    {
        private readonly ISetsDataAccessor setsDataAccessor;
        private readonly FormDesktop formDesktop;
        private static int setsCount;
        private UserControlSetDisplay[] sets;
        public FormHome(FormDesktop formDesktop)
        {
            this.formDesktop = formDesktop;
            this.setsDataAccessor = formDesktop.setsDataAccessor;
            InitializeComponent();
        }
        
        private void FormHome_Load(object sender, EventArgs e)
        {
            setsCount = setsDataAccessor.SetCount();
            if (setsCount == 0)
            {
                panelSearchBar.Hide();
                flpSets.Hide();
                labelError.Show();
                return;
            }
            PopulateSets();            
        }
        private void PopulateSets()
        {            
            sets = new UserControlSetDisplay[setsCount];
            List<Set> setsDataList = new List<Set>();
            setsDataList = setsDataAccessor.GetSets();
         
            for (int i = 0; i < setsCount; i++)
            {
                sets[i] = new UserControlSetDisplay(formDesktop);
                sets[i].set = setsDataList[i];                
                flpSets.Controls.Add(sets[i]);
            }
        }

        private void pbSearchButton_Click(object sender, EventArgs e)
        {
            if (tbSearchBar.Text != "")
            {
                flpSets.Controls.Clear();
                for (int i = 0; i < setsCount; i++)
                {
                    if (sets[i].set.Title.ToLower().Contains(tbSearchBar.Text.ToLower()))
                    {
                        flpSets.Controls.Add(sets[i]);
                    }
                }
            }           
        }

        private void tbSearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pbSearchButton_Click(sender, e);
            }
        }

        private void tbSearchBar_Click(object sender, EventArgs e)
        {
            if (tbSearchBar.Text == "Search")
            { 
                tbSearchBar.Text = "";
                tbSearchBar.ForeColor = Color.Black;
            }
        }

        private void tbSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchBar.Text == "")
            {
                if (flpSets.Controls.Count != setsCount)
                {
                    for (int i = 0; i < setsCount; i++)
                    {
                        flpSets.Controls.Add(sets[i]);
                    }
                }
                tbSearchBar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }
        }
    }
}
