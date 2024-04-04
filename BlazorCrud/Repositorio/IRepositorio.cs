using BlazorCrud.Modelos;

namespace BlazorCrud.Repositorio
{
    public interface IRepositorio
    {
        public Task<List<Libro>> GetLibros();
        public Task<Libro> GetLibroById(int libroId);
        public Task<Libro> CrearLibro(Libro crearLibro);
        public Task<Libro> ActualizarLibro(int libroId, Libro actualizarLibro);
        public Task EliminarLibro(int libroId);
    }
}
