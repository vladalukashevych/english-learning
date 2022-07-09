using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace WinForm.AdditionalClases
{
    public class WordToTestWord
    {
        public static void TransferData(Word word, TestWord testWord)
        {
            testWord.Id = word.Id;
            testWord.Term = word.Term;
            testWord.Definition = word.Definition;
            testWord.SetId = word.SetId;
        }
    }
}
