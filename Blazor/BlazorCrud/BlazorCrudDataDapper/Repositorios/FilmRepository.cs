using BlazorCrudModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace BlazorCrudDataDapper.Repositorios
{
    public class FilmRepository : IFilmRepository
    {
        private string ConectionString;
        public FilmRepository(string cadenaCo)
        {
            ConectionString = cadenaCo;
        }
        protected SqlConnection dbConeccion()
        {
            SqlConnection cone = new SqlConnection(ConectionString);
            return cone;
        }
        public async Task<bool> DeleteFilm(int id)
        {
            SqlConnection cone = new SqlConnection(ConectionString);

            string sql =@"DELETE FROM Films WHERE Id=@id";
            int d = await cone.ExecuteAsync(sql,new {id});

            return d > 0;
        }

        public async Task<IEnumerable<Film>> GetAllFilms()
        {
            SqlConnection db = dbConeccion();

            string query = @"SELECT * FROM Films";


            var d = await db.QueryAsync<Film>(query);

            return d;
        }

        public async Task<Film> GetFilmDeteils(int id)
        {
            SqlConnection db = dbConeccion();

            string query = @"SELECT * FROM Films WHERE Id=@id";


            var d = await db.QueryFirstOrDefaultAsync<Film>(query,new { id});

            return d;
        }

        public async Task<bool> InsertFilm(Film film)
        {
            var db = dbConeccion();

            var cmd = @"INSERT INTO Films (Title,Director,ReleaseData) values(@Title,@Director,@ReleaseData)";

            int result = await db.ExecuteAsync(cmd.ToString(),new { film.Title,film.Director,film.ReleaseData});

            return result>0;

        }

        public async Task<bool> UpdateFilm(Film film)
        {
            SqlConnection cone = new SqlConnection(ConectionString);

            string sql = @"UPDATE
                         Films SET Title=@title,Director=@Director,ReleaseData=@ReleaseData 
                         WHERE Id=@Id";
            int d = await cone.ExecuteAsync(sql, new { film.Title,film.Director,film.ReleaseData,film.Id });

            return d > 0;
        }
    }
}
