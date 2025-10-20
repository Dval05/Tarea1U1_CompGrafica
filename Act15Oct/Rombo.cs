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
    public partial class Rombo : Form
    {
        public Rombo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float digM = float.Parse(txtDiagonalMayor.Text);
                float digm = float.Parse(txtDiagonalMenor.Text);

                if (digM <= 0 || digm <= 0)
                {
                    MessageBox.Show("Las diagonales deben ser mayores a 0");
                    return;
                }
                else if (digm >= digM)
                {
                    MessageBox.Show("La diagonal menor debe ser menor que la diagonal mayor");
                    return;
                } else {
                    float lado = (float)Math.Sqrt(Math.Pow(digM / 2, 2) + Math.Pow(digm / 2, 2));

                    float area = (digM * digm) / 2;
                    float perimetro = 4 * lado;
                    MessageBox.Show("\nLado calculado: " + Math.Round(lado, 2) 
                                       + "\nÁrea: " + Math.Round(area, 2) 
                                       + "\nPerímetro: " + Math.Round(perimetro, 2));
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
