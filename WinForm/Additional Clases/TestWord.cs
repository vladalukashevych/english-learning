using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace WinForm.AdditionalClases
{
    public class TestWord : Word
    {
        public string Answer { get; set; }
        public bool Correct { get; set; }

        private bool skipped = false;
        public bool Skipped
        {
            get { return skipped; }
            set { skipped = value; }
        }

        public string Displayed { get; set; }
        public string TrueFalseDefinition { get; set; }
    }
}
