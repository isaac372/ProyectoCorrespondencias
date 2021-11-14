using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoCorrespondencias.Models
{
    public partial class Plantilla
    {
        public Plantilla()
        {
            Destinatarios = new HashSet<Destinatario>();
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Direccion { get; set; }
        public string Contribucion { get; set; }
        public string Contacto { get; set; }

        public virtual ICollection<Destinatario> Destinatarios { get; set; }
    }
}
