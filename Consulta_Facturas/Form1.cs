using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consulta_Facturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int valor;

            if (!int.TryParse(Rut_ProTextBox.Text, out valor))

            {

                error.SetError(Rut_ProTextBox, "Complete Campo Solo Numerico");
                Rut_ProTextBox.Focus();
                return;


            }
            else
            {

                error.SetError(Rut_ProTextBox, "");

            }


            if (textBox2.Text.Trim() == "")
            {

                error.SetError(textBox2, "Complete Campo");
                textBox2.Focus();
                return;


            }
            else
            {

                error.SetError(textBox2, "");

            }



            if (textBox3.Text.Trim() == "")
            {

                error.SetError(textBox3, "Complete Campo");
                textBox3.Focus();
                return;


            }
            else
            {

                error.SetError(textBox3, "");

            }


            if (textBox3.Text.Trim() == "")
            {

                error.SetError(textBox3, "Complete Campo");
                textBox3.Focus();
                return;


            }
            else
            {

                error.SetError(textBox3, "");

            }



            int valo;

            if (!int.TryParse(textBox5.Text, out valo))

            {

                error.SetError(textBox5, "Complete Campo Solo Numerico");
                textBox5.Focus();
                return;


            }
            else
            {

                error.SetError(textBox5, "");

            }


            if (textBox6.Text.Trim() == "")
            {

                error.SetError(textBox6, "Complete Campo");
                textBox6.Focus();
                return;


            }
            else
            {

                error.SetError(textBox6, "");

            }


            if (textBox7.Text.Trim() == "")
            {

                error.SetError(textBox7, "Complete Campo");
                textBox7.Focus();
                return;


            }
            else
            {

                error.SetError(textBox7, "");

            }


            MessageBox.Show("Factura Ingresada", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk;


            Rut_ProTextBox.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            Rut_ProTextBox.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RUT no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
           

        }
    }
}
