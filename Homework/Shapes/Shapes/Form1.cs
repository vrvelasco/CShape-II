using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        Cube cube = new Cube(2);
        Sphere sphere = new Sphere(3);
        Tetrahedron tetra = new Tetrahedron(4);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshShapes();
        }

        public void RefreshShapes()
        {
            // Cube
            cubeSizeLabel.Text = cube.Size.ToString("n2");
            cubeSurfLabel.Text = cube.SurfaceArea.ToString("n2");
            cubeVolLabel.Text = cube.Volume.ToString("n2");
            // Sphere
            sphereSizeLabel.Text = sphere.Size.ToString("n2");
            sphereSurfLabel.Text = sphere.SurfaceArea.ToString("n2");
            sphereVolLabel.Text = sphere.Volume.ToString("n2");
            // Tetra
            tetraSizeLabel.Text = tetra.Size.ToString("n2");
            tetraSurfLabel.Text = tetra.SurfaceArea.ToString("n2");
            tetraVolLabel.Text = tetra.Volume.ToString("n2");
        }

        private void enlargeButton_Click(object sender, EventArgs e)
        {
            cube.Enlarge(10);
            sphere.Enlarge(10);
            tetra.Enlarge(10);
            RefreshShapes();
        }

        private void negativeButton_Click(object sender, EventArgs e)
        {
            try
            {
                cube.Size = -1;
                sphere.Size = -1;
                tetra.Size = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Negative Size Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void biggerButton_Click(object sender, EventArgs e)
        {
            cube.Size = 5;
            sphere.Size = 5;
            tetra.Size = 5;
            RefreshShapes();
        }
    }
}
