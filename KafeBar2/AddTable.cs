using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeBar2
{
    public partial class AddTable : Form
    {
        public Table table { get; set; }
        public AddTable()
        {
            InitializeComponent();
        }

        private void AddTable_Load(object sender, EventArgs e)
        {

        }
      

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            table = new Table(tbTableNumber.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbTableNumber_Validating_1(object sender, CancelEventArgs e)
        {
            if (tbTableNumber.Text.Length == 0)
            {
                errorProvider1.SetError(tbTableNumber, "Внеси број на маса!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbTableNumber, null);
                e.Cancel = false;
            }
        }
    }
}
