using System.Collections;

namespace ventaPeliculas
{
    partial class DetallesCarrito
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        ArrayList compras;
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
            this.label1 = new System.Windows.Forms.Label();
            this.listPelic = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista del carrito :";
            // 
            // listPelic
            // 
            this.listPelic.FormattingEnabled = true;
            this.listPelic.Location = new System.Drawing.Point(12, 41);
            this.listPelic.Name = "listPelic";
            this.listPelic.Size = new System.Drawing.Size(250, 134);
            this.listPelic.TabIndex = 1;
            this.listPelic.SelectedIndexChanged += new System.EventHandler(this.listPelic_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular Total";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total : $";
            // 
            // DetallesCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 392);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listPelic);
            this.Controls.Add(this.label1);
            this.Name = "DetallesCarrito";
            this.Text = "DetallesCarrito";
            this.Load += new System.EventHandler(this.DetallesCarrito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listPelic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}