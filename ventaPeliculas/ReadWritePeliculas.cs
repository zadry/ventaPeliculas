using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace ventaPeliculas
{
    internal class ReadWritePeliculas
    {
        public void writePelicula(Peliculas nuevaEntrada)
        {
            string path = @"catalogo.txt";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(nuevaEntrada.getCodigoBarras());
                    sw.WriteLine(nuevaEntrada.getTitulo());
                    sw.WriteLine(nuevaEntrada.getActPrinc());
                    sw.WriteLine(nuevaEntrada.getGenero());
                    sw.WriteLine(nuevaEntrada.getPrecio());
                }
            }
            else
            {
                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(nuevaEntrada.getCodigoBarras());
                    sw.WriteLine(nuevaEntrada.getTitulo());
                    sw.WriteLine(nuevaEntrada.getActPrinc());
                    sw.WriteLine(nuevaEntrada.getGenero());
                    sw.WriteLine(nuevaEntrada.getPrecio());
                }
            }
        }

        public ArrayList readCatalogo()
        {
            ArrayList catalogo = new ArrayList();
            using (StreamReader sr = File.OpenText(@"catalogo.txt"))
            {
                string path = @"catalogo.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    catalogo = null;
                }
                else
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Peliculas peli = new Peliculas();
                        peli.setCodigoBarras(s);
                        peli.setTitulo(sr.ReadLine());
                        peli.setActPrinc(sr.ReadLine());
                        peli.setGenero(sr.ReadLine());
                        peli.setPrecio(Double.Parse(sr.ReadLine()));
                        catalogo.Add(peli);
                        Console.WriteLine(peli);
                    }
                }
            }
            return catalogo;
        }
    }
}