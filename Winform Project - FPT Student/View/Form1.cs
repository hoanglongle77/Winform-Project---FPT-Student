using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Project___FPT_Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double diemToan = Double.Parse(textBoxToan.Text);
            double diemLy = Double.Parse(textBoxLy.Text);
            double diemHoa = Double.Parse(textBoxHoa.Text);
            double diemTB = (diemToan + diemLy + diemHoa) / 3;
            textBoxDTB.Text = diemTB.ToString();
        }

        private void buttonXepLoai_Click(object sender, EventArgs e)
        {
            double diemTB = Double.Parse(textBoxDTB.Text);
            if (diemTB >= 8 && diemTB <= 10)
            {
                textBoxXepLoai.Text = "Giỏi";
            }else if (diemTB >=6.5 && diemTB < 8)
            {
                textBoxXepLoai.Text = "Khá";
            }else if(diemTB >= 4 && diemTB < 6.5)
            {
                textBoxXepLoai.Text = "Trung Bình";
            }
            else
            {
                textBoxXepLoai.Text = "Yếu";
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxToan.ResetText();
            textBoxLy.ResetText();
            textBoxHoa.ResetText();
            textBoxDTB.ResetText();
            textBoxXepLoai.ResetText();
        }
    }
}
