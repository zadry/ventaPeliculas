namespace ventaPeliculas
{
    partial class Prog_Carrito
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listaDePeliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPeliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carritoDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listPeliculas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDePeliculasToolStripMenuItem,
            this.carritoDeComprasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listaDePeliculasToolStripMenuItem
            // 
            this.listaDePeliculasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPeliculaToolStripMenuItem});
            this.listaDePeliculasToolStripMenuItem.Name = "listaDePeliculasToolStripMenuItem";
            this.listaDePeliculasToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.listaDePeliculasToolStripMenuItem.Text = "Lista de peliculas";
            // 
            // agregarPeliculaToolStripMenuItem
            // 
            this.agregarPeliculaToolStripMenuItem.Name = "agregarPeliculaToolStripMenuItem";
            this.agregarPeliculaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.agregarPeliculaToolStripMenuItem.Text = "Agregar pelicula";
            this.agregarPeliculaToolStripMenuItem.Click += new System.EventHandler(this.agregarPeliculaToolStripMenuItem_Click);
            // 
            // carritoDeComprasToolStripMenuItem
            // 
            this.carritoDeComprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detallesToolStripMenuItem});
            this.carritoDeComprasToolStripMenuItem.Name = "carritoDeComprasToolStripMenuItem";
            this.carritoDeComprasToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.carritoDeComprasToolStripMenuItem.Text = "Carrito de compras";
            // 
            // detallesToolStripMenuItem
            // 
            this.detallesToolStripMenuItem.Name = "detallesToolStripMenuItem";
            this.detallesToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.detallesToolStripMenuItem.Text = "Detalles";
            this.detallesToolStripMenuItem.Click += new System.EventHandler(this.detallesToolStripMenuItem_Click);
            // 
            // listPeliculas
            // 
            this.listPeliculas.ColumnWidth = 85;
            this.listPeliculas.FormattingEnabled = true;
            this.listPeliculas.Location = new System.Drawing.Point(21, 80);
            this.listPeliculas.MultiColumn = true;
            this.listPeliculas.Name = "listPeliculas";
            this.listPeliculas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listPeliculas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listPeliculas.Size = new System.Drawing.Size(794, 225);
            this.listPeliculas.TabIndex = 1;
            this.listPeliculas.SelectedIndexChanged += new System.EventHandler(this.listPeliculas_SelectedIndexChanged);
            this.listPeliculas.DoubleClick += new System.EventHandler(this.listPeliculas_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "codigoBarras      Titulo           ActorPrincipal           Genero            Pre" +
    "cio\r\n\r\n\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ver Carrito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Prog_Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 459);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPeliculas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Prog_Carrito";
            this.Text = "Programa de Carrito de compras";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listaDePeliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carritoDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detallesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPeliculaToolStripMenuItem;
        private System.Windows.Forms.ListBox listPeliculas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

