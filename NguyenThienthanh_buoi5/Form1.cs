using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThienthanh_buoi5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            int batdau = Int32.Parse(txtBatDau.Text);
            int ketthuc = Int32.Parse(txtCuoi.Text);
            if (batdau> ketthuc)
            {
                MessageBox.Show("Nhập số cuối nhỏ hơn số bắt đầu");
                return;
            }
            long tong = 0, tongchan = 0, tongle = 0;
            for (int i = batdau; i <= ketthuc; i++)
            {
                tong += i;
                if (i%2==0)
                {
                    tongchan += i;
                }
                else
                {
                    tongle += i;
                }

            }

            txtTong.Text=tong.ToString();
            txtTongChan.Text=tongchan.ToString();
            txtTongLe.Text=tongle.ToString();
        }
    }
}
