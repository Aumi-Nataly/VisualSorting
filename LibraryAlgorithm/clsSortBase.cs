using System;
using System.Collections.Generic;
using System.Data;
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
        protected List<T> ArrayForSort { get; set; }

        /// <summary>
        /// Пошаговая сортировка
        /// </summary>
        public List<string> ArrayStep { get; protected set; } = new List<string>();

        public DataTable tableStep;

        public clsSortBase(List<T> _ArrayForSort)
        {
            if (_ArrayForSort == null)
            {
                throw new ArgumentNullException(nameof(_ArrayForSort));
            }

            ArrayForSort = _ArrayForSort;

            CreateTableStep();
        }

        /// <summary>
        /// Создание таблицы для вывода по шагам
        /// </summary>
        private void CreateTableStep()
        {
            tableStep = new DataTable();

            for (int i = 0; i < ArrayForSort.Count; i++)
                tableStep.Columns.Add(i.ToString(), typeof(int));

            tableStep.Columns.Add("index0", typeof(int));
            tableStep.Columns.Add("index1", typeof(int));
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


        /// <summary>
        /// Поменять местами элементы
        /// </summary>
        /// <param name="indexA">индекс 1-ого элемента</param>
        /// <param name="indexB">индекс 2-ого элемента</param>
        protected void Swap(int indexA, int indexB)
        {

            if (ArrayForSort[indexA].CompareTo(ArrayForSort[indexB]) == 1)
            {
                var tmp = ArrayForSort[indexA];
                ArrayForSort[indexA] = ArrayForSort[indexB];
                ArrayForSort[indexB] = tmp;

                StepAdd();
            
            }
            StepAddTable(indexA, indexB);
        }

        /// <summary>
        /// Пошагово записывает историю сортировки
        /// </summary>
        protected void StepAdd()
        {
            ArrayStep.Add(String.Join(" ", ArrayForSort));
        }

        /// <summary>
        /// Пошагово записывает историю сортировкив таблицу
        /// </summary>
        protected void StepAddTable(int indexA, int indexB)
        {
            DataRow row = tableStep.NewRow();
          
            for (int i = 0; i < ArrayForSort.Count; i++)
            {
                row[i.ToString()] = ArrayForSort[i];
            }

            row["index0"] = indexA;
            row["index1"] = indexB;

            tableStep.Rows.Add(row);
        }

    }
}
