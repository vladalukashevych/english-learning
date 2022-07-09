using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace WinForm.AdditionalClases
{
    public class WordsActions
    {
        
        public static void ShuffleArray(Word[] array)
        {
            Random rand = new Random();
            for (int i = array.Length - 1; i > 0; i--)
            {
                int swapIndex = rand.Next(i + 1);
                Word temp = array[i];
                array[i] = array[swapIndex];
                array[swapIndex] = temp;
            }
        }

        public static void ShuffleList(List<Word> list)
        {
            Random rand = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                Word value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
