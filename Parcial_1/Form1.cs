using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1ConvertirConversores_Click(object sender, EventArgs e)
        {
            int de = 0, a = 0;
            double cantidad = 0, respuesta = 0 ;

            de = cbo1DeConversores.SelectedIndex;
            a = cbo2Aconversores.SelectedIndex;

            cantidad = double.Parse(txt1CantidadConversores.Text);
            double[] Area = { 1, 0.092900304, 0.698896, 0.836127, 437.5, 7000, 10000 };
            respuesta = Area [a] / Area [de] * cantidad;

            lblrespuestaconversores.Text = "Respuesta: " + Math.Round(respuesta, 5);

    }

        private void txt1CantidadConversores_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblrespuestaconversores_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }