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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
      
        private void load()
        {
            lblOrders.Items.Clear();
            tbPrice.Clear();
            if (lbTable.SelectedIndex != -1)
            {
                Table selectedTable = lbTable.Items[lbTable.SelectedIndex] as Table;
                foreach (Order order in selectedTable.Orders)
                {
                    lblOrders.Items.Add(order);
                }

                //vkupno


                tbPrice.Text = selectedTable.totalAmount().ToString();
            }
        }

        private void btnAddTable_Click_1(object sender, EventArgs e)
        {
            AddTable addtable = new AddTable();
            if (addtable.ShowDialog() == DialogResult.OK)
            {
                lbTable.Items.Add(addtable.table);
            }
        }

        private void btnDeleteTable_Click_1(object sender, EventArgs e)
        {
            if (lbTable.SelectedIndex == -1)
            {
                return;
            }
            DialogResult dg = MessageBox.Show("Дали сте сигурни?", "Дали сте сигурни?", MessageBoxButtons.OKCancel);
            if (dg == DialogResult.OK)
            {
                int selectedIndex = lbTable.SelectedIndex;
                lbTable.Items.RemoveAt(selectedIndex);
                load();
            }
        }

        private void btnAddOrder_Click_1(object sender, EventArgs e)
        {
            if (lbTable.SelectedIndex != -1)
            {

                AddOrder addorder = new AddOrder();
                if (addorder.ShowDialog() == DialogResult.OK)
                {
                    Table selectedTable = lbTable.Items[lbTable.SelectedIndex] as Table;
                    selectedTable.Orders.Add(addorder.order);

                    load();
                }
            }
        }

        private void lbTable_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            load();
        }

        private void lbTable_SelectedValueChanged_1(object sender, EventArgs e)
        {
            load();
        }

        private void btnDelivery_Click_1(object sender, EventArgs e)
        {
            if (lblOrders.SelectedItems.Count == 1)
            {
                Time time = new Time();
                time.Show();
            }
        }
    }
}
