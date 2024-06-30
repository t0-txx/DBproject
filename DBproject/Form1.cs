namespace DBproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            DBpicture.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            DBname.Clear();
            DBsexF.Checked = false;
            DBsexM.Checked = false;
            DBsexN.Checked = false;
            DBdate.Value = DateTime.Today;
            DBjob.Text = "";
            DBpicture.Image = null;
            DBaptitude1.Checked = false;
            DBaptitude2.Checked = false;
            DBaptitude3.Checked = false;
            DBaptitude4.Checked = false;
            DBaptitude5.Checked = false;
            DBaptitude6.Checked = false;
            DBname.Focus();
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            string ms = "";

            string sex = "";
            if (DBsexF.Checked)
            {
                sex = DBsexF.Text;
            }
            else if (DBsexM.Checked)
            {
                sex = DBsexM.Text;
            }
            else
            {
                sex = DBsexN.Text;
            }

            if (DBaptitude1.Checked)
            {
                ms += "\t" + DBaptitude1.Text + "\n";
            }

            if (DBaptitude2.Checked)
            {
                ms += "\t" + DBaptitude2.Text + "\n";
            }

            if (DBaptitude3.Checked)
            {
                ms += "\t" + DBaptitude3.Text + "\n";
            }

            if (DBaptitude4.Checked)
            {
                ms += "\t" + DBaptitude4.Text + "\n";
            }

            if (DBaptitude5.Checked)
            {
                ms += "\t" + DBaptitude5.Text + "\n";
            }

            if (DBaptitude6.Checked)
            {
                ms += "\t" + DBaptitude6.Text + "\n";
            }

            MessageBox.Show("ชื่อ\t" + DBname.Text + "\nเพศ\t" + sex + "\nวันเดือนปี\t" + DBdate.Text + "\nตำแหน่ง\t" + DBjob.Text + "\n\nความถนัด" + ms, "ข้อมูลพนักงาน");
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