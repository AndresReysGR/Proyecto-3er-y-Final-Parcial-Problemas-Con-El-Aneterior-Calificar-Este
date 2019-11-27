using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal3erParcial_Problemas_Con_El_Ateriror
{
    class Rs_Serie : T_Extra2
    {
       
        public Rs_Serie(string titulo, int año, string genero, int temporada, string productor, string descripcion, int rating)
        {
            this.Titulo = titulo;
            this.Año = año;
            this.Genero = genero;
            this.Temporada = temporada;
            this.Productor = productor;
            this.Descripcion = descripcion;
            this.Rating = rating;
            Tipo = "Serie";
        }
        public override string ToString()
        {
            return this.Titulo + "   " + this.Año;
        }
    }
}
