using System;
using System.Windows.Forms;

namespace ekz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void resultSet(string result)
        {
            richTextBox1.Text = $"{result}";
            toolStripStatusLabel1.Text = $"{result}";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
