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
            try
            {
                textBoxDefaultAnswer.Clear();
                textBoxResult.Clear();

                string data = textBoxValue.Text;

              
                RadioButton radioBtn = this.groupBox1.Controls.OfType<RadioButton>()
                                           .Where(x => x.Checked).FirstOrDefault();

                if (radioBtn == null)
                    throw new Exception("Не указан тип сортировки");


                List<int> listQuestion = Correct(data);

                clsSortBase<int> clsSort = new clsSortBase<int>(listQuestion);
                clsBubble<int> clsSortBubble = new clsBubble<int>(listQuestion);



                switch (radioBtn.Name)
                {
                    case "radioButtonBubble":
                        textBoxDefaultAnswer.Text = clsSort.StartSort();
                        textBoxResult.Text = clsSortBubble.StartSort();

                        break;
                }
            }
            catch (Exception ex)
            {
                frmError frm = frmError.InstFrm(ex);
                frm.Show();
            }

        }

        /// <summary>
        /// Проверить введенны данные
        /// </summary>
        /// <returns></returns>
        private List<int> Correct(string str)
        {
            try
            {
                if (string.IsNullOrEmpty(str))
                    throw new Exception("Введена пустая строка!");

                List<int> listQuestion = new List<int>();
                int myInt;

                string[] nums = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


                foreach (string s in nums)
                {
                    bool isValid = int.TryParse(s, out myInt);

                    if (!isValid)
                        throw new Exception("Введены некорректные данные!");

                    listQuestion.Add(myInt);
                }

                return listQuestion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDefaultAnswer.Clear();
            textBoxResult.Clear();
            textBoxValue.Clear();
            listBoxResult.Items.Clear();
        }
    }
}
