using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAlgorithm;

namespace VisualSorting
{
    public partial class FormViewSort : Form
    {
        public FormViewSort()
        {
            InitializeComponent();
        }

        private void FormViewSort_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// получить введенные данные и отсортировать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGo_Click(object sender, EventArgs e)
        {
            textBoxDefaultAnswer.Clear();
            textBoxResult.Clear();

            string data = textBoxValue.Text;

            if (!Correct(data))
            {
                MessageBox.Show("Введены некорректные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RadioButton radioBtn = this.groupBox1.Controls.OfType<RadioButton>()
                                       .Where(x => x.Checked).FirstOrDefault();

            if (radioBtn == null)
                return;


            List<int> listQuestion = new List<int>() { 1, 2, 3, 4 };

            string[] arr = data.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string str in arr)
            {
                listQuestion.Add(Convert.ToInt32(str));
            }

            clsSortBase<int> clsSort = new clsSortBase<int>(listQuestion);

            switch (radioBtn.Name)
            {
                case "radioButtonBubble":
                    clsSort.StartSort();
                    textBoxDefaultAnswer.Text = new clsStringOutput<int>().OneStr(clsSort.ArrayForSort);

                    break;
            }

        }

        /// <summary>
        /// Проверить введенны данные
        /// </summary>
        /// <returns></returns>
        private bool Correct(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            int myInt;
            string[] nums = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in nums)
            {
                bool isValid = int.TryParse(s, out myInt);

                if (!isValid)
                    return false;
            }

            return true;
        }
    }
}
