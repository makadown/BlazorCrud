using BlazorCrud.Data;
using BlazorCrud.Modelos;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Repositorio
{
    public class Repositorio : IRepositorio
    {
        private readonly ApplicationDbContext _context;
        public Repositorio(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Libro> ActualizarLibro(int libroId, Libro actualizarLibro)
        {
            var libroDesdeBD = await _context.Libro.FindAsync(libroId);
            libroDesdeBD.Titulo = actualizarLibro.Titulo;
            libroDesdeBD.Autor = actualizarLibro.Autor;
            libroDesdeBD.Precio = actualizarLibro.Precio;
            libroDesdeBD.Paginas = actualizarLibro.Paginas;

            await _context.SaveChangesAsync();
            return libroDesdeBD;
        }

        public async Task<Libro> CrearLibro(Libro crearLibro)
        {
            if (crearLibro != null)
            {
                crearLibro.FechaCreacion = DateTime.Now;
                await _context.Libro.AddAsync(crearLibro);
                await _context.SaveChangesAsync();
                return crearLibro;
            }
            return new Libro();
        }

        public async Task EliminarLibro(int libroId)
        {
            var libroDesdeBD = await _context.Libro.FindAsync(libroId);
            _context.Remove(libroDesdeBD);
            await _context.SaveChangesAsync();
        }

        public async Task<Libro> GetLibroById(int libroId)
        {
            var libroDesdeBD = await _context.Libro.FindAsync(libroId);
            return libroDesdeBD ?? new Libro();
        }

        public async Task<List<Libro>> GetLibros()
        {
            return await _context.Libro.ToListAsync();
        }
    }
}
