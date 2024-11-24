using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string textoTelegrama;

            char tipoTelegrama = 'o'; //Por defecto ordinario

            int numPalabras = 0;

            double coste;

            //Leo el telegrama
            textoTelegrama = txtBoxTexto.Text;

            // telegrama urgente?

            if (checkBoxUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }


            //Separa las palabras y las introduce en una estructura.

            String[] palabras = textoTelegrama.Split(' ');

            //Obtiene la longitud de la estructura, que será el número de palabras.

            numPalabras = palabras.Length; 

            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            else

            //Si el telegrama es urgente

            {
                if (tipoTelegrama == 'u')
                {
                    if (numPalabras <= 10)
                    {
                        coste = 5;
                    }
                    else
                    {
                        coste = 5 + 0.75 * (numPalabras - 10);
                    }
                }
                else
                {
                    coste = 0;
                }
            }
            txtBoxCoste.Text = coste.ToString() + " euros";
        }
    }
}
