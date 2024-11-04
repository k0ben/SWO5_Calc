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
    public partial class UserControl1 : UserControl
    {
        public delegate void CustomEventHandler(object sender, string message);
        public event CustomEventHandler CustomEvent;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            CustomEvent?.Invoke(this, $"{btn.Name} from control");
        }
    }
}
