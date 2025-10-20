using System;
using System.Linq;
using System.Windows.Forms;

namespace Act15Oct
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenChild<T>() where T : Form, new()
        {
            var existing = this.MdiChildren.OfType<T>().FirstOrDefault();
            if (existing != null)
            {
                if (existing.WindowState == FormWindowState.Minimized)
                    existing.WindowState = FormWindowState.Normal;
                existing.BringToFront();
                existing.Activate();
            }
            else
            {
                var child = new T
                {
                    MdiParent = this
                };
                child.Show();
            }
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild<Rectangulo>();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild<Cuadrado>();
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild<Triangulo>();
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild<Rombo>();
        }

        private void rombiodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild<Romboide>();
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild<Trapecio>();
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild<Circulo>();
        }

        private void polToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild<Poligono>();
        }
    }
}
