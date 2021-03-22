using HolaMundo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace HolaMundo.Services
{
    public class PeliculasServices
    {
        public Pelicula ObtenerPelicula()
        {
            return new Pelicula
            {
                Titulo = "Liga de la Justicia",
                Duracion = 242,
                Pais = "USA",
                Publicacion = new DateTime(2020, 03, 18)
            };
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            var Pelicula1 = new Pelicula
            {
                Titulo = "Avengers Endgame",
                Duracion = 182,
                Pais = "USA",
                Publicacion = new DateTime(2019, 04, 29)
            };

            var Pelicula2 = new Pelicula
            {
                Titulo = "Liga de la Justicia, Zack Snyder",
                Duracion = 242,
                Pais = "USA",
                Publicacion = new DateTime(2020, 03, 18)
            };

            return new List<Pelicula> { Pelicula1, Pelicula2 };
        }
    }
}