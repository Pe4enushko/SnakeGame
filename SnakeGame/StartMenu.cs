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
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }
        public bool clicked = false;
        public void Btn_Start_Click(object sender, EventArgs e)
        {
            clicked = true;
            Close();
        }
    }
}
