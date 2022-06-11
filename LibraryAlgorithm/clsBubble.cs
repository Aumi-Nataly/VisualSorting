using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAlgorithm
{
    /// <summary>
    /// Осртировка пузырьком
    /// </summary>
    public class clsBubble<T> : clsSortBase<T>
    {

        public clsBubble(List<T> _ArrayForSort) : base(_ArrayForSort)
        {
        }

        public override void StartSort()
        {
            base.StartSort();
        }
    }
}
