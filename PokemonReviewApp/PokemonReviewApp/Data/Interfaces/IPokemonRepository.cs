using PokemonReviewApp.Models;

namespace PokemonReviewApp.Data.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();


    }
}
