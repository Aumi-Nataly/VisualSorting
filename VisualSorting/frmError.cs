using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualSorting
{
    public partial class frmError : Form
    {
        private Exception Ex;
        private static frmError _frmError = null;
        private frmError(Exception _ex)
        {
            Ex = _ex;

            InitializeComponent();
        }

        public static frmError InstFrm(Exception _ex)
        {
            if (_frmError == null)
                _frmError = new frmError(_ex);

            return _frmError;

        }

        private void frmError_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmError = null;
        }

        private void frmError_Load(object sender, EventArgs e)
        {
            richTextBoxError.Text = Ex.Message;
        }
    }
}
