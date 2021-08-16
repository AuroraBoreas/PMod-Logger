using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace PmodLogger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult rv = folderBrowserDialog_src.ShowDialog();
            if (rv == DialogResult.OK)
            {
                string dir_path = folderBrowserDialog_src.SelectedPath;
                textBox_src.Text = dir_path;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult rv = folderBrowserDialog_dst.ShowDialog();
            if (rv == DialogResult.OK)
            {
                string dir_path = folderBrowserDialog_dst.SelectedPath;
                textBox_dst.Text = dir_path;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime final = new DateTime(2022, 1, 1);
            if (DateTime.Compare(today, final)<0)
            {
                button_start.BackColor = default(Color);
                bool rv = Directory.Exists(textBox_src.Text) && Directory.Exists(textBox_src.Text);
                if (rv)
                {
                    Dispatcher d = new Dispatcher(textBox_src.Text, textBox_dst.Text);
                    listBox_src.DataSource = d.Work();
                    // MessageBox.Show(listBox_src.Items.Count.ToString(), "count");
                }
                button_start.BackColor = Color.FromArgb(0, 255, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            button_start.BackColor = default(Color);
            label1.BackColor = Color.FromArgb(0, 255, 255);
            label2.BackColor = Color.FromArgb(0, 255, 255);
        }
    }
}
