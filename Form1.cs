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
    }
}
