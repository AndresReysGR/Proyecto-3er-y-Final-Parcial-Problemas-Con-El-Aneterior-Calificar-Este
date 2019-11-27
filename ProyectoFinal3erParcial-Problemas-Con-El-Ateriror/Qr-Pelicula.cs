using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal3erParcial_Problemas_Con_El_Ateriror
{
    class Qr_Pelicula : T_Extra2
    {
      
        public Qr_Pelicula(string titulo, int año, string director, string genero, string sinopsis, int rating)
        {

            this.Titulo = titulo;
            this.Año = año;
            this.Genero = genero;
            this.Director = director;
            this.Sinopsis = sinopsis;
            this.Rating = rating;
            Tipo = "Pelicula";
        }
      
    }
}
