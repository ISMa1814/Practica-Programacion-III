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
    public partial class Arreglos : Form
    {
        public Arreglos()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            //Vetores
            int[] arreglo = new int[5];

            arreglo[0] = 40;
            arreglo[1] = 10;
            arreglo[2] = 30;
            arreglo[3] = 60;
            arreglo[4] = 80;

            int[] arreglo2 = new int[6] { 41, 63, 45, 68, 74, 99 };

            int[] arreglo3 = new int[] { 2, 5, 1, 3, 7, 6 };

            int[] arreglo4 = { 5, 6, 7, 4, 3, 5, 7 };

            string[] arreglo5 = { "Lunes", "Marte", "Miercoles", "Jueves", "Viernes" };

            /*for (int i = 0; i < arreglo5.Length; i++)
            {
                listBox1.Items.Add(arreglo5[i]);
            }
            */

            //Esta es otra manera de mostrar un arreglo
            foreach (var item in arreglo5)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
