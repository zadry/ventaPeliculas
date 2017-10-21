namespace ventaPeliculas
{
    partial class AgregarPelicula
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
            this.btAgregar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_Codigo = new System.Windows.Forms.TextBox();
            this.tB_titulo = new System.Windows.Forms.TextBox();
            this.tB_actor = new System.Windows.Forms.TextBox();
            this.tB_genero = new System.Windows.Forms.TextBox();
            this.tB_precio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(48, 201);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(226, 200);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo de barras :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Actor principal :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Genero :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Precio : $";
            // 
            // tB_Codigo
            // 
            this.tB_Codigo.Location = new System.Drawing.Point(148, 22);
            this.tB_Codigo.Name = "tB_Codigo";
            this.tB_Codigo.Size = new System.Drawing.Size(142, 20);
            this.tB_Codigo.TabIndex = 7;
            // 
            // tB_titulo
            // 
            this.tB_titulo.Location = new System.Drawing.Point(148, 57);
            this.tB_titulo.Name = "tB_titulo";
            this.tB_titulo.Size = new System.Drawing.Size(142, 20);
            this.tB_titulo.TabIndex = 8;
            // 
            // tB_actor
            // 
            this.tB_actor.Location = new System.Drawing.Point(148, 90);
            this.tB_actor.Name = "tB_actor";
            this.tB_actor.Size = new System.Drawing.Size(142, 20);
            this.tB_actor.TabIndex = 9;
            // 
            // tB_genero
            // 
            this.tB_genero.Location = new System.Drawing.Point(148, 124);
            this.tB_genero.Name = "tB_genero";
            this.tB_genero.Size = new System.Drawing.Size(142, 20);
            this.tB_genero.TabIndex = 10;
            // 
            // tB_precio
            // 
            this.tB_precio.Location = new System.Drawing.Point(148, 159);
            this.tB_precio.Name = "tB_precio";
            this.tB_precio.Size = new System.Drawing.Size(142, 20);
            this.tB_precio.TabIndex = 11;
            // 
            // AgregarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 339);
            this.Controls.Add(this.tB_precio);
            this.Controls.Add(this.tB_genero);
            this.Controls.Add(this.tB_actor);
            this.Controls.Add(this.tB_titulo);
            this.Controls.Add(this.tB_Codigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAgregar);
            this.Name = "AgregarPelicula";
            this.Text = "AgregarPelicula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_Codigo;
        private System.Windows.Forms.TextBox tB_titulo;
        private System.Windows.Forms.TextBox tB_actor;
        private System.Windows.Forms.TextBox tB_genero;
        private System.Windows.Forms.TextBox tB_precio;
    }
}