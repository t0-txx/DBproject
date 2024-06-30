namespace DBproject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            DBname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            DBsexN = new RadioButton();
            DBsexM = new RadioButton();
            DBsexF = new RadioButton();
            DBdate = new DateTimePicker();
            DBjob = new ComboBox();
            groupBox2 = new GroupBox();
            DBaptitude6 = new CheckBox();
            DBaptitude5 = new CheckBox();
            DBaptitude4 = new CheckBox();
            DBaptitude3 = new CheckBox();
            DBaptitude2 = new CheckBox();
            DBaptitude1 = new CheckBox();
            DBpicture = new PictureBox();
            bBrowse = new Button();
            bNew = new Button();
            bShow = new Button();
            bClose = new Button();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DBpicture).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 48);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "ชื่อ";
            // 
            // DBname
            // 
            DBname.Location = new Point(196, 48);
            DBname.Name = "DBname";
            DBname.Size = new Size(217, 23);
            DBname.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 186);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "วันเดือนปีเกิด";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 229);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "ตำแหน่ง";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DBsexN);
            groupBox1.Controls.Add(DBsexM);
            groupBox1.Controls.Add(DBsexF);
            groupBox1.Location = new Point(113, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 78);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "เพศ";
            // 
            // DBsexN
            // 
            DBsexN.AutoSize = true;
            DBsexN.Location = new Point(176, 34);
            DBsexN.Name = "DBsexN";
            DBsexN.Size = new Size(53, 19);
            DBsexN.TabIndex = 6;
            DBsexN.TabStop = true;
            DBsexN.Text = "ไม่ระบุ";
            DBsexN.UseVisualStyleBackColor = true;
            // 
            // DBsexM
            // 
            DBsexM.AutoSize = true;
            DBsexM.Location = new Point(123, 34);
            DBsexM.Name = "DBsexM";
            DBsexM.Size = new Size(47, 19);
            DBsexM.TabIndex = 1;
            DBsexM.TabStop = true;
            DBsexM.Text = "หญิง";
            DBsexM.UseVisualStyleBackColor = true;
            // 
            // DBsexF
            // 
            DBsexF.AutoSize = true;
            DBsexF.Location = new Point(69, 34);
            DBsexF.Name = "DBsexF";
            DBsexF.Size = new Size(43, 19);
            DBsexF.TabIndex = 0;
            DBsexF.TabStop = true;
            DBsexF.Text = "ชาย";
            DBsexF.UseVisualStyleBackColor = true;
            // 
            // DBdate
            // 
            DBdate.Location = new Point(199, 180);
            DBdate.Name = "DBdate";
            DBdate.Size = new Size(214, 23);
            DBdate.TabIndex = 6;
            // 
            // DBjob
            // 
            DBjob.FormattingEnabled = true;
            DBjob.Items.AddRange(new object[] { "Programmer", "System Analyst (SA)", "System Engineer (วิศวกรระบบ)", "Tester (ผู้ทดสอบระบบ)", "Project Manager (PM)", "IT Consulting (ที่ปรึกษาด้านไอที)", "IT Support/Help Desk/Administrator" });
            DBjob.Location = new Point(199, 226);
            DBjob.Name = "DBjob";
            DBjob.Size = new Size(214, 23);
            DBjob.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DBaptitude6);
            groupBox2.Controls.Add(DBaptitude5);
            groupBox2.Controls.Add(DBaptitude4);
            groupBox2.Controls.Add(DBaptitude3);
            groupBox2.Controls.Add(DBaptitude2);
            groupBox2.Controls.Add(DBaptitude1);
            groupBox2.Location = new Point(113, 277);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(586, 145);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "ความถนัด";
            // 
            // DBaptitude6
            // 
            DBaptitude6.AutoSize = true;
            DBaptitude6.Location = new Point(417, 91);
            DBaptitude6.Name = "DBaptitude6";
            DBaptitude6.Size = new Size(85, 19);
            DBaptitude6.TabIndex = 5;
            DBaptitude6.Text = "Team Work";
            DBaptitude6.UseVisualStyleBackColor = true;
            // 
            // DBaptitude5
            // 
            DBaptitude5.AutoSize = true;
            DBaptitude5.Location = new Point(241, 91);
            DBaptitude5.Name = "DBaptitude5";
            DBaptitude5.Size = new Size(67, 19);
            DBaptitude5.TabIndex = 4;
            DBaptitude5.Text = "Graphic";
            DBaptitude5.UseVisualStyleBackColor = true;
            // 
            // DBaptitude4
            // 
            DBaptitude4.AutoSize = true;
            DBaptitude4.Location = new Point(69, 91);
            DBaptitude4.Name = "DBaptitude4";
            DBaptitude4.Size = new Size(127, 19);
            DBaptitude4.TabIndex = 3;
            DBaptitude4.Text = "Mobile Application";
            DBaptitude4.UseVisualStyleBackColor = true;
            // 
            // DBaptitude3
            // 
            DBaptitude3.AutoSize = true;
            DBaptitude3.Location = new Point(417, 40);
            DBaptitude3.Name = "DBaptitude3";
            DBaptitude3.Size = new Size(97, 19);
            DBaptitude3.TabIndex = 2;
            DBaptitude3.Text = "Management";
            DBaptitude3.UseVisualStyleBackColor = true;
            // 
            // DBaptitude2
            // 
            DBaptitude2.AutoSize = true;
            DBaptitude2.Location = new Point(241, 40);
            DBaptitude2.Name = "DBaptitude2";
            DBaptitude2.Size = new Size(121, 19);
            DBaptitude2.TabIndex = 1;
            DBaptitude2.Text = "Game Application";
            DBaptitude2.UseVisualStyleBackColor = true;
            // 
            // DBaptitude1
            // 
            DBaptitude1.AutoSize = true;
            DBaptitude1.Location = new Point(69, 40);
            DBaptitude1.Name = "DBaptitude1";
            DBaptitude1.Size = new Size(114, 19);
            DBaptitude1.TabIndex = 0;
            DBaptitude1.Text = "Web Application";
            DBaptitude1.UseVisualStyleBackColor = true;
            // 
            // DBpicture
            // 
            DBpicture.BorderStyle = BorderStyle.FixedSingle;
            DBpicture.Location = new Point(471, 48);
            DBpicture.Name = "DBpicture";
            DBpicture.Size = new Size(228, 155);
            DBpicture.SizeMode = PictureBoxSizeMode.StretchImage;
            DBpicture.TabIndex = 10;
            DBpicture.TabStop = false;
            // 
            // bBrowse
            // 
            bBrowse.Location = new Point(555, 229);
            bBrowse.Name = "bBrowse";
            bBrowse.Size = new Size(75, 23);
            bBrowse.TabIndex = 11;
            bBrowse.Text = "Browse";
            bBrowse.UseVisualStyleBackColor = true;
            bBrowse.Click += bBrowse_Click;
            // 
            // bNew
            // 
            bNew.BackColor = Color.DarkSeaGreen;
            bNew.Location = new Point(210, 450);
            bNew.Name = "bNew";
            bNew.Size = new Size(101, 23);
            bNew.TabIndex = 12;
            bNew.Text = "New";
            bNew.UseVisualStyleBackColor = false;
            bNew.Click += bNew_Click;
            // 
            // bShow
            // 
            bShow.BackColor = Color.DarkSeaGreen;
            bShow.Location = new Point(341, 450);
            bShow.Name = "bShow";
            bShow.Size = new Size(101, 23);
            bShow.TabIndex = 13;
            bShow.Text = "Show";
            bShow.UseVisualStyleBackColor = false;
            bShow.Click += bShow_Click;
            // 
            // bClose
            // 
            bClose.BackColor = Color.DarkSeaGreen;
            bClose.Location = new Point(471, 450);
            bClose.Name = "bClose";
            bClose.Size = new Size(101, 23);
            bClose.TabIndex = 14;
            bClose.Text = "Close";
            bClose.UseVisualStyleBackColor = false;
            bClose.Click += bClose_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 547);
            Controls.Add(bClose);
            Controls.Add(bShow);
            Controls.Add(bNew);
            Controls.Add(bBrowse);
            Controls.Add(DBpicture);
            Controls.Add(groupBox2);
            Controls.Add(DBjob);
            Controls.Add(DBdate);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DBname);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DBpicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox DBname;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton DBsexN;
        private RadioButton DBsexM;
        private RadioButton DBsexF;
        private DateTimePicker DBdate;
        private ComboBox DBjob;
        private GroupBox groupBox2;
        private CheckBox DBaptitude6;
        private CheckBox DBaptitude5;
        private CheckBox DBaptitude4;
        private CheckBox DBaptitude3;
        private CheckBox DBaptitude2;
        private CheckBox DBaptitude1;
        private PictureBox DBpicture;
        private Button bBrowse;
        private Button bNew;
        private Button bShow;
        private Button bClose;
        private OpenFileDialog openFileDialog1;
    }
}