﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs.form
{
    internal class testlabel:Label
    {
        public testlabel(string str, int x, int y, int width, int height)
        {

            Text = str;


            Location = new Point(x, y);

            Size = new System.Drawing.Size(width, height);
        }
        public void Textupdate(string str)
        {
            Text = str;
        }
    }
}

