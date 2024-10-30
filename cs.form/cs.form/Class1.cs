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
        public Class1()
        {
            Click += OnClick;
        }
        public void OnClick(object sender, EventArgs s)
        {
            MessageBox.Show("asdf");
        }
    }
}
