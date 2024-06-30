using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DBproject
{
    public partial class Item : Form
    {
        string isVat = "";
        public Item()
        {
            InitializeComponent();
            showVat();
        }

        private void itemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                itemName.Focus();
            }
        }

        private void itemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                itemType.Focus();
            }
        }

        private void itemType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                price.Focus();
            }
        }

        private void price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                qty.Focus();
            }
        }

        private void qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    amount.Text = (int.Parse(price.Text) * int.Parse(qty.Text)) + "";
                    vat.Focus();
                }
                catch (Exception)
                {
                    MessageBox.Show("กรุณาพิมพ์ให้ถูก", "แจ้งเตือน");
                    price.Clear();
                    qty.Clear();
                }
            }
        }

        private void showVat()
        {
            if (vat.Checked)
            {
                isVat = vat.Text;
            }
            else if (noVat.Checked)
            {
                isVat = noVat.Text;
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            int r = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[r].Cells[0].Value = itemCode.Text;
            dataGridView1.Rows[r].Cells[1].Value = itemName.Text;
            dataGridView1.Rows[r].Cells[2].Value = itemType.Text;
            dataGridView1.Rows[r].Cells[3].Value = price.Text;
            dataGridView1.Rows[r].Cells[4].Value = qty.Text;
            dataGridView1.Rows[r].Cells[5].Value = amount.Text;
            showVat();
            dataGridView1.Rows[r].Cells[6].Value = isVat;
            newClear();
        }
        private void newClear()
        {
            itemCode.Clear();
            itemName.Clear();
            itemType.Text = "";
            price.Clear();
            qty.Clear();
            amount.Clear();
            vat.Checked = false;
            noVat.Checked = false;
            itemCode.Focus();
        }
        private void bNew_Click(object sender, EventArgs e)
        {
            newClear();
        }
        private void bShow_Click(object sender, EventArgs e)
        {
            showVat();
            MessageBox.Show("รหัส\t" + itemCode.Text +
                            "\nชื่อ\t" + itemName.Text +
                            "\nประเภท\t" + itemType.Text +
                            "\nราคา\t" + price.Text +
                            "\nจำนวน\t" + qty.Text +
                            "\nเป็นเงิน\t" + amount.Text +
                            "\nคิดภาษี\t" + isVat
                            , "ข้อมูลสินค้า");
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("แน่ใจนะว่าจะปิด", "ยืนยัน", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                itemCode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value + "";
                itemName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value + "";
                itemType.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value + "";
                price.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value + "";
                qty.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value + "";
                amount.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value + "";
                if (dataGridView1.Rows[e.RowIndex].Cells[6].Value + "" == vat.Text)
                {
                    vat.Checked = true;
                }
                else if (dataGridView1.Rows[e.RowIndex].Cells[6].Value + "" == noVat.Text)
                {
                    noVat.Checked = true;
                }
                itemCode.Focus();
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[r].Cells[0].Value = itemCode.Text;
                dataGridView1.Rows[r].Cells[1].Value = itemName.Text;
                dataGridView1.Rows[r].Cells[2].Value = itemType.Text;
                dataGridView1.Rows[r].Cells[3].Value = price.Text;
                dataGridView1.Rows[r].Cells[4].Value = qty.Text;
                dataGridView1.Rows[r].Cells[5].Value = amount.Text;
                showVat();
                dataGridView1.Rows[r].Cells[6].Value = isVat;
                newClear();
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("แน่ใจนะว่าจะลบ", "ยืนยัน", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    int r = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(r);
                    dataGridView1.CurrentCell = null;
                }
                else
                {
                    MessageBox.Show("ไม่มีข้อมูล");
                }
                newClear();
            }
        }
    }
}
