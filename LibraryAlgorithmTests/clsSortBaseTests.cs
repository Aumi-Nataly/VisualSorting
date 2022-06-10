using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAlgorithm.Tests
{
    [TestClass()]
    public class clsSortBaseTests
    {
        [TestMethod()]
        public void StartSortBaseTest()
        {
            List<int> listAnswer = new List<int>() { 1,2,3,4 };

            clsSortBase<int> sort = new clsSortBase<int>();
            sort.ArrayForSort.Add(4);
            sort.ArrayForSort.Add(1);
            sort.ArrayForSort.Add(3);
            sort.ArrayForSort.Add(2);


            sort.StartSort();

            //Сравнить по элементу
            for (int i = 0; i < listAnswer.Count; i++)
            {
                Assert.AreEqual(listAnswer[i], sort.ArrayForSort[i]);
            }
        
        }

        [TestMethod()]
        public void StartSortBubbleTest()
        {
            List<int> listAnswer = new List<int>() { 1, 2, 3, 4 };

            clsSortBase<int> sort = new clsBubble<int>();

            //clsSortBase<int> sort = new clsSortBase<int>();
            sort.ArrayForSort.Add(4);
            sort.ArrayForSort.Add(1);
            sort.ArrayForSort.Add(3);
            sort.ArrayForSort.Add(2);


            sort.StartSort();

            //Сравнить по элементу
            for (int i = 0; i < listAnswer.Count; i++)
            {
                Assert.AreEqual(listAnswer[i], sort.ArrayForSort[i]);
            }

        }
    }
}