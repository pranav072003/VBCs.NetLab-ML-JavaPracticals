using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_operations_in_dotnet
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string userInput = textBox1.Text;
                int num = int.Parse(userInput);
                MessageBox.Show("You entered " + num.ToString());
            }
            catch (FormatException ex)
            {
                // raise error
                MessageBox.Show("Format error raised!");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                // end the program
                MessageBox.Show("Code ended!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 10;
                int b = 5;
                int c = a / b;
                // print the result
                MessageBox.Show(c.ToString());
            }
            catch (ArithmeticException ex)
            {
                // raise error
                // does not print default handler's message
            }
            finally
            {
                // end the program
                MessageBox.Show("Code ended!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
