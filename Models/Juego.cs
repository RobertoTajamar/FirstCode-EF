using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.DynamicData;


namespace FirscodeProject.Models
{
    [TableName("Juegos")]
    public class Juego
    {
        [Key]
        public int IdJuego { get; set; }
        public String NombreJuego { get; set; }
        public String Descripcion { get; set; }

    }
}