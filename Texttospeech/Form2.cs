using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace Texttospeech
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SpeechSynthesizer sp = new SpeechSynthesizer();
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp.SpeakAsync(richTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sp.State == SynthesizerState.Paused)
            {
                sp.Resume();
            }
            else { sp.Pause(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(sp.State == SynthesizerState.Speaking) 
            {
                sp.Pause(); 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sp.Dispose();
        }
    }
}
