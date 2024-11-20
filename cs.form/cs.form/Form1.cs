using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cs.form
{
    public partial class Form1 : Form
    {
        testlabel _testlabel;

        TestTextBox _TestTextBox;

        //Button1 _Button1;
        //TextBox1 _TextBox1;

        public Form1()
        {
            InitializeComponent();

            string[] strs =
            {
                "あか",
                "あお",
                "きいろ",
                "みどり",
                "くろ",
                "しろ",
                "ちゃいろ",
                "ピンク",
                "むらさき",
                "きみどり",
            };

            for(int i = 0; i < 10; i++)
            {
                TestButton aaa = new TestButton(this, strs[i],(i % 5) * 100,(i / 5)*100,  100, 100);
                Controls.Add(aaa);

            }

            


            _testlabel = new testlabel("ラベルです", 10, 300, 100, 50);
            Controls.Add(_testlabel);

            _TestTextBox = new TestTextBox("てきすとぼっくすです", 10, 400, 500, 100);

            Controls.Add(_TestTextBox);


            //課題4のやりかけ
            //Button1 cc= new Button1(this, "aa", 20, 500, 300, 100);
            //Controls.Add(cc);
            //string str1 = ;
            //
            //_TextBox1 = new TextBox1("てきすとぼっくす", 10, 600, 500, 100);
            //
            //Controls.Add(_TextBox1);


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
        
        public void LabelTextupdate(string str)
        {
            _testlabel.Textupdate(str);
        }

        //まずform1にクラス作成
        public string ButtonLabelReplacement(string str)
        {
            string s = _TestTextBox.TextReplacement(str);
            return s;
        }

    }
}
