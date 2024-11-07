using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28122020_ZarAtma
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = rnd.Next(1, 7).ToString();
            label2.Text = rnd.Next(1, 7).ToString();
            if(label1.Text=="1")
            {
                pictureBox1.Image = ımageList1.Images[0];
            }
            else if(label1.Text=="2")
            {
                pictureBox1.Image = ımageList1.Images[1];
            }
            else if(label1.Text=="3")
            {
                pictureBox1.Image = ımageList1.Images[2];
            }
            else if(label1.Text=="4")
            {
                pictureBox1.Image = ımageList1.Images[3];
            }
            else if(label1.Text=="5")
            {
                pictureBox1.Image = ımageList1.Images[4];
            }
            else if(label1.Text=="6")
            {
                pictureBox1.Image = ımageList1.Images[5];
            }

            if (label2.Text == "1")
            {
                pictureBox2.Image = ımageList1.Images[0];
            }
            else if (label2.Text == "2")
            {
                pictureBox2.Image = ımageList1.Images[1];
            }
            else if (label2.Text == "3")
            {
                pictureBox2.Image = ımageList1.Images[2];
            }
            else if (label2.Text == "4")
            {
                pictureBox2.Image = ımageList1.Images[3];
            }
            else if (label2.Text == "5")
            {
                pictureBox2.Image = ımageList1.Images[4];
            }
            else if (label2.Text == "6")
            {
                pictureBox2.Image = ımageList1.Images[5];
            }
            button1.Enabled = false;
            button2.Enabled = true;
            button2.ForeColor = Color.DarkRed;
            button1.ForeColor = Color.Black;
            OnayButonu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            button1.Enabled = true;
            button2.Enabled = false;
            button1.ForeColor = Color.DarkRed;
            button2.ForeColor = Color.Black;
            OnayButonu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            button1.Enabled = true;
            button2.Enabled = false;
            button1.ForeColor = Color.DarkRed;
            button2.ForeColor = Color.Black;
            pictureBox1.Focus();
            OnayButonu();
        }
        void OnayButonu()
        {
            if (button1.Enabled == true && button2.Enabled == false)
            {
                this.AcceptButton = button1;
            }
            else if(button2.Enabled == true && button1.Enabled == false)
            {
                this.AcceptButton = button2;
            }
        }
    }
}
