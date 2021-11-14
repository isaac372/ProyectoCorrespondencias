using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoCorrespondencias.Models
{
    public partial class Destinatario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public int? IdPlantilla { get; set; }

        public virtual Plantilla IdPlantillaNavigation { get; set; }
    }
}
