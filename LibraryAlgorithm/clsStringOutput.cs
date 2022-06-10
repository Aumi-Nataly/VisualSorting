using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAlgorithm
{
    /// <summary>
    /// Превращение массива в строку для вывода
    /// </summary>
    public class clsStringOutput<T>
    {
        /// <summary>
        /// Вернуть строку из списка
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public string OneStr(List<T> arr)
        {
            return String.Join(" ",arr);

        }
    }
}
