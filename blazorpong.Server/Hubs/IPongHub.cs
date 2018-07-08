using System.Threading.Tasks;
using blazorpong.Shared.GameObjects;

namespace blazorpong.Server.Hubs
{
    public interface IPongHub
    {
        void UpdateBallAsync(Coordinates coordinates);
    }
}
