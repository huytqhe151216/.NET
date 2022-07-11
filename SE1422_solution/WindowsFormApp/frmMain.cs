using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class frmMain : Form
    {
        ComboBox combo1;
        public frmMain()
        {
            InitializeComponent();
            combo1 = new ComboBox();
            combo1.Items.Add("item1");
            combo1.Items.Add("item2");
        }
    }
}
