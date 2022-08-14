using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btech_app1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string content = "MR TIMO NIESSNER";
            string title = "Say my name";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult resultbox = MessageBox.Show(content, title, buttons);

            if (resultbox == DialogResult.Yes)
            {
                //ถ้าตอบใช่เกิดอะไรขึ้น
                MessageBox.Show("ขอบคุณครับ", title, MessageBoxButtons.OK);
            }
            else 
            {
                //ถ้าตอบไม่ เกิดอะไรขึ้น
                MessageBox.Show("ขออภัยนะครับ", title, MessageBoxButtons.OK);
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //username ที่ถูกต้อง
            string user = "admin";
            string pass = "1150";

            if (
                (string.IsNullOrEmpty(InputUsername.Text)) ||
                (string.IsNullOrEmpty(InputPassword.Text))
               )
            {   //เชคกรณีว่าง
                MessageBox.Show("Please input username or password first");
            }
            else
            {
                //กรณรีมีค่าปกติต่อไป
                //เชคความถูกต้องของ user ที่ส่งเข้ามา
                if ((user == InputUsername.Text) && (pass == InputPassword.Text))
                {
                    //ถ้า user และ password ถูกต้องทำไร
                    lbStatus.Text = "Login successful !!";

                    lbStatus.ForeColor = Color.White;
                    lbStatus.BackColor = Color.Green;
                }
                else 
                {
                    //ถ้าผิด โชว์อะไร
                    MessageBox.Show("input valid username or password ");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InputUsername.Text = "";
            InputPassword.Text = "";

            lbStatus.ForeColor = Color.Black;
            lbStatus.BackColor = SystemColors.Control;
            lbStatus.Text = "Please login first";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form fm = new Form2();
            //fm.Show();
            fm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "คุณต้องการออกจากโปรแกรม ?",
                "ออกจากโปรแกรม",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else 
            {
                //ไม่ต้องทำอะไร
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string text = "hello hi ไทยๆ bro";
            txtFill.Text = text;
        }
    }
}
