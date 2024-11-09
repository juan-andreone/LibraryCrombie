using System.Collections.Generic;

namespace LibraryCrombie
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string ID { get; set; }
        public List<Libro> LibrosPrestados { get; set; } = new List<Libro>();

        public Usuario(string nombre, string id)
        {
            Nombre = nombre;
            ID = id;
        }
    }
}