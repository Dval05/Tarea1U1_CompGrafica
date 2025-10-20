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
    public partial class Romboide : Form
    {
        public Romboide()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float basee = float.Parse(txtBase.Text);
                float altura = float.Parse(txtAltura.Text);

                if (basee <= 0 || altura <= 0)
                {
                    MessageBox.Show("Los valores deben ser mayores a 0");
                    return;
                }               
                else
                {
                    float area = basee * altura;
                    float perimetro = 2 * (basee + altura);
                    MessageBox.Show("El área del romboide es: " + Math.Round(area,2)+
                                    "\nEl perímetro del romboide es: " + Math.Round(perimetro, 2));
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
