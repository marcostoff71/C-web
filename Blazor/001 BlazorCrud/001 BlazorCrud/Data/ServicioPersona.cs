using _001_BlazorCrud.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _001_BlazorCrud.Data
{
    public class ServicioPersona : IServicioPersona
    {
        public async Task<bool> AgregarPersona(Persona per)
        {
            int re;

            using (BlazorContext db = new BlazorContext())
            {
                await db.Personas.AddAsync(per);
                re = await db.SaveChangesAsync();
            }

            return re > 0;
        }

        public async Task<bool> EliminarPersona(int id)
        {
            int re;
            using (BlazorContext db = new BlazorContext())
            {
                Persona pe = await db.Personas.FirstOrDefaultAsync(item=>item.Id==id);

                db.Personas.Remove(pe);
                re = await db.SaveChangesAsync();
            }

            return re > 0;
        }

        public async Task<bool> ModificarPersona(Persona per)
        {
            int re = 0;
            using (BlazorContext db = new BlazorContext())
            {
                db.Entry<Persona>(per).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                re=await db.SaveChangesAsync();
            }

            return re > 0;
        }

        public async Task<Persona> ObtenerPersonaId(int id)
        {
            using (BlazorContext db = new BlazorContext())
            {
                return await db.Personas.FirstOrDefaultAsync(I=>I.Id==id);
            }
        }

        public async Task<List<Persona>> ObtenerPersonas()
        {
            using(BlazorContext db = new BlazorContext())
            {
                return await db.Personas.ToListAsync();
            }
        }
    }
}
