using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_ExceptionHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int result = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
            }
            catch (DivideByZeroException ex)
            {
                throw new Exception("You can not divide any number by zero");
            }
            catch (Exception ex)
            {

                throw new Exception("Please use only numbers");
            }
            finally
            {
                MessageBox.Show("Program was finished");
            }
            

            int firstnumber = Convert.ToInt32(textBox1.Text);  
        }
    }
}
