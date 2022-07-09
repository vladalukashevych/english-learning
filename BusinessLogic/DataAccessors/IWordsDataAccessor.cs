using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Business.DataAccessors
{
    public interface IWordsDataAccessor
    {
        List<Word> GetWordsFromSet(int id);
        Word GetWordById(int id);
        void CreateWord(Word word);
        void EditWord(Word word);
        void DeleteWord(int id);
    }
}
