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
    public partial class AddOrder : Form
    {
        public Order order;
        public AddOrder()
        {
            InitializeComponent();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnAddOrder_Click_1(object sender, EventArgs e)
        {
            order = new Order(tbType.Text, cbSugar.Checked, cbNoSugar.Checked, cbLarge.Checked, cbSmall.Checked, cbHot.Checked, cbCold.Checked, (int)nudCountity.Value, int.Parse(tbPrice.Text));
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelOrder_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbType_Validating_1(object sender, CancelEventArgs e)
        {
            if (tbType.Text.Length == 0)
            {
                errorProvider1.SetError(tbType, "Внеси тип на пијалок!");
                e.Cancel = true;
            }
            else
            {
                string sh = tbType.Text.Trim();
                foreach (char c in sh)
                {
                    if (!Char.IsLetter(c))
                    {
                        errorProvider1.SetError(tbType, "Мора да внесете букви!");
                        e.Cancel = true;
                        return;
                    }
                }
                errorProvider1.SetError(tbType, null);
                e.Cancel = false;
            }
        }

        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            string sh = tbPrice.Text.Trim();
            foreach (char c in sh)
            {
                if (Char.IsLetter(c))
                {
                    errorProvider1.SetError(tbPrice, "Мора да внесете цена!");
                    e.Cancel = true;
                    return;
                }

                else
                {
                    errorProvider1.SetError(tbPrice, null);
                    e.Cancel = false;
                }
            }
        }
    }
}
