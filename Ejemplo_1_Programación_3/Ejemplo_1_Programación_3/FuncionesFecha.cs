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
    public partial class FuncionesFecha : Form
    {
        public FuncionesFecha()
        {
            InitializeComponent();
        }

        private void ProcesarButton_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTimePicker.Value;
            
            //Metodo para mostrar el dia en numero
            DiaTextBox.Text = fecha.Day.ToString();

            //Metodo para mostrar el mes en numero
            MesTextBox.Text = fecha.Month.ToString();

            //Metodo para mostrar el año en numero
            AnioTextBox.Text = fecha.Year.ToString();

            //Metodo para mostrar el dia en letras
            DiaLetraTextBox.Text = fecha.ToString("dddd");

            //Metodo para sumar los dias (para restar solo se pone el valor en negativo)
            SumaDiasTextBox.Text = fecha.AddDays(25).ToShortDateString();

            EdadTextBox.Text = DevolverEdad(fecha).ToString();
        }

        //Metodo para calcular la edad
        private int DevolverEdad(DateTime _FechaNacimiento)
        {
            DateTime fechaNacimiento = _FechaNacimiento;
            //Metodo para tener la fecha actual
            DateTime fechaActual = DateTime.Now;

            int edad = 0;

            if (fechaNacimiento > fechaActual)
            {
                MessageBox.Show("La fecha de nacimiento es mayor a la feccha actual\nPor Favor intente de nuevo");
                return 0;
            }
            else
            {
                edad = fechaActual.Year - fechaNacimiento.Year;
                if (fechaNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                }
            }

            return edad;
        }
    }
}
