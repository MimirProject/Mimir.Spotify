using Mimir.Spotify;
using RestEase;

namespace Mimir.Spotify.Services
{
    public class SpotifyService : ISpotifyService
    {
        private readonly ISpotifyAPI _client;
        private string _authorizationKey;

        public SpotifyService(string token)
        {
            _client = RestClient.For<ISpotifyAPI>("https://api.spotify.com/v1");
            _authorizationKey = token;
        }
    }
}