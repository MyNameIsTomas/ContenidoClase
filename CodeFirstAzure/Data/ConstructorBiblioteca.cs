using CodeFirstAzure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstAzure.Data {
    public class ConstructorBiblioteca: System.Data.Entity.DropCreateDatabaseAlways<LibraryContext> {
        protected override void Seed(LibraryContext context) {
            base.Seed(context);
            var listageneros = new List<Genero> {
            new Genero{IdGenero=1, Nombre="Novela"},
            new Genero{IdGenero=2, Nombre="Terror"},
            new Genero{IdGenero=3, Nombre="Biografico"}
            };

            listageneros.ForEach(g => context.Generos.Add(g));
            context.SaveChanges();
            var listalibros = new List<Libro> {
            new Libro{ IdLibro=4, IdGenero=1, Nombre="La historia interminable", Autor="Michael Ende", Sinopsis="bla bla bla"},
            new Libro{ IdLibro=5, IdGenero=3, Nombre="La historia de Monlo", Autor="Manolo", Sinopsis="bla bla bla"},
            new Libro{ IdLibro=6, IdGenero=3, Nombre="La historia del carnicero", Autor="La del quinto", Sinopsis="bla bla bla"}
            };
            listalibros.ForEach(l => context.Libros.Add(l));
            context.SaveChanges();
        }
    }
}