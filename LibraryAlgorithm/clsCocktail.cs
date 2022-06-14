using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAlgorithm
{
    /// <summary>
    /// Шейкерная сортировка
    /// </summary>
    public class clsCocktail<T> : clsSortBase<T> where T : IComparable
    {
        public clsCocktail(List<T> _ArrayForSort) : base(_ArrayForSort)
        {
        }


        public override string StartSort()
        {
            StepAdd();
            StepAddTable(-1, -1);
            CocktailSort();
            return String.Join(" ", ArrayForSort);
        }


        private void CocktailSort()
        {
            //индексы крайних элементов
            int left = 0;
            int right = ArrayForSort.Count-1;

            while (left < right)
            {
                GoRight(left, right);               
                right--;

                GoLeft(right, left);            
                left++;
            }

        }

        /// <summary>
        /// Движение направо. Поднимаем максимальный элемент
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        void GoRight(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                Swap(i, i + 1);
            }
            
        }

        /// <summary>
        /// Движение налево. Опускаем минимальный элемент
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        void GoLeft(int start, int end)
        {
            for (int i = start; i > end; i--)
            {
                Swap( i - 1, i);
            }

        }
    }
}
