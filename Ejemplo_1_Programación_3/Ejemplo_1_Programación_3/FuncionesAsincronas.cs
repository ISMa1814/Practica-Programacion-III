using System;
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
    public partial class FuncionesAsincronas : Form
    {
        public FuncionesAsincronas()
        {
            InitializeComponent();
        }

        //Cuando se utiliza el metodo ASINCRONO se debe de escribir "async" siempre junto con el "await" en el metodo asincrono
        private async void HornearPizzaButton_Click(object sender, EventArgs e)
        {
            //HornearPizza();
            await HornearPizzaAsync();
            label1.Text = "La Pizza Esta Lista";
        }

        private void HornearPizza()
        {
            Thread.Sleep(10000);
        }

        //Este es un METODO ASINCRONO, se debe de utilizar la palabras Task siempre
        private Task HornearPizzaAsync()
        {
            return Task.Delay(10000);
        }

        private void OtrasTareasButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Realizando otras Tareas", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void SumarButton_Click(object sender, EventArgs e)
        {
            decimal numero1 = Convert.ToDecimal(Numero1TextBox.Text);
            decimal numero2 = Convert.ToDecimal(Numero2TextBox.Text);

            MessageBox.Show("La Suma es: " + await SumarAsync(numero1,numero2));
        }

        private decimal Sumar(decimal numero1, decimal numero2)
        {
            return numero1 + numero2;
        }

        //Esta es una FUNCION ASINCRONA, se debe de escribir la palabra "async"
        private async Task<decimal> SumarAsync(decimal numero1, decimal numero2)
        {
            //El metodo "var" lo que hace es que identifica el valor de la variable
            var resultado = await Task.Run(() =>
            {
                return numero1 + numero2;
            });

            return resultado;
        }
    }
}
