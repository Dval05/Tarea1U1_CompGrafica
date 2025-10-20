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
    public partial class Rectangulo : Form
    {
        public Rectangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float ancho = float.Parse(txtAncho.Text);
                float altura = float.Parse(txtAltura.Text);

                if (ancho <= 0 || altura <= 0)
                {
                    MessageBox.Show("Los valores deben ser mayores a 0");
                    return;
                }
                else if (ancho == altura)
                {
                    MessageBox.Show("Los valores no deben ser iguales");
                }
                else
                {
                    float area = ancho * altura;
                    float perimetro = 2 * (ancho + altura); 
                    MessageBox.Show("El área del rectángulo es: " + Math.Round(area, 2) +
                                    "\nEl perímetro del rectángulo es: " + Math.Round(perimetro, 2));
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
