namespace GestionBancaria
{
    public partial class Form1 : Form
    {
        private double saldo_fgm_2223 = 1000;  // Saldo inicial de la cuenta, 1000�

        public Form1()
        {
            InitializeComponent();
            txtSaldo.Text = saldo_fgm_2223.ToString();
            txtCantidad.Text = "0";
        }

        private bool realizarReintegro(double cantidad_fgm_2223)
        {           
            if (cantidad_fgm_2223 >= 0 && saldo_fgm_2223 >= cantidad_fgm_2223)
            {
                saldo_fgm_2223 -= cantidad_fgm_2223;
                return true;
            }
            return false;
        }

        private void realizarIngreso(double cantidad_fgm_2223)
        {
            if (cantidad_fgm_2223 > 0)
                saldo_fgm_2223 += cantidad_fgm_2223;
        }

        private void btOperar_Click(object sender, EventArgs e)
        {
            double cantidad_fgm_2223 = Convert.ToDouble(txtCantidad.Text); // Cogemos la cantidad del TextBox y la pasamos a n�mero
            if (cantidad_fgm_2223 < 0)
            {
                MessageBox.Show("Cantidad no v�lida, s�lo se admiten cantidades positivas.");
            }
            if (rbReintegro.Checked)
            {
                if (realizarReintegro(cantidad_fgm_2223) == false)  // No se ha podido completar la operaci�n, saldo insuficiente?
                    MessageBox.Show("No se ha podido realizar la operaci�n (�Saldo insuficiente?)");
            }
            if (rbIngreso.Checked)
                realizarIngreso(cantidad_fgm_2223);

            txtSaldo.Text = saldo_fgm_2223.ToString();
        }
    }
}