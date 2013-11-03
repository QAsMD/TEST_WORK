using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VK_MUSIC_APP
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            comboBox1.Items.Add("None");
            comboBox1.Items.Add("256 MB");
            comboBox1.Items.Add("512 MB");
            comboBox1.Items.Add("1024 MB");
            comboBox1.Items.Add("Unlimited");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }
    }
}
