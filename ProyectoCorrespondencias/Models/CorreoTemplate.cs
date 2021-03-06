using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCorrespondencias.Models
{
    public class CorreoTemplate
    {
        string xhtml = "";
        CorreoHtml CHtml = new CorreoHtml();
        public string TemplateCorreo(Plantilla plantilla, string User)
        {

            xhtml = xhtml + CHtml.GetInicioDocHtml();
            xhtml = xhtml + CHtml.GetHeadHtml();
            xhtml = xhtml + CHtml.GetBodyHtml();
            xhtml = xhtml + CHtml.DataHtml(plantilla);
            xhtml = xhtml + CHtml.GetFinBodyHtml();
            xhtml = xhtml + CHtml.GetFinDocHtml();
            return xhtml;
        }
    }
}
