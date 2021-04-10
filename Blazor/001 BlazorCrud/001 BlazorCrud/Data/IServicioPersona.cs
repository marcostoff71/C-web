using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _001_BlazorCrud.Modelos;
namespace _001_BlazorCrud.Data
{
    public interface IServicioPersona
    {
        Task<List<Persona>> ObtenerPersonas();
        Task<Persona> ObtenerPersonaId(int id);
        Task<bool> AgregarPersona(Persona per);
        Task<bool> EliminarPersona(int id);
        Task<bool> ModificarPersona (Persona per);
    }
}
