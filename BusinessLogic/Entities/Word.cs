using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Word
    {
        public int Id { get; set; }
        public string Term { get; set; }
        public string Definition { get; set; }
        public int SetId { get; set; }
    }
}
