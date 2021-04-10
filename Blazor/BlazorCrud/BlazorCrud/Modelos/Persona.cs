using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorCrud.Modelos
{
    public partial class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoMaterno { get; set; }
        public string ApellidoPaterno { get; set; }
        public int? Edad { get; set; }
        public DateTime? FechaNacimiento { get; set; }
    }
}
