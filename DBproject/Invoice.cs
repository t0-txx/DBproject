using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBproject
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
            invoiceCustomer();
        }

        private void invoiceCustomer()
        {
            string[] name = { "น้ำเงิน", "เขียว", "ขาว", "ส้ม", "แดง" };
            int[] balance = { 0, 1000, 5000, 500, 20000 };
            for (int i = 0; i < name.Length; i++)
            {
                dataGridView1.Rows.Add();
                int r = dataGridView1.Rows.Count - 1;
                dataGridView1.Rows[r].Cells[0].Value = "000" + (i + 1);
                dataGridView1.Rows[r].Cells[1].Value = name[i];
                dataGridView1.Rows[r].Cells[2].Value = balance[i];
                inCustomer.Items.Add(name[i]);
            }
        }
        private void inCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(inCustomer.SelectedIndex != -1)
                inCustomerCode.Text = "000" + (inCustomer.SelectedIndex + 1);
        }

        private void inCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                inCustomer.Focus();
            }
        }

        private void inCustomer_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                inEmployee.Focus();
            }
        }

        private void inEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                price.Focus();
            }
        }

        private void price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                vat.Text = (double.Parse(price.Text) * 0.07).ToString("#,##0.00");
                amount.Text = (double.Parse(price.Text) - double.Parse(vat.Text)).ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                vat.Clear();
                amount.Clear();
            }
        }

        private void newClear()
        {
            inCode.Clear();
            dateTimePicker1.Value = DateTime.Now;
            inCustomerCode.Clear();
            inCustomer.SelectedIndex = -1;
            inEmployee.Text = "";
            price.Clear();
            amount.Clear();
            vat.Clear();
            amount.Clear();
            inCode.Focus();
        }
        private void bNew_Click(object sender, EventArgs e)
        {
            newClear();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add();
            int r = dataGridView2.Rows.Count - 1;
            dataGridView2.Rows[r].Cells[0].Value = inCode.Text;
            dataGridView2.Rows[r].Cells[1].Value = dateTimePicker1.Value;
            dataGridView2.Rows[r].Cells[2].Value = inCustomerCode.Text;
            dataGridView2.Rows[r].Cells[3].Value = inEmployee.Text;
            dataGridView2.Rows[r].Cells[4].Value = price.Text;
            dataGridView2.Rows[r].Cells[5].Value = vat.Text;
            dataGridView2.Rows[r].Cells[6].Value = amount.Text;
            newClear();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string customer = dataGridView2.Rows[e.RowIndex].Cells[2].Value + "";
                inCode.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value + "";
                dateTimePicker1.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value + "";
                inCustomerCode.Text = customer;
                inEmployee.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value + "";
                price.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value + "";
                vat.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value + "";
                amount.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value + "";
                try 
                { 
                    inCustomer.SelectedIndex = int.Parse(customer.Remove(customer.IndexOf("000"), 0)) - 1; 
                } 
                catch(Exception ex)
                {
                    MessageBox.Show("ไม่มีข้อมูล Customer");
                }
                inCode.Focus();
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                int r = dataGridView2.CurrentCell.RowIndex;
                dataGridView2.Rows[r].Cells[0].Value = inCode.Text;
                dataGridView2.Rows[r].Cells[1].Value = dateTimePicker1.Value;
                dataGridView2.Rows[r].Cells[2].Value = inCustomerCode.Text;
                dataGridView2.Rows[r].Cells[3].Value = inEmployee.Text;
                dataGridView2.Rows[r].Cells[4].Value = price.Text;
                dataGridView2.Rows[r].Cells[5].Value = vat.Text;
                dataGridView2.Rows[r].Cells[6].Value = amount.Text;
                newClear();
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("แน่ใจนะว่าจะลบ", "ยืนยัน", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (dataGridView2.Rows.Count > 0)
                {
                    int r = dataGridView2.CurrentCell.RowIndex;
                    dataGridView2.Rows.RemoveAt(r);
                    newClear();
                }
                else
                {
                    MessageBox.Show("ไม่มีข้อมูล");
                }
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("แน่ใจนะว่าจะปิด", "ยืนยัน", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
