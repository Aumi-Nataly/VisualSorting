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
    public class clsSortBase<T> where T : IComparable
    {

        /// <summary>
        /// Что нужно отсортировать
        /// </summary>
        protected List<T> ArrayForSort {get;set;}

        /// <summary>
        /// Пошаговая сортировка
        /// </summary>
        public List<string> ArrayStep { get; set; } = new List<string>(); 

        public clsSortBase(List<T> _ArrayForSort)
        {        
            if (_ArrayForSort==null)
            {
                throw new ArgumentNullException(nameof(_ArrayForSort));
            }

            ArrayForSort =_ArrayForSort;
        }

        /// <summary>
        /// Получить результат сортировки.
        /// По умолчанию - сортировка из коробки
        /// </summary>
        public virtual string StartSort()
        {
            ArrayForSort.Sort();
            return String.Join(" ", ArrayForSort);
        }

        
    }
}
