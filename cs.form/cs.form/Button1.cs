using cs.form;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;


namespace cs.form
{
    public class Button1:Button
    {
        Form1 _form1;
        public Button1(Form1 form1, string str1, int a, int b, int width, int height)
        {
            _form1 = form1;
            Click += OnClick;
            
            Text = str1;
            
            Location = new Point(a, b);
            
            Size = new Size(width, height);
        }
        public void OnClick(object sender, EventArgs s)
        {
            _form1.LabelTextupdate(Text);
        }

        
    }
}
    

