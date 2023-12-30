using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp5
{
    public partial class UpdateValueForm : Form
    {
        public string NewValue { get; private set; }

        public UpdateValueForm(string currentValue)
        {
            InitializeComponent();
            textBox1.Text = currentValue;

            btnOk.Click += btnOk_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            NewValue = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {

        }
    }

}
