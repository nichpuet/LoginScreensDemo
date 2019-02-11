using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleScreensDemo
{
    public partial class Form1 : Form
    {
        public static string username = "nick";
        public static string password = "password";

        public Form1()
        {
            InitializeComponent();

            Screen1 s1 = new Screen1();
            this.Controls.Add(s1);
        }
    }
}
