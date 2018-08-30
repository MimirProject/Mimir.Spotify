using Mimir.Spotify;
using RestEase;

namespace Mimir.Spotify.Services
{
    public class SpotifyService : ISpotifyService
    {
        private readonly ISpotifyAPI _client;

        public SpotifyService(string token)
        {
            _client = RestClient.For<ISpotifyAPI>("https://api.spotify.com/v1");
        }
    }
}