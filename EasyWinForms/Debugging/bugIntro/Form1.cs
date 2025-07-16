using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bugIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.IO.File.Delete("F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\Debugging\\bugIntro\\koala.jpg");

            //-------------------
            //Snippet Usage
            //-------------------

            //for (int i = 0; i < length; i++)
            //{

            //}

            //if (true)
            //{

            //}

            //MessageBox.Show("Test");
            //
            try 
            {
                string fn;
                fn = ("F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\Debugging\\bugIntro\\koala.jpg";
                if (System.IO.File.Exists(fn) == true) 
                {
                    System.IO.File.Delete(fn);
                }

            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error! - " + ex.ToString());
            }

        }
    }
}
