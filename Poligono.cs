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
    public partial class Poligono : Form
    {
        public Poligono()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float lados = float.Parse(txtLados.Text);
                float basee = float.Parse(txtBase.Text);

                
                if (lados <= 4)
                {
                    MessageBox.Show("El número de lados debe ser mayor a 4 para un polígono regular.");
                    return;
                }
                else if (lados <= 0 || basee <= 0)
                {
                    MessageBox.Show("Los valores ingresados deben ser mayores a 0.");
                    return;
                }
                else
                {
                    double apotema = basee * Math.Sqrt(3) / 2;
                    float perimetro = lados * basee;
                    double area = (perimetro * apotema) / 2;

                    MessageBox.Show("El perímetro del polígono es: " + Math.Round(perimetro, 2) +
                                    "\nEl área del polígono es: " + Math.Round(area, 2) +
                                    "\nApotema calculada: " + Math.Round(apotema, 2));

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
