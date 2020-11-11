using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //These are the measurments that will be read from the boxes and used in the calculatinon
                double length = double.Parse(textBox3.Text);
                double height = double.Parse(textBox2.Text);
                double width = double.Parse(textBox1.Text);
                //This is the calculation to get the colume of the cubeoid
                double volume = width * length * height;

                label4.Text = "Voume= " + volume;
            }
            catch
            {
                MessageBox.Show("Error on imput");
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                double length = double.Parse(textBox3.Text);
                double height = double.Parse(textBox2.Text);
                double width = double.Parse(textBox1.Text);

                double SurfaceArea = 2.0 * (length * height + length * width + width * height);

                label5.Text = "SA= " + SurfaceArea;
            }
            catch
            {
                MessageBox.Show("Error on imput");
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                double Radius = double.Parse(textBox4.Text);

                double Surfacearea = 4.0 * Math.PI * (Radius * Radius);

                label7.Text = "Surface area=" + Surfacearea;
            }
            catch
            {
                MessageBox.Show("Error on imput");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                double Radius = double.Parse(textBox4.Text);

                double Volume = 4.0 / 3.0 * (Math.PI * (Radius * Radius * Radius));

                label8.Text = "Volume=" + Volume;
            }
            catch
            {
                MessageBox.Show("Error on imput");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                double Radius = double.Parse(textBox5.Text);
                double height = double.Parse(textBox6.Text);

                double Surfacearea = Math.PI * Radius * (Radius + Math.Sqrt((height * height) + (Radius * Radius)));

                label9.Text = "surface area=" + Surfacearea;
            }
            catch
            {
                MessageBox.Show("Error on imput");
            }
        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                double Radius = double.Parse(textBox5.Text);
                double height = double.Parse(textBox6.Text);
                
                double Volume = 1.0 / 3.0 * Math.PI * (Radius * Radius) * height;

                label10.Text = "Volume=" + Volume;
            }
            catch
            {
                MessageBox.Show("Error on imput");
            }
        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }
    }
}
