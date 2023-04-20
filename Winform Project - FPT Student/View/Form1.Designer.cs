namespace Winform_Project___FPT_Student
{
    partial class Form1
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxXepLoai = new System.Windows.Forms.TextBox();
            this.textBoxDTB = new System.Windows.Forms.TextBox();
            this.textBoxHoa = new System.Windows.Forms.TextBox();
            this.textBoxLy = new System.Windows.Forms.TextBox();
            this.textBoxToan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonXepLoai = new System.Windows.Forms.Button();
            this.buttonTinh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(213, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(389, 37);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Quản Lý Điểm Sinh Viên";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxXepLoai);
            this.groupBox1.Controls.Add(this.textBoxDTB);
            this.groupBox1.Controls.Add(this.textBoxHoa);
            this.groupBox1.Controls.Add(this.textBoxLy);
            this.groupBox1.Controls.Add(this.textBoxToan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 389);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin điểm sinh viên";
            // 
            // textBoxXepLoai
            // 
            this.textBoxXepLoai.Location = new System.Drawing.Point(72, 159);
            this.textBoxXepLoai.Name = "textBoxXepLoai";
            this.textBoxXepLoai.ReadOnly = true;
            this.textBoxXepLoai.Size = new System.Drawing.Size(512, 20);
            this.textBoxXepLoai.TabIndex = 9;
            // 
            // textBoxDTB
            // 
            this.textBoxDTB.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBoxDTB.Location = new System.Drawing.Point(93, 129);
            this.textBoxDTB.Name = "textBoxDTB";
            this.textBoxDTB.ReadOnly = true;
            this.textBoxDTB.Size = new System.Drawing.Size(491, 20);
            this.textBoxDTB.TabIndex = 8;
            // 
            // textBoxHoa
            // 
            this.textBoxHoa.Location = new System.Drawing.Point(72, 97);
            this.textBoxHoa.Name = "textBoxHoa";
            this.textBoxHoa.Size = new System.Drawing.Size(512, 20);
            this.textBoxHoa.TabIndex = 7;
            // 
            // textBoxLy
            // 
            this.textBoxLy.Location = new System.Drawing.Point(72, 65);
            this.textBoxLy.Name = "textBoxLy";
            this.textBoxLy.Size = new System.Drawing.Size(512, 20);
            this.textBoxLy.TabIndex = 6;
            // 
            // textBoxToan
            // 
            this.textBoxToan.Location = new System.Drawing.Point(72, 35);
            this.textBoxToan.Name = "textBoxToan";
            this.textBoxToan.Size = new System.Drawing.Size(512, 20);
            this.textBoxToan.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Xếp loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm trung bình";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm Hoá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm Lý";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm Toán";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonXepLoai);
            this.panel1.Controls.Add(this.buttonTinh);
            this.panel1.Location = new System.Drawing.Point(608, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 389);
            this.panel1.TabIndex = 2;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(3, 59);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(173, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset All Field";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonXepLoai
            // 
            this.buttonXepLoai.Location = new System.Drawing.Point(4, 30);
            this.buttonXepLoai.Name = "buttonXepLoai";
            this.buttonXepLoai.Size = new System.Drawing.Size(173, 23);
            this.buttonXepLoai.TabIndex = 1;
            this.buttonXepLoai.Text = "Xếp loại";
            this.buttonXepLoai.UseVisualStyleBackColor = true;
            this.buttonXepLoai.Click += new System.EventHandler(this.buttonXepLoai_Click);
            // 
            // buttonTinh
            // 
            this.buttonTinh.Location = new System.Drawing.Point(4, 3);
            this.buttonTinh.Name = "buttonTinh";
            this.buttonTinh.Size = new System.Drawing.Size(173, 23);
            this.buttonTinh.TabIndex = 0;
            this.buttonTinh.Text = "Tính điểm";
            this.buttonTinh.UseVisualStyleBackColor = true;
            this.buttonTinh.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxXepLoai;
        private System.Windows.Forms.TextBox textBoxDTB;
        private System.Windows.Forms.TextBox textBoxHoa;
        private System.Windows.Forms.TextBox textBoxLy;
        private System.Windows.Forms.TextBox textBoxToan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonXepLoai;
        private System.Windows.Forms.Button buttonTinh;
        private System.Windows.Forms.Button buttonReset;
    }
}

