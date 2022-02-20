using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesLibreria;
//Aquí agregamos la Clases que creamos

namespace Ejemplo_1_Programación_3
{
    public partial class LlamarClases : Form
    {
        public LlamarClases()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Aqui utilizamos el Contructor que creamos
            Coche coche = new Coche(10, "Toyota");

            //Sino creamos un contructor podemos definir el objeto de esta forma
            coche.Modelo = "22R";
            coche.Precio = Convert.ToDecimal(100000.00);
            coche.Km = 150000;

            MessageBox.Show(coche.DevolverDatosCoche());
        }
    }
}
