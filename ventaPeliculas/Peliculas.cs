using System;

namespace ventaPeliculas
{
    public class Peliculas
    {
        private String codigoBarras;
        private String titulo;
        private String actPrinc;
        private String genero;
        private double precio;

        public void Pelicula()
        {
        }

        public void Pelicula(String codigoBarras, String titulo, String actPrinc, String genero, double precio)
        {
            this.codigoBarras = codigoBarras;
            this.titulo = titulo;
            this.actPrinc = actPrinc;
            this.genero = genero;
            this.precio = precio;
        }

        public String getCodigoBarras()
        {
            return codigoBarras;
        }

        public String getTitulo()
        {
            return titulo;
        }

        public String getActPrinc()
        {
            return actPrinc;
        }

        public String getGenero()
        {
            return genero;
        }

        public double getPrecio()
        {
            return precio;
        }

        public void setTitulo(String titulo)
        {
            this.titulo = titulo;
        }

        public void setActPrinc(String actPrinc)
        {
            this.actPrinc = actPrinc;
        }

        public void setGenero(String genero)
        {
            this.genero = genero;
        }

        public void setPrecio(double precio)
        {
            this.precio = precio;
        }

        public void setCodigoBarras(String codigoBarras)
        {
            this.codigoBarras = codigoBarras;
        }

        public override string ToString()
        {
            string cad;
            cad = getCodigoBarras() + "\t" + getTitulo() + "\t" + getActPrinc() + "\t" + getGenero() + "\t" + getPrecio();
            return cad;
        }
    }
}