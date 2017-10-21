using System;
using System.Windows.Forms;

namespace ventaPeliculas
{
    public partial class AgregarPelicula : Form
    {
        private Peliculas nuevaPelicula;

        public AgregarPelicula()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            nuevaPelicula = new Peliculas();
            nuevaPelicula.setCodigoBarras(tB_Codigo.Text);
            nuevaPelicula.setTitulo(tB_titulo.Text);
            nuevaPelicula.setActPrinc(tB_actor.Text);
            try
            {
                nuevaPelicula.setGenero(tB_actor.Text);
                double b = Convert.ToDouble(tB_precio.Text);
                b = double.Parse(tB_precio.Text);
                nuevaPelicula.setPrecio(b);
            }
            catch (FormatException)
            {
                DialogResult noValid = MessageBox.Show("no se pueden ingresar letras");
            }
            Hide();
        }

        public Peliculas GetPeliculas()
        {
            return nuevaPelicula;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        //valida qu esolo se pueda ingresar numeros
        public void soloNumeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tB_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
    }
}