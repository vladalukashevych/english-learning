using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Business.DataAccessors
{
    public interface ISetsDataAccessor
    {
        List<Set> GetSets();
        Set GetSetById(int id);
        int CreateSet(Set set);
        void EditSet(Set set);
        void DeleteSet(int id);
        int SetCount();
        int WordsCountInSet(int id);
    }
}
