using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechRec
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        SpeechSynthesizer reader = new SpeechSynthesizer();


        private void btnSpeak_Click(object sender, EventArgs e)
        {
            if (rtxtSpeak.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(rtxtSpeak.Text);
            }
            else
            {
                MessageBox.Show(@"Type in the textbox");
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (reader?.State == SynthesizerState.Speaking)
            {
                reader.Pause();
            }
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            if (reader?.State == SynthesizerState.Paused)
            {
                reader.Resume();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            reader?.Pause();
        }
    }
}
