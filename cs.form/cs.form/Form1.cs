using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs.form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Class1 aaa = new Class1(0,0,100,100);
            Controls.Add(aaa);

            Class1 bbb = new Class1(100,100,100,100);
            Controls.Add(bbb);
        }
    }
}
