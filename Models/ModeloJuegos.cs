using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirscodeProject.Models
{
    public class ModeloJuegos
    {
        ContextoJuegos contexto;
        public ModeloJuegos()
        {
            this.contexto = new ContextoJuegos();
        }

        public List<Juego> ListaJuegos()
        {
            var consulta = from datos in contexto.Juegos
                           select datos;
            return consulta.ToList();
        }

        public Juego BuscarJuego(int idJuego)
        {
            var consulta = from datos in contexto.Juegos
                           where datos.IdJuego == idJuego
                           select datos;
            return consulta.FirstOrDefault();
        }
        public int GetMaximoJuegoId()
        {
            var consulta = from datos in contexto.Juegos
                           select datos;
            if (consulta.Count() == 0)
            {
                return 1;
            }
            else
            {
                return consulta.Max(z => z.IdJuego) + 1;
            }
        }

        public void InsertarJuego(string nombre, String descripcion)
        {
            Juego j = new Juego();
            j.IdJuego = this.GetMaximoJuegoId();
            j.NombreJuego = nombre;
            j.Descripcion = descripcion;

            contexto.Juegos.Add(j);
            contexto.SaveChanges();
        }

        public void ModificarJuego (int idJuego, string nombre, String descripcion)
        {
            Juego j = this.BuscarJuego(idJuego);
            j.NombreJuego = nombre;
            j.Descripcion = descripcion;

            contexto.SaveChanges();
            
        }

        public void EliminarJuego(int idJuego)
        {
            Juego j = BuscarJuego(idJuego);
            contexto.Juegos.Remove(j);
            contexto.SaveChanges();
        }
    }
}