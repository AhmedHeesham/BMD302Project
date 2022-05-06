using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bmd302Project
{
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }
    }
}
