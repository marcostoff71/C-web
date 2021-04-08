using BlazorCrudModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrudDataDapper.Repositorios
{
    public interface IFilmRepository
    {
        Task<IEnumerable<Film>> GetAllFilms();
        Task<Film> GetFilmDeteils(int id);
        Task<bool> InsertFilm(Film film);
        Task<bool> UpdateFilm(Film film);
        Task<bool> DeleteFilm(int id);
    }
}
