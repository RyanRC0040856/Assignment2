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
                double length = double.Parse(textBox3.Text);
                double height = double.Parse(textBox2.Text);
                double width = double.Parse(textBox1.Text);

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

                double Volume = 4 * Math.PI * (Radius * Radius);

                label7.Text = "Volume=" + Volume;
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

                double Surfacearea = 4 *()

                label7.Text = "Surface area=" + Surfacearea
            }
            catch
            {
                MessageBox.Show("Error on imput");
            }
        }
    }
}
