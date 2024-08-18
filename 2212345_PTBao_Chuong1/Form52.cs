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
    public partial class Form52 : Form
    {
        public Form52()
        {
            InitializeComponent();
        }

        private void Form52_Load(object sender, EventArgs e)
        {
            string[] Text ={"Phan Thai Bao","Trieu Quang Hoc","Đinh Lâm Gia Bảo","Nguyen Văn A",
                "Le Thanh Thai","Le Van A", "Tran Van Dung","Tran The Anh","Nguyen Van Thai"};
            foreach (string i in Text)
            {
                listBox1.Items.Add(i);
            }
            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int chon = listBox1.SelectedItems.Count - 1;
            for (int i = chon; i>= 0; i--)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);
                listBox1.Items.Remove(listBox1.SelectedItems[i]);

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int i = listBox2.SelectedItems.Count - 1;
            while (i >= 0)
            {
                listBox1.Items.Add(listBox2.SelectedItems[i]);
                listBox2.Items.RemoveAt(listBox2.SelectedIndices[i]);
                i--;
            }
        }
    }
}
