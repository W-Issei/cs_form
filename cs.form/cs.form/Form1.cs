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

            for(int i = 0; i < 10; i++)
            {
                Class1 aaa = new Class1(i,(i % 5) * 100,(i / 5)*100,  100, 100);
                Controls.Add(aaa);

            }


            
            //Class1 aaa = new Class1(0,0,100,100);
            //Controls.Add(aaa);
            //
            //Class1 bbb = new Class1(100,100,100,100);
            //Controls.Add(bbb);
            //
            //Class1 bbb = new Class1(100, 100, 100, 100);
            //Controls.Add(bbb);
            //
            //Class1 ccc = new Class1(100, 100, 100, 100);
            //Controls.Add(ccc);
            //
            //Class1 ddd = new Class1(100, 100, 100, 100);
            //Controls.Add(ddd);
            //
            //Class1 e = new Class1(100, 100, 100, 100);
            //Controls.Add(e);
            //
            //Class1 f = new Class1(100, 100, 100, 100);
            //Controls.Add(f);
            //
            //Class1 g = new Class1(100, 100, 100, 100);
            //Controls.Add(g);
            //
            //Class1 h = new Class1(100, 100, 100, 100);
            //Controls.Add(h);
            //
            //Class1 i = new Class1(100, 100, 100, 100);
            //Controls.Add(i);
            
        }
    }
}
