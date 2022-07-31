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
            string text1 = textBox1.Text;
            MessageBox.Show(text1);
        }

        private void btnPlusNumber_Click(object sender, EventArgs e)
        {
            string title = "Comfirm me";
            string content = "Test a result content";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(content, title, buttons);

            if (result == DialogResult.OK)
            {
                //หลังจากกด ok แล้วต้องการให้ทำไรต่อ
            }
            else { 
                // เสร็จแล้ว
            }
        }
    }
}