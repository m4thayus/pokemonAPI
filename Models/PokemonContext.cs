using Microsoft.EntityFrameworkCore;

namespace pokemonAPI.Models
{
    public class PokemonContext : DbContext
    {
        public PokemonContext(DbContextOptions<PokemonContext> options)
            : base(options)
        {
        }

        public DbSet<Pokemon> Pokemons { get; set; }
    }
}