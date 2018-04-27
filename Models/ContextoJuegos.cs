using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace FirscodeProject.Models
{
    public class ContextoJuegos : DbContext
    {
        public DbSet<Juego> Juegos { get; set; }

        public ContextoJuegos () : base("conexionLocal")
        {

        }

        //no llame a nuestra tabla Jugador = Jugadors.
        //System.Data.Entity.ModelConfiguration.Conventions;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}