using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212345_PTBao_Chuong1
{
    public partial class Form56 : Form
    {
        public Form56()
        {
            InitializeComponent();
        }
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
                MessageBox.Show($"Giới tính bạn là: {radioButton1.Text}");
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
                MessageBox.Show($"Giới tính bạn là: {radioButton2.Text}");
        }
    }
}
