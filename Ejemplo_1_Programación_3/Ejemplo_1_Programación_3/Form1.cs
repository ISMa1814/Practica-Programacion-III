namespace Ejemplo_1_Programación_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SumarButton_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(Numero1TextBox.Text);
            int num2 = Convert.ToInt32(Numero2TextBox.Text);

            ResultadoTextBox.Text = Sumar(num1, num2).ToString();
        }

        private int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        private void MostrarMensaje()
        {
            MessageBox.Show("Este es un mensaje");
        }

        private void MostrarMensajeButton_Click(object sender, EventArgs e)
        {
            MostrarMensaje();
        }
    }
}