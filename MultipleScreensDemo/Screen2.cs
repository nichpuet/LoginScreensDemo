using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleScreensDemo
{
    public partial class Screen2 : UserControl
    {
        public Screen2()
        {
            InitializeComponent();

            label2.Text = "welcome " + Form1.username;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
