using SimbirSoft.Models;
using System.Collections.Generic;

namespace SimbirSoft.Repositories.Interfaces
{
    public interface IGenreRepository
    {
        List<Genre> GetGenres();
    }
}
