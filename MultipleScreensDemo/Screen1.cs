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
    public partial class Screen1 : UserControl
    {
        string user = "";
        string pass = "";

        public Screen1()
        {
            InitializeComponent();

        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            user = UsernameInput.Text;
            pass = PasswordInput.Text;
            
            if (user == Form1.username && pass == Form1.password)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                Screen2 s2 = new Screen2();
                f.Controls.Add(s2);
            }
            else
            {
                wrongLabel.Visible = true;
            }
        }
    }
}
