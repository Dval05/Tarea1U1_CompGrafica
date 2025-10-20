using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act15Oct
{
    public partial class Trapecio : Form
    {
        public Trapecio()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float baseMayor = float.Parse(txtBaseMayor.Text);
                float baseMenor = float.Parse(txtBaseMenor.Text);
                float altura = float.Parse(txtAltura.Text);

                if( baseMayor <= 0 || baseMenor <= 0 || altura <= 0 )
                {
                    MessageBox.Show("Los valores deben ser mayores a 0");
                    return;
                }
                else if (baseMayor == baseMenor)
                {
                    MessageBox.Show("Las bases no deben ser iguales");
                }
                else
                {
                    double area = ((baseMayor + baseMenor) * altura) / 2;
                    double lado = Math.Sqrt(Math.Pow((baseMayor - baseMenor) / 2, 2) + Math.Pow(altura, 2));
                    double perimetro = baseMayor + baseMenor + 2 * lado;
                    MessageBox.Show("El área del trapecio es: " + Math.Round(area, 2) +
                                    "\nEl perímetro del trapecio es: " + Math.Round(perimetro, 2));
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe ingresar solo números válidos en los campos.");
            }
            catch (Exception)
            {
                MessageBox.Show("Complete todos los parámetros.");
            }
        }
    }
}
