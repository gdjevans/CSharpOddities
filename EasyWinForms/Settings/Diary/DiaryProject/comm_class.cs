using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryProject
{
    public static class comm_class
    {
        public static void my_error_msg(string error_text)
        {
            MessageBox.Show("Error" + error_text);
        }
    }
}
