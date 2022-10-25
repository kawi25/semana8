using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string option = comboOperaciones.Text;
            string numero1 = TxtNum1.text;
            string numero2 = txtNum2.text;

            if (numero1 == " " || numero2 == " " || option == " ")
            {
                MessageBox.Show(" Ingresar los datos: ");
            }
            else
            {
                double num1 = double.Parse(numero1);
                double num2 = double.Parse(numero2);

                switch (option)
                {
                    case " Suma ":
                        MessageBox.Show(" La suma es: " + SUMA(num1, num2));
                        break;

                    case " Resta ":
                        MessageBox.Show(" La resta es: " + RESTA(num1, num2));
                        break;

                    case " Multiplicación ":
                        MessageBox.Show(" La multiplicación es : " + MULTI(num1, num2));
                        break;

                    case " División ":
                        MessageBox.Show(" La división es:   " + DIV(num1, num2));
                        break;
                }
            }
        }

    }
}
      
