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
            string a = "1 2 3 4";
            List<int> listAnswer = new List<int>() { 4,1,3,2 };
           

            clsSortBase<int> sort = new clsSortBase<int>(listAnswer);

            string result= sort.StartSort();
            Assert.AreEqual(a, result);
        }

        [TestMethod()]
        public void StartSortBubbleTest()
        {
            string a = "1 2 3 4";
            List<int> listAnswer = new List<int>() { 4, 1, 3, 2 };

            clsBubble<int> sort = new clsBubble<int>(listAnswer);

            string result = sort.StartSort();
            Assert.AreEqual(a, result);

        }
    }
}