using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAlgorithm
{
    /// <summary>
    /// Сортировка вставкой
    /// </summary>
    public class clsInsert<T> : clsSortBase<T> where T : IComparable
    {
        public clsInsert(List<T> _ArrayForSort) : base(_ArrayForSort)
        {
        }
        public override string StartSort()
        {
            StepAdd();
            StepAddTable(-1, -1);
            InsertSort();
            return String.Join(" ", ArrayForSort);
        }

        void InsertSort()
        {
            for (int i = 0; i < ArrayForSort.Count; i++)
            { 
                var tmp=ArrayForSort[i];
                int j = i;

                while (j > 0 && tmp.CompareTo(ArrayForSort[j-1])==-1)
                {
                    ArrayForSort[j] = ArrayForSort[j-1];
                    j--;
                    StepAddTable(j, j - 1);
                    StepAdd();
                }

                ArrayForSort[j]=tmp;

                StepAddTable(j, i);
                StepAdd();
            }
                   
        }

    }
}
