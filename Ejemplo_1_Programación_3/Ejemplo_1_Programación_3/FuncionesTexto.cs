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
    public partial class FuncionesTexto : Form
    {
        public FuncionesTexto()
        {
            InitializeComponent();
        }

        private void ProcesarButton_Click(object sender, EventArgs e)
        {
            string cadena = CadenaTextBox.Text;

            //Metodo para mostrar la cantidad de caracteres en una oracion
            LongitudTextBox.Text = cadena.Length.ToString();

            //Metodo para mostrar la primer letra de una palabra u oracion
            PrimerCaracterTextBox.Text = cadena.Substring(0, 1);

            //Metodo para mostrar la ultima letra de una palabra u oracion
            UltimoCaracterTextBox.Text = cadena.Substring(cadena.Length - 1, 1);

            //Metodo para pasar a mayucula una oracion o palabra
            MayusculaTextBox.Text = cadena.ToUpper();

            //Metodo para pasar a minuscula una palabra u oracion
            MinusculaTextBox.Text = cadena.ToLower();
        }
    }
}
