using CalculatorWebApi.Config;
using CalculatorWebApi.model.Entity;
using Microsoft.EntityFrameworkCore;
namespace CalculatorWebApi.Repo

{
    public class ArthamaticRepo
    {
        private readonly Config.ArdhamaticDbContext _context;
        public ArthamaticRepo(Config.ArdhamaticDbContext context)
        {
                       _context = context;
        }

        public async Task<List<Arthamatic>> GetAllOperationsAsync()
        {
            return await _context.Arthamatic.ToListAsync(); // async read
        }
        public async Task<List<String>> GetAllOperationsSymbolsAsyncString()
        {
            return await _context.Arthamatic.Select(a => a.ToString()).ToListAsync(); // async read
        }
        public async Task<Arthamatic> SaveAndReturn(Arthamatic arthamatic)
        {
            _context.Arthamatic.Add(arthamatic); // add to db
            await _context.SaveChangesAsync(); // async write
            return arthamatic; // return saved entity
        }

    }
}
