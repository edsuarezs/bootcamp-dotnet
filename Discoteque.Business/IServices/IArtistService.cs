using Discoteque.Data.Models;

namespace Discoteque.Business.IServices;

public interface IArtistService
{
    Task<IEnumerable<Artist>> GetArtistsAsync();
    Task<Artist> GetById(int id);
    Task<List<Artist>> CreateArtist(Artist artist);
    Task<Artist> UpdateArtist(Artist artist);
}