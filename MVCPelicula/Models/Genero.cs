﻿namespace MVCPelicula.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nombre { get; set; } 

        public ICollection<Pelicula> Peliculas { get; set; }
    }
}
