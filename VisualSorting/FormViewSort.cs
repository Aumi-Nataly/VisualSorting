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
                listBoxResult.Items.Clear();
                textBoxResult.Clear();

                string data = textBoxValue.Text;

              
                RadioButton radioBtn = this.groupBox1.Controls.OfType<RadioButton>()
                                           .Where(x => x.Checked).FirstOrDefault();

                if (radioBtn == null)
                    throw new Exception("Не указан тип сортировки");


                List<int> listQuestion = Correct(data);

            
                switch (radioBtn.Name)
                {
                    case "radioButtonBubble":
                        clsBubble<int> clsSortBubble = new clsBubble<int>(listQuestion);
                     
                        textBoxResult.Text = clsSortBubble.StartSort();
                        Stepping(clsSortBubble.ArrayStep, clsSortBubble.tableStep);
                        break;

                    case "radioButtonCocktail":
                        clsCocktail<int> clsSortCocktail = new clsCocktail<int>(listQuestion);
                 
                        textBoxResult.Text = clsSortCocktail.StartSort();
                        Stepping(clsSortCocktail.ArrayStep, clsSortCocktail.tableStep);
                        break;
                }
            }
            catch (Exception ex)
            {
                frmError frm = frmError.InstFrm(ex);
                frm.Show();
            }

        }

        private void Stepping(List<string> strings, DataTable tab)
        { 
            foreach (string s in strings)
                listBoxResult.Items.Add(s);

            dataGridViewResult.DataSource= tab;

            dataGridViewResult.Columns["index0"].Visible = false;
            dataGridViewResult.Columns["index1"].Visible = false;
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
           
            textBoxResult.Clear();
            textBoxValue.Clear();
            listBoxResult.Items.Clear();
        }

        private void dataGridViewResult_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
          //  dataGridViewResult.Rows[1].Cells[1].Style.BackColor = Color.Yellow;

            try
            {

                if (e.Value == null) return;
   
               string index0=  dataGridViewResult.Rows[e.RowIndex].Cells["index0"].Value.ToString();
               string index1 = dataGridViewResult.Rows[e.RowIndex].Cells["index1"].Value.ToString();


                // int ind0 = Convert.ToInt32(dataGridViewResult[e.ColumnIndex, e.RowIndex].Value);

                bool nameCol0 = dataGridViewResult.Columns[e.ColumnIndex].Name.Equals(index0);
                bool nameCol1 = dataGridViewResult.Columns[e.ColumnIndex].Name.Equals(index1);


                if (nameCol0)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
               
                if (nameCol1)
                {
                    e.CellStyle.BackColor = Color.YellowGreen;
                }


                //   dataGridViewResult[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;


            }
            catch (Exception ex)
            {
                frmError frm = frmError.InstFrm(ex);
                frm.Show();
            }
        }
    }
}
