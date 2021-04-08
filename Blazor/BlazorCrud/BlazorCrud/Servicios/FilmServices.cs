using BlazorCrudModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCrudDataDapper.Repositorios;
using BlazorCrud.Data;
namespace BlazorCrud.Servicios
{
    public class FilmServices: Interfaces.IFilmServices
    {
        private IFilmRepository Film;
        private readonly SqlConfiguration confi;
        public FilmServices(SqlConfiguration confi)
        {
            this.confi = confi;
            Film = new FilmRepository(confi.Conection);
        }
        public Task<IEnumerable<Film>> GetAllFilms()
        {
            return Film.GetAllFilms();
        }

        public Task<Film> GetDetails(int id)
        {
            return Film.GetFilmDeteils(id);
        }

        public Task<bool> DeleteFilm(int id)
        {
            return Film.DeleteFilm(id);
        }

        public  Task<bool> SaveFilm(Film film)
        {
            if (film.Id == 0)
            {
                return Film.InsertFilm(film);
            }
            else
            {
                return Film.UpdateFilm(film);
            }
        }

        
    }
}
