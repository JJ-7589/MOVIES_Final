using API.W.Movies.DAL.Models;

namespace API.W.Movies.Repository.IRepository
{
    public interface IMovieRepository
    {
        Task<ICollection<Movie>> GetMovieAsync(); //Me retorna UNA LISTA DE CATEGORIAS
        Task<Movie> GetMovieAsync(int id); //Me retorna UNA CATEGORIA POR ID
        Task<bool> MovieExistsByIdAsync(int id); //Me dice si existe una categoria por ID
        Task<bool> MovieExistsByNameAsync(string name); //Me dice si existe una categoria por Nombre
        Task<bool> CreateMovieAsync(Movie movie); //Me crea una categoria
        Task<bool> UpdateMovieAsync(Movie movie); //Me crea una categoria --puedo actualizar el nombre y la fecha de actualizacion
        Task<bool> DeleteMovieAsync(int id); //Me elimina una categoria
    }
}
