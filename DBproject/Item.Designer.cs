namespace DBproject
{
    partial class Item
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
            label1 = new Label();
            itemCode = new TextBox();
            itemName = new TextBox();
            label2 = new Label();
            price = new TextBox();
            label4 = new Label();
            itemType = new ComboBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            noVat = new RadioButton();
            vat = new RadioButton();
            qty = new TextBox();
            label5 = new Label();
            amount = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            bClose = new Button();
            bShow = new Button();
            bNew = new Button();
            bAdd = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            bUpdate = new Button();
            bDelete = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 51);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "รหัส";
            // 
            // itemCode
            // 
            itemCode.Location = new Point(118, 48);
            itemCode.Name = "itemCode";
            itemCode.Size = new Size(100, 23);
            itemCode.TabIndex = 1;
            itemCode.KeyDown += itemCode_KeyDown;
            // 
            // itemName
            // 
            itemName.Location = new Point(118, 91);
            itemName.Name = "itemName";
            itemName.Size = new Size(174, 23);
            itemName.TabIndex = 3;
            itemName.KeyDown += itemName_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 94);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 2;
            label2.Text = "ชื่อ";
            // 
            // price
            // 
            price.Location = new Point(118, 174);
            price.Name = "price";
            price.Size = new Size(100, 23);
            price.TabIndex = 7;
            price.KeyDown += price_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 177);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 6;
            label4.Text = "ราคา";
            // 
            // itemType
            // 
            itemType.FormattingEnabled = true;
            itemType.Items.AddRange(new object[] { "รองเท้า", "ถุงมือ", "ถุงเท้า", "ผ้าพันคอ", "เคสโทรศัพท์", "เครื่องฟิตเนสแบบไม่ใช้ไฟฟ้า ", "ของตกแต่งบ้านและสวน", "กระเป๋าเดินทาง", "เข็มขัด", "เสื้อกันฝน", "ของใช้ในครัว", "ผ้าม้วน." });
            itemType.Location = new Point(118, 134);
            itemType.Name = "itemType";
            itemType.Size = new Size(174, 23);
            itemType.TabIndex = 10;
            itemType.KeyDown += itemType_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 137);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 9;
            label3.Text = "ประเภท";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(noVat);
            groupBox1.Controls.Add(vat);
            groupBox1.Location = new Point(62, 295);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(230, 63);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "คิดภาษี";
            // 
            // noVat
            // 
            noVat.AutoSize = true;
            noVat.Location = new Point(127, 22);
            noVat.Name = "noVat";
            noVat.Size = new Size(51, 19);
            noVat.TabIndex = 1;
            noVat.TabStop = true;
            noVat.Text = "ไม่คิด";
            noVat.UseVisualStyleBackColor = true;
            // 
            // vat
            // 
            vat.AutoSize = true;
            vat.Location = new Point(65, 22);
            vat.Name = "vat";
            vat.Size = new Size(39, 19);
            vat.TabIndex = 0;
            vat.TabStop = true;
            vat.Text = "คิด";
            vat.UseVisualStyleBackColor = true;
            // 
            // qty
            // 
            qty.Location = new Point(118, 215);
            qty.Name = "qty";
            qty.Size = new Size(100, 23);
            qty.TabIndex = 13;
            qty.KeyDown += qty_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 218);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 12;
            label5.Text = "จำนวน";
            // 
            // amount
            // 
            amount.Enabled = false;
            amount.Location = new Point(118, 254);
            amount.Name = "amount";
            amount.Size = new Size(100, 23);
            amount.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 257);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 14;
            label6.Text = "เป็นเงิน";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(243, 177);
            label7.Name = "label7";
            label7.Size = new Size(26, 15);
            label7.TabIndex = 16;
            label7.Text = "บาท";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(243, 218);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 17;
            label8.Text = "ชิ้น";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(243, 257);
            label9.Name = "label9";
            label9.Size = new Size(26, 15);
            label9.TabIndex = 18;
            label9.Text = "บาท";
            // 
            // bClose
            // 
            bClose.BackColor = Color.DarkSeaGreen;
            bClose.Location = new Point(381, 406);
            bClose.Name = "bClose";
            bClose.Size = new Size(101, 23);
            bClose.TabIndex = 21;
            bClose.Text = "Close";
            bClose.UseVisualStyleBackColor = false;
            bClose.Click += bClose_Click;
            // 
            // bShow
            // 
            bShow.BackColor = Color.DarkSeaGreen;
            bShow.Location = new Point(251, 406);
            bShow.Name = "bShow";
            bShow.Size = new Size(101, 23);
            bShow.TabIndex = 20;
            bShow.Text = "Show";
            bShow.UseVisualStyleBackColor = false;
            bShow.Click += bShow_Click;
            // 
            // bNew
            // 
            bNew.BackColor = Color.DarkSeaGreen;
            bNew.Location = new Point(120, 406);
            bNew.Name = "bNew";
            bNew.Size = new Size(101, 23);
            bNew.TabIndex = 19;
            bNew.Text = "New";
            bNew.UseVisualStyleBackColor = false;
            bNew.Click += bNew_Click;
            // 
            // bAdd
            // 
            bAdd.BackColor = Color.CornflowerBlue;
            bAdd.Location = new Point(349, 313);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(101, 23);
            bAdd.TabIndex = 22;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = false;
            bAdd.Click += bAdd_Click;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(349, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(728, 221);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "รหัส";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 80;
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
            Column3.HeaderText = "ประเภท";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 120;
            // 
            // Column4
            // 
            Column4.HeaderText = "ราคา";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 80;
            // 
            // Column5
            // 
            Column5.HeaderText = "จำนวน";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 80;
            // 
            // Column6
            // 
            Column6.HeaderText = "เป็นเงิน";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 120;
            // 
            // Column7
            // 
            Column7.HeaderText = "คิดภาษี";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 80;
            // 
            // bUpdate
            // 
            bUpdate.BackColor = Color.Khaki;
            bUpdate.Location = new Point(476, 313);
            bUpdate.Name = "bUpdate";
            bUpdate.Size = new Size(101, 23);
            bUpdate.TabIndex = 24;
            bUpdate.Text = "Update";
            bUpdate.UseVisualStyleBackColor = false;
            bUpdate.Click += bUpdate_Click;
            // 
            // bDelete
            // 
            bDelete.BackColor = Color.Salmon;
            bDelete.Location = new Point(596, 313);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(101, 23);
            bDelete.TabIndex = 25;
            bDelete.Text = "Delete";
            bDelete.UseVisualStyleBackColor = false;
            bDelete.Click += bDelete_Click;
            // 
            // Item
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 496);
            Controls.Add(bDelete);
            Controls.Add(bUpdate);
            Controls.Add(dataGridView1);
            Controls.Add(bAdd);
            Controls.Add(bClose);
            Controls.Add(bShow);
            Controls.Add(bNew);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(amount);
            Controls.Add(label6);
            Controls.Add(qty);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(itemType);
            Controls.Add(label3);
            Controls.Add(price);
            Controls.Add(label4);
            Controls.Add(itemName);
            Controls.Add(label2);
            Controls.Add(itemCode);
            Controls.Add(label1);
            Name = "Item";
            Text = "Item";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox itemCode;
        private TextBox itemName;
        private Label label2;
        private TextBox price;
        private Label label4;
        private ComboBox itemType;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton noVat;
        private RadioButton vat;
        private TextBox qty;
        private Label label5;
        private TextBox amount;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button bClose;
        private Button bShow;
        private Button bNew;
        private Button bAdd;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button bUpdate;
        private Button bDelete;
    }
}