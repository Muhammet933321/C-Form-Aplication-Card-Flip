using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlamaOyun
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void PlayEasyBtn_Click(object sender, EventArgs e)
        {
            Form form = new GameEasy();
            form.Show();
        }

        private void PlayMideumBtn_Click(object sender, EventArgs e)
        {
            Form form = new GameMideum();
            form.Show();
        }

        private void PlayHardBtn_Click(object sender, EventArgs e)
        {
            Form form = new GameHard();
            form.Show();
        }
    }
}
