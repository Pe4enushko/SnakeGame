using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class FailForm : Form
    {
        public FailForm()
        {
            InitializeComponent();
        }

        private void Btn_Return_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Close();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
