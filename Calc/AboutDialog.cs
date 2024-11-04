using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
            userControl11.CustomEvent += userControl_CustomEvent;
        }

        void userControl_CustomEvent(object sender, string msg)
        {
            label2.Text = msg;
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        internal void changeLabel(string msg)
        {
            label1.Text = msg;
        }
    }
}
