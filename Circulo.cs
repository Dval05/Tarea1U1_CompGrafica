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
    public partial class Circulo : Form
    {
        public Circulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float radio = float.Parse(txtRadio.Text);
                if (radio <= 0)
                {
                    MessageBox.Show("El valor del radio debe ser mayor a 0");
                    return;
                }
                else
                {
                    double area = Math.PI * Math.Pow(radio, 2);
                    double perimetro = 2 * Math.PI * radio;
                    MessageBox.Show("El área del círculo es: " + Math.Round(area, 2) +
                                    "\nEl perímetro del círculo es: " + Math.Round(perimetro, 2));
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
