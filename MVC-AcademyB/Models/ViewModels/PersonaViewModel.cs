using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_AcademyB.Models.ViewModels
{
    public class PersonaViewModel
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int IdGenero { get; set; }

        public PersonaViewModel(Personas personas)
        {
            this.IdPersona = personas.id;
            this.Nombre = personas.nombre;
            this.Apellido = personas.apellido;
            this.Edad = (int)personas.edad;
            this.IdGenero = (int)personas.idGenero;

        }
    }

   
}