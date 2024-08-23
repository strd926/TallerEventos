using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEventos.Clases
{
    internal class Tarea
    {
        public string Nombre {  get; set; }

        readonly DateTime FechaCreacion;
        public string Estado { get; set; }
    
        
        public Tarea (string nombre, string estado)
        {
            this.FechaCreacion = DateTime.Now;
            this.Nombre = nombre;
            this.Estado = estado;   
        }

    }
}
