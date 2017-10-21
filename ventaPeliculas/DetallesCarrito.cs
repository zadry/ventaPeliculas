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

        public DetallesCarrito()
        {
            InitializeComponent();
            carrCom = new ArrayList();
        }

        public DetallesCarrito(ArrayList ventas)
        {
            carrCom = ventas;
            InitializeComponent();
            //carrCom = new ArrayList();
            listPelic.Items.Add(carrCom[0]);
        }

        private void DetallesCarrito_Load(object sender, EventArgs e)
        {
        }

        private void listPelic_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}