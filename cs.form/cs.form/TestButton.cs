using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace cs.form
{
    class TestButton:Button
    {
        Form1 _form1;
        public TestButton(Form1 form1, int id,int x,int y,int width,int height)
        {
            _form1 = form1;
            Click += OnClick;

            Text = id.ToString();

            Console.Write(Text);

            Location = new System.Drawing.Point(x,y);

            Size = new System.Drawing.Size(width,height);
        }
        public void OnClick(object sender, EventArgs s)
        {
            _form1.LabelUpdate(Text);
        }
    }
}
