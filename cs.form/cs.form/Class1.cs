using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace cs.form
{
    class Class1:Button
    {
        public Class1(int x,int y,int width,int height)
        {
            Click += OnClick;
            Text = "ボタン";

            Location = new System.Drawing.Point(x,y);

            Size = new System.Drawing.Size(width,height);
        }
        public void OnClick(object sender, EventArgs s)
        {
            MessageBox.Show("asdf");
        }
    }
}
