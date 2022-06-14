using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAlgorithm
{
    /// <summary>
    /// Сортировка пузырьком
    /// </summary>
    public class clsBubble<T> : clsSortBase<T> where T : IComparable
    {

        public clsBubble(List<T> _ArrayForSort) : base(_ArrayForSort)
        {
        }


        public override string StartSort()
        {  
            BubbleSort();
            return String.Join(" ", ArrayForSort);
        }


      private void BubbleSort()
        {
            int C = ArrayForSort.Count;

            for (int a = 0; a < C; a++)
            {
                for (int i = 0; i < ArrayForSort.Count - 1 - a; i++)
                {
                    Swap(i, i + 1);
                }
            }
        
        }

      

    }
}
