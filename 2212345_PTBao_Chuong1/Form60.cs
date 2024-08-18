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
    public partial class Form60 : Form
    {
        public Form60()
        {
            InitializeComponent();
        }

        private void Form60_Load(object sender, EventArgs e)
        {
            string[] clbMonHoc = ["OOP", "Cơ sở dữ liệu", "Javascript can ban",
                "Quản trị mạng", "react js", "Đồ án","cau truc dl va giai thuat"];
            foreach (string item in clbMonHoc)
            {
                this.checkedListBox1.Items.Add(item);
            }
        }
        
    }
}
