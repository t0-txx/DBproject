namespace DBproject
{
    partial class Invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            bDelete = new Button();
            bUpdate = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            bAdd = new Button();
            bClose = new Button();
            bNew = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            amount = new TextBox();
            label6 = new Label();
            vat = new TextBox();
            label5 = new Label();
            inEmployee = new ComboBox();
            label3 = new Label();
            price = new TextBox();
            label4 = new Label();
            inCustomerCode = new TextBox();
            label2 = new Label();
            inCode = new TextBox();
            label1 = new Label();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            inCustomer = new ComboBox();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // bDelete
            // 
            bDelete.BackColor = Color.Salmon;
            bDelete.Location = new Point(512, 298);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(136, 23);
            bDelete.TabIndex = 11;
            bDelete.Text = "Delete";
            bDelete.UseVisualStyleBackColor = false;
            bDelete.Click += bDelete_Click;
            // 
            // bUpdate
            // 
            bUpdate.BackColor = Color.Khaki;
            bUpdate.Location = new Point(356, 298);
            bUpdate.Name = "bUpdate";
            bUpdate.Size = new Size(136, 23);
            bUpdate.TabIndex = 10;
            bUpdate.Text = "Update";
            bUpdate.UseVisualStyleBackColor = false;
            bUpdate.Click += bUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(356, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(444, 186);
            dataGridView1.TabIndex = 46;
            // 
            // Column1
            // 
            Column1.HeaderText = "รหัส";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "ชื่อ";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 120;
            // 
            // Column3
            // 
            Column3.HeaderText = "ยอดหนี้";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 120;
            // 
            // bAdd
            // 
            bAdd.BackColor = Color.CornflowerBlue;
            bAdd.Location = new Point(194, 298);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(136, 23);
            bAdd.TabIndex = 9;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = false;
            bAdd.Click += bAdd_Click;
            // 
            // bClose
            // 
            bClose.BackColor = Color.DarkSeaGreen;
            bClose.Location = new Point(664, 298);
            bClose.Name = "bClose";
            bClose.Size = new Size(136, 23);
            bClose.TabIndex = 12;
            bClose.Text = "Close";
            bClose.UseVisualStyleBackColor = false;
            bClose.Click += bClose_Click;
            // 
            // bNew
            // 
            bNew.BackColor = Color.DarkSeaGreen;
            bNew.Location = new Point(40, 298);
            bNew.Name = "bNew";
            bNew.Size = new Size(136, 23);
            bNew.TabIndex = 8;
            bNew.Text = "New";
            bNew.UseVisualStyleBackColor = false;
            bNew.Click += bNew_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(237, 237);
            label9.Name = "label9";
            label9.Size = new Size(26, 15);
            label9.TabIndex = 0;
            label9.Text = "บาท";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(237, 198);
            label8.Name = "label8";
            label8.Size = new Size(26, 15);
            label8.TabIndex = 0;
            label8.Text = "บาท";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(237, 157);
            label7.Name = "label7";
            label7.Size = new Size(26, 15);
            label7.TabIndex = 0;
            label7.Text = "บาท";
            // 
            // amount
            // 
            amount.Enabled = false;
            amount.Location = new Point(112, 234);
            amount.Name = "amount";
            amount.Size = new Size(100, 23);
            amount.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 237);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 0;
            label6.Text = "รวมเป็นเงิน";
            // 
            // vat
            // 
            vat.Enabled = false;
            vat.Location = new Point(112, 195);
            vat.Name = "vat";
            vat.Size = new Size(100, 23);
            vat.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 198);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 35;
            label5.Text = "vat 7%";
            // 
            // inEmployee
            // 
            inEmployee.FormattingEnabled = true;
            inEmployee.Items.AddRange(new object[] { "พัลลภ", "วีรพล", "อรรณพ", "วิทวัส", "นราธิป", "ชมพูนุช", "รติมา", "ประภัสสร", "วรรณพร", "แก้วทิพย์" });
            inEmployee.Location = new Point(112, 114);
            inEmployee.Name = "inEmployee";
            inEmployee.Size = new Size(151, 23);
            inEmployee.TabIndex = 3;
            inEmployee.KeyDown += inEmployee_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 117);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 32;
            label3.Text = "พนักงานขาย";
            // 
            // price
            // 
            price.Location = new Point(112, 154);
            price.Name = "price";
            price.Size = new Size(100, 23);
            price.TabIndex = 4;
            price.TextChanged += price_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 157);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 0;
            label4.Text = "มูลค่าสินค้า";
            // 
            // inCustomerCode
            // 
            inCustomerCode.Location = new Point(112, 71);
            inCustomerCode.Name = "inCustomerCode";
            inCustomerCode.Size = new Size(100, 23);
            inCustomerCode.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 74);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 0;
            label2.Text = "ลูกค้า";
            // 
            // inCode
            // 
            inCode.Location = new Point(112, 28);
            inCode.Name = "inCode";
            inCode.Size = new Size(100, 23);
            inCode.TabIndex = 0;
            inCode.KeyDown += inCode_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 31);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "เลขที่";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(313, 31);
            label10.Name = "label10";
            label10.Size = new Size(26, 15);
            label10.TabIndex = 0;
            label10.Text = "วันที่";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(356, 25);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.Value = new DateTime(2024, 6, 30, 17, 28, 40, 0);
            // 
            // inCustomer
            // 
            inCustomer.FormattingEnabled = true;
            inCustomer.Location = new Point(218, 71);
            inCustomer.Name = "inCustomer";
            inCustomer.Size = new Size(121, 23);
            inCustomer.TabIndex = 1;
            inCustomer.SelectedIndexChanged += inCustomer_SelectedIndexChanged;
            inCustomer.KeyDown += inCustomer_KeyDown;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Column4, Column5, Column6, Column7 });
            dataGridView2.Location = new Point(40, 365);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(760, 206);
            dataGridView2.TabIndex = 51;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "เลขที่";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "วันที่";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "ลูกค้า";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "พนักงาน";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "มูลค่า";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "vat";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "รวมเงิน";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 641);
            Controls.Add(dataGridView2);
            Controls.Add(inCustomer);
            Controls.Add(dateTimePicker1);
            Controls.Add(label10);
            Controls.Add(bDelete);
            Controls.Add(bUpdate);
            Controls.Add(dataGridView1);
            Controls.Add(bAdd);
            Controls.Add(bClose);
            Controls.Add(bNew);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(amount);
            Controls.Add(label6);
            Controls.Add(vat);
            Controls.Add(label5);
            Controls.Add(inEmployee);
            Controls.Add(label3);
            Controls.Add(price);
            Controls.Add(label4);
            Controls.Add(inCustomerCode);
            Controls.Add(label2);
            Controls.Add(inCode);
            Controls.Add(label1);
            Name = "Invoice";
            Text = "Invoice";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bDelete;
        private Button bUpdate;
        private DataGridView dataGridView1;
        private Button bAdd;
        private Button bClose;
        private Button bNew;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox amount;
        private Label label6;
        private TextBox vat;
        private Label label5;
        private ComboBox inEmployee;
        private Label label3;
        private TextBox price;
        private Label label4;
        private TextBox inCustomerCode;
        private Label label2;
        private TextBox inCode;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private ComboBox inCustomer;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}