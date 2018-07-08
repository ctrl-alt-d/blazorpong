using Microsoft.AspNetCore.SignalR;
using blazorpong.Shared.GameObjects;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;

namespace blazorpong.Server.Hubs
{
    public class PongHub : Hub<IPongHub>
    {
        private IMemoryCache _cache;
        public PongHub(IMemoryCache cache)
        {
            _cache = cache;
            /*
            if (!_cache.TryGetValue("GameCacheKey", out List<Game> games))
            {
                _cache.Set("GameCacheKey", new List<Game>());
            }
             */
        }

        public override Task OnConnectedAsync()
        {
            string connectionId = Context.ConnectionId;


            return base.OnConnectedAsync();
        }

        public void UpdateBallAsync()
        {
            Clients.All.UpdateBallAsync(new Coordinates(1, 1));
        }
    }
}
