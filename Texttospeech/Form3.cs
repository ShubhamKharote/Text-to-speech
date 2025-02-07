using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Texttospeech
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter writer;
            writer = File.CreateText(textBox1.Text);
            string data = richTextBox1.Text;
            writer.WriteLine(data);
            writer.Close();
            MessageBox.Show("File is created " +textBox1.Text);
        }
    }
}
