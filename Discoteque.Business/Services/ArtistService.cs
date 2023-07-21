using System.Data.Common;
using Discoteque.Business.IServices;
using Discoteque.Data.Models;

namespace Discoteque.Business.Service;

public class ArtistService : IArtistService
{
    async Task<List<Artist>> IArtistService.CreateArtist(Artist artist)
    {
        var artistsList = new List<Artist> {
            new Artist()
            {
                Id = new Random().Next(),
                Name = artist.Name,
                Label = artist.Label,
                IsOnTour = artist.IsOnTour,
            }
        };

        return await Task.FromResult<List<Artist>>(artistsList);
    }

    public Task<IEnumerable<Artist>> GetArtistsAsync()
    {
        var list = new List<Artist>
        {
            new Artist()
            {
                Id = new Random().Next(),
                Name = "Test",
                Label = "EMI",
                IsOnTour = true,
            }
        };

        return Task.FromResult<IEnumerable<Artist>>(list);
    }

    public Task<Artist> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Artist> UpdateArtist(Artist artist)
    {
        throw new NotImplementedException();
    }
}
