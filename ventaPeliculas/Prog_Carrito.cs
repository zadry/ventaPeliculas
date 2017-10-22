using System;
using System.Collections;
using System.Windows.Forms;

namespace ventaPeliculas
{
    public partial class Prog_Carrito : Form
    {
        private ArrayList listaPeliculas;
        private ArrayList ventas;
        protected ComboBox cantidad;

        public Prog_Carrito()
        {
            InitializeComponent();
            listaPeliculas = new ArrayList();
            ventas = new ArrayList();
            rellenarCatalogo();
            cantidad = new ComboBox();
        }

        /*
         * proxy para rellenar el catalogo de datos
         * autor Javier Mornoy
         */

        public void rellenarCatalogo()
        {
            ReadWritePeliculas reader = new ReadWritePeliculas();
            ArrayList catalogo;//= new ArrayList();
            catalogo = reader.readCatalogo();
            if (catalogo == null)
            {
            }
            else
            {
                int i;
                Console.WriteLine("capcidad " + catalogo.Capacity);
                String row = "";

                for (i = 0; i < catalogo.Count; i++)
                {
                    listaPeliculas.Add(catalogo[i]);
                    listPeliculas.Items.Add(catalogo[i]);
                    // Console.WriteLine(catalogo[i]);
                }
            }
        }

        //manda a llamar a la ventana de agregarPeliculas
        private void agregarPeliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPelicula agp = new AgregarPelicula();
            agp.ShowDialog();

            Peliculas nuevaPel = agp.GetPeliculas();
            //guarda los datos en un arrayList y en el Listbox
            listaPeliculas.Add(nuevaPel);
            listPeliculas.Items.Add(nuevaPel);
        }

        //manda a llamar a la ventana DettallesCarrito y lo muestra en pantalla
        private void detallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetallesCarrito dc = new DetallesCarrito();
            dc.ShowDialog();
        }

        //Se activo el evento DoubleClick para seleccionar un dato del ListBOx
        private void listPeliculas_DoubleClick(object sender, EventArgs e)
        {
            int indeElem;
            indeElem = listPeliculas.SelectedIndex;

            DialogResult res = MessageBox.Show("¿Desea agregar un al carrito de compras?: " + listPeliculas.GetItemText(indeElem), "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //  DialogResult res2 = MessageBox.Show("Numero de piezas : " + cantidad.Text, "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Peliculas venta;// = new Peliculas();

                venta = (Peliculas)listaPeliculas[indeElem];

                ventas.Add(venta);
                //verificar si el cliente quiere seguir comprando peliculas
                DialogResult res2 = MessageBox.Show("¿Desea seguir comprando peliculas?: " + listPeliculas.GetItemText(indeElem), "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res2 == DialogResult.Yes)
                {
                }
                else
                {
                    DetallesCarrito fes = new DetallesCarrito(ventas);

                    fes.ShowDialog();
                }
            }
        }

        private void listPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ventas.Count <= 0)
            {
                DialogResult res3 = MessageBox.Show("Aun no a realizado ninguna compra.");
            }
            else
            {
                DetallesCarrito fes = new DetallesCarrito(ventas);

                fes.ShowDialog();
            }
        }
    }
}