using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Datos
{
    public class Autor
    {
        Modelo.BibliotecaEntities db = new Modelo.BibliotecaEntities();
        public void Agregar(Modelo.Autore pAutor)
        {
            db.Autores.Add(pAutor);
            db.SaveChanges();
        }
        public List<Modelo.Pais> TraerPaises()
        {
            return db.Paises.ToList(); // retorna una lista de todos los paises
        }
        public List<Modelo.VistaAutore> TraerAutores()
        {
            return db.VistaAutores.ToList();
        }
        public List<Modelo.Autore> TraerAutores(int pais)
        {
            var autores = from a in db.Autores
                          where a.Nacionalidad == pais
                          select a;
            return autores.ToList();
        }
    }
}
