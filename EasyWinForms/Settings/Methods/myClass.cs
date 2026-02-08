using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public static class myClass
    {
        public static void myMsg()
        {
            MessageBox.Show("Hi, I'm in Method");
        }

        public static Int32 sum_calc(Int32 fnum, Int32 snum)
        {
            Int32 rn;
            // ----------------
            rn = fnum + snum;
            return rn;
        }

        public static Int32 sum_calcTextbox(TextBox fn_Textbox, TextBox sn_Textbox)
        {
            Int32 fnum;
            Int32 snum;
            Int32.TryParse(fn_Textbox.Text, out fnum);
            Int32.TryParse(sn_Textbox.Text, out snum);
            Int32 rnum;
            rnum = fnum + snum;
            return rnum;
        }

        public static void msg_textbox(TextBox tb)
        {
            string t;
            t = tb.Text;
            MessageBox.Show(t);
        }
    }
}
