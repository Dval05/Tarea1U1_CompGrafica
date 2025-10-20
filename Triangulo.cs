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
    public partial class Triangulo : Form
    {
        public Triangulo()
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
                    double area = (basee * altura) / 2;
                    double hipotenusa = Math.Sqrt(Math.Pow(basee, 2) + Math.Pow(altura, 2));
                    double perimetro = basee + altura + hipotenusa;
                    MessageBox.Show("El área del triángulo es: " + Math.Round(area, 2) + 
                                "\nEl perímetro del triángulo es: " + Math.Round(perimetro, 2));
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
