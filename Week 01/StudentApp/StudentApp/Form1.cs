using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Student stu = new Student("Mary", "Blue"); // Class level variable
        Student stu = new Student(); // Class level variable

        private void Form1_Load(object sender, EventArgs e)
        {

            /* Not needed with new constructor
             * stu.StudentFirstName = "Biff";
             * stu.StudentLastName = "Arfus";*/

            nameLabel.Text = stu.StudentFullName;

            currentLabel.Text = stu.CurrentCredits.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                stu.AddCredits();
                currentLabel.Text = stu.CurrentCredits.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
