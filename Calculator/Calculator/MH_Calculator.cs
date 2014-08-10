using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MH_Calculator : Form
    {
        string input = string.Empty;
        string gt1 = string.Empty;
        string gt2 = string.Empty;
        char tinh;
        double kq = 0.0;
        public MH_Calculator()
        {
            InitializeComponent();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            this.txtkq.Text = "";
            input += "0";
            this.txtkq.Text += input;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            this.txtkq.Text = "";
            input += "1";
            this.txtkq.Text += input;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            this.txtkq.Text = "";
            input += "2";
            this.txtkq.Text += input;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            this.txtkq.Text = "";
            input += "3";
            this.txtkq.Text += input;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            this.txtkq.Text = "";
            input += "4";
            this.txtkq.Text += input;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            this.txtkq.Text = "";
            input += "5";
            this.txtkq.Text += input;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            this.txtkq.Text = "";
            input += "6";
            this.txtkq.Text += input;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            this.txtkq.Text = "";
            input += "7";
            this.txtkq.Text += input;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            this.txtkq.Text = "";
            input += "8";
            this.txtkq.Text += input;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            this.txtkq.Text = "";
            input += "9";
            this.txtkq.Text += input;
        }

        private void chia_Click(object sender, EventArgs e)
        {
            gt1 = input;
            tinh = '/';
            input = string.Empty;
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            gt1 = input;
            tinh = '*';
            input = string.Empty;
        }

        private void tru_Click(object sender, EventArgs e)
        {
            gt1 = input;
            tinh = '-';
            input = string.Empty;
        }

        private void cong_Click(object sender, EventArgs e)
        {
            gt1 = input;
            tinh = '+';
            input = string.Empty;
        }

        private void bang_Click(object sender, EventArgs e)
        {
            gt2 = input;
            double num1, num2;
            double.TryParse(gt1, out num1);
            double.TryParse(gt2, out num2);

            if (tinh == '+')
            {
                kq = num1 + num2;
                txtkq.Text = kq.ToString();
            }
            else if (tinh == '-')
            {
                kq = num1 - num2;
                txtkq.Text = kq.ToString();
            }
            else if (tinh == '*')
            {
                kq = num1 * num2;
                txtkq.Text = kq.ToString();
            }
            else if (tinh == '/')
            {
                if (num2 != 0)
                {
                    kq = num1 / num2;
                    txtkq.Text = kq.ToString();
                }
                else
                {
                    txtkq.Text = "DIV/Zero!";
                }

            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            this.txtkq.Text = "";
            this.input = string.Empty;
            this.gt1 = string.Empty;
            this.gt2 = string.Empty;
        }

        private void cham_Click(object sender, EventArgs e)
        {
            this.txtkq.Text = "";
            input += ".";
            this.txtkq.Text += input;
        }

        
    }
}
