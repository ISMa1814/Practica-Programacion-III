﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_1_Programación_3
{
    public partial class FuncionRecursiva : Form
    {
        public FuncionRecursiva()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecorrerDeUnoEnUno(10, 30);
        }

        private void RecorrerDeUnoEnUno(int valorInicial, int valorFinal)
        {
            listBox1.Items.Add(valorInicial);

            if (valorInicial < valorFinal)
            {
                RecorrerDeUnoEnUno(valorInicial + 1, valorFinal);
            }
        }
    }
}
