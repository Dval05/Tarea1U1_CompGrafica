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
    public partial class Cuadrado : Form
    {
        public Cuadrado()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float lado = float.Parse(txtLado.Text);

                if (lado <= 0 )
                {
                    MessageBox.Show("El valor debe ser mayores a 0");
                    return;
                }else
                {
                    float area = lado * lado;
                    float perimetro = 4 * lado;

                    MessageBox.Show("El área del cuadrado es: " + Math.Round(area, 2) +
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
