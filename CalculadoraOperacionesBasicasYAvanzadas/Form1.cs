using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraOperacionesBasicasYAvanzadas
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (interfaz != 1)
            { Interfaz(1); return; }
            double a, b;
            try
            {
                a = double.Parse(txtValor1.Text);
                b = double.Parse(txtValor2.Text);
                string suma = (a + b).ToString();
                Resultado.Text = suma;
            }
            catch
            { MessageBox.Show("Valores Ingresados incorrectos"); }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (interfaz != 1)
            { Interfaz(1); return; }
            double a, b;
            try
            {
                a = double.Parse(txtValor1.Text);
                b = double.Parse(txtValor2.Text);
                string resta = (a - b).ToString();
                Resultado.Text = resta;
            }
            catch
            { MessageBox.Show("Valores Ingresados incorrectos"); }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (interfaz != 1)
            { Interfaz(1); return; }
            double a, b;
            try
            {
                a = double.Parse(txtValor1.Text);
                b = double.Parse(txtValor2.Text);
                string producto = (a * b).ToString();
                Resultado.Text = producto;
            }
            catch
            { MessageBox.Show("Valores Ingresados incorrectos"); }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (interfaz != 1)
            { Interfaz(1); return; }
            double a, b;
            try
            {
                a = double.Parse(txtValor1.Text);
                b = double.Parse(txtValor2.Text);
                string division = (a / b).ToString();
                Resultado.Text = division;
            }
            catch
            { MessageBox.Show("Valores Ingresados incorrectos"); }
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            if (interfaz != 1)
            { Interfaz(1); return; }
            double a, b;
            try
            {
                a = double.Parse(txtValor1.Text);
                b = double.Parse(txtValor2.Text);
                if (Math.Max(a, b) == a)
                { Resultado.Text = "Max = " + a + "Min = " + b; return; }
                Resultado.Text = "Max = " + b + " Min = " + a;
            }
            catch
            { MessageBox.Show("Valores Ingresados incorrectos"); }
        }

        private void btnRedondear_Click(object sender, EventArgs e)
        {
            try
            { MessageBox.Show((Math.Round(double.Parse(Resultado.Text))).ToString()); }
            catch { MessageBox.Show("El resultado no se puede redondear"); }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            Interfaz(2);
        }

        private void btnPotenciaRaiz_Click(object sender, EventArgs e)
        {
            Interfaz(3);
        }

        private void opcion1_Click(object sender, EventArgs e)
        {
            if (interfaz == 2)
            {
                Resultado.Text = (Math.PI * 2 * (double.Parse(txtValor1.Text))).ToString();
                return;
            }
            if (interfaz == 3)
            {
                double a = 0;
                int b = 0;
                try
                {
                    a = double.Parse(txtValor1.Text);
                    b = int.Parse(txtValor2.Text);
                    Resultado.Text = (Math.Pow(a, b)).ToString();
                }
                catch
                { MessageBox.Show("El valor ingresado es incorrecto (valor 1 debe ser Double, valor 2 Entero"); }
            }
        }
        private void opcion2_Click(object sender, EventArgs e)
        {
            if (interfaz == 2)
            {
                Resultado.Text = (Math.PI * (Math.Pow(double.Parse(txtValor1.Text),2 ))).ToString();
                return;
            }
            if (interfaz == 3)
            {
                double a = 0;
                int b = 0;
                try
                {
                    a = double.Parse(txtValor1.Text);
                    b = int.Parse(txtValor2.Text);
                    double exponente = Math.Pow(b, -1);
                    Resultado.Text = (Math.Pow(a,exponente)).ToString();
                }
                catch
                { MessageBox.Show("El valor ingresado es incorrecto (valor 1 debe ser Double, valor 2 Entero"); }
            }
        }

        int interfaz = 1;
        Button opcion1 = new Button();
        Button opcion2 = new Button();
        private void Interfaz(int i)
        {
            Controls.Add(opcion1);
            opcion1.Click += new EventHandler(opcion1_Click);
            
            Controls.Add(opcion2);
            opcion2.Click += new EventHandler(opcion2_Click);

            if (i == 1)
            {
                opcion1.Size = new Size(0, 25);
                opcion2.Size = new Size(0, 25);

                Resultado.Visible = true;
                Resultado.Location = new Point(225, 67);
                txtValor2.Visible = true;
                label1.Text = "Valor 1";
                label2.Visible = true;
                label2.Text = "Valor 2";
                interfaz = 1;
                return;
            }

            if (i == 2)
            {
                opcion1.Size = new Size(90, 25);
                opcion2.Size = new Size(60, 25);
                opcion1.Text = "Circunferencia";
                opcion1.Location = new Point(90, 89);
                opcion2.Text = "Area";
                opcion2.Location = new Point(190, 89);

                txtValor2.Visible = false;
                label1.Text = "Radio";
                label2.Visible = false;
                Resultado.Location = new Point(210, 43);
                txtValor1.Clear();
                txtValor2.Clear();
                interfaz = 2;
                return;
            }

            if (i ==  3)
            {
                opcion1.Size = new Size(90, 25);
                opcion2.Size = new Size(60, 25);
                opcion1.Text = "Potencia";
                opcion1.Location = new Point(200, 43);
                opcion2.Text = "Raiz";
                opcion2.Location = new Point(300, 43);

                Resultado.Location = new Point(225, 89);
                txtValor2.Visible = true;
                label1.Text = "Valor";
                label2.Text = " p / r";
                label2.Visible = true;
                interfaz = 3;
                return;
            }
        }
    }
}
