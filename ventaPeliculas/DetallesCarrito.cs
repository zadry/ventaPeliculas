using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ventaPeliculas
{
    public partial class DetallesCarrito : Form
    {
        private ArrayList carrCom;
        private double total = 0;

        public DetallesCarrito()
        {
            InitializeComponent();
            carrCom = new ArrayList();
        }

        public DetallesCarrito(ArrayList ventas)
        {
            carrCom = ventas;

            InitializeComponent();
            fillCarrito();
            calcularTotal();
            label2.Text = "Total: $" + total;
            //carrCom = new ArrayList();
        }

        private void fillCarrito()
        {
            if (carrCom.Count > 0)
            {
                for (int i = 0; i < carrCom.Count; i++)
                {
                    listPelic.Items.Add((Peliculas)carrCom[i]);
                }
            }
        }

        /*
         *  Calcular total
         */

        private void calcularTotal()
        {
            for (int i = 0; i < carrCom.Count; i++)
            {
                total = total + ((Peliculas)carrCom[i]).getPrecio();
            }
        }

        private void DetallesCarrito_Load(object sender, EventArgs e)
        {
        }

        private void listPelic_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res2 = MessageBox.Show("¿Seguro que quiere realizar esta compra?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res2 == DialogResult.Yes)
            {
                carrCom = new ArrayList();
                listPelic.Items.Clear();
                fillCarrito();
                label2.Text = "Su compra fue realizada con EXITO";
            }
            else
            {
            }
        }
    }
}