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
    class TestButton:Button
    {
        Form1 _form1;
        public TestButton(Form1 form1,string strs,int x,int y,int width,int height)
        {
            _form1 = form1;
            Click += OnClick;

            Text = strs;

            Console.Write(Text);

            Location = new System.Drawing.Point(x,y);

            Size = new System.Drawing.Size(width,height);
        }
        /// <summary>
        /// ボタンをクリックした際の処理
        /// </summary>
        /// <param name="str"></param>
        public void OnClick(object sender, EventArgs s)
        {
            string t = _form1.ButtonLabelReplacement(Text);
            Text = t;
            _form1.LabelTextupdate(Text);
        }
    }
}

