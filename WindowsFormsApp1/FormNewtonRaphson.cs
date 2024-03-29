﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1;

namespace WindowsFormsApp1
{
    public partial class FormNewtonRaphson : Form
    {
        public FormNewtonRaphson()
        {
            InitializeComponent();
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
        }

        private void FormNewtonRaphson_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label7.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;

            if (textBox2.Text != "" & textBox3.Text != "")
            {
                double xi = Convert.ToDouble(textBox2.Text);

                Newton_Raphson newton = new Newton_Raphson();
                Salida salida = new Salida();

                salida = newton.NewtonRaphson(xi);

                label1.Text = Convert.ToString(salida.Raiz);
                label12.Text = Convert.ToString(salida.NroIteraciones);
                label13.Text = Convert.ToString(salida.ErrorRelativo);
            }


        }
    }
}
