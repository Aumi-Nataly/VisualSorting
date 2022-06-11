using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAlgorithm
{
    /// <summary>
    /// Родительский класс для сортировок
    /// </summary>
    public class clsSortBase<T>
    {

        /// <summary>
        /// Что нужно отсортировать
        /// </summary>
        public List<T> ArrayForSort {get;set;}


        public clsSortBase(List<T> _ArrayForSort)
        {
            ArrayForSort=_ArrayForSort;
        }

        /// <summary>
        /// Получить результат сортировки.
        /// По умолчанию - сортировка из коробки
        /// </summary>
        public virtual void StartSort()
        {
            ArrayForSort.Sort();
        }

  
        
    }
}
