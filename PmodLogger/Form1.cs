using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

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
                button_start.BackColor = default(Color);
                string dir_path = folderBrowserDialog_src.SelectedPath;
                textBox_src.Text = dir_path;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult rv = folderBrowserDialog_dst.ShowDialog();
            if (rv == DialogResult.OK)
            {
                button_start.BackColor = default(Color);
                string dir_path = folderBrowserDialog_dst.SelectedPath;
                textBox_dst.Text = dir_path;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime final = new DateTime(2022, 1, 1);

            Stopwatch timer = new Stopwatch();
            timer.Start();
            if (DateTime.Compare(today, final)<0)
            {
                bool rv = Directory.Exists(textBox_src.Text) && Directory.Exists(textBox_src.Text);
                if (rv)
                {
                    Dispatcher d = new Dispatcher(textBox_src.Text, textBox_dst.Text);
                    listBox_src.DataSource = d.Work();
                    // MessageBox.Show(listBox_src.Items.Count.ToString(), "count");
                }
                button_start.BackColor = Color.FromArgb(0, 255, 0);
            }
            timer.Stop();
            TimeSpan ts = timer.Elapsed;
            string timeElapsed = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds/10);
            textBox_runtime.Text = timeElapsed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            button_start.BackColor = default(Color);
        }
    }
}
