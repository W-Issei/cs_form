using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace cs.form
{
    class TestTextBox : TextBox
    {
        public TestTextBox(string str, int x, int y, int width, int height)
        {

            Text = str;


            Location = new System.Drawing.Point(x, y);

            Size = new System.Drawing.Size(width, height);
        }
    }
}

