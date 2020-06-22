using System.Threading.Tasks;
using q_game_api.Models;

namespace q_game_api.Repository
{
    public interface IUser
    {
        Task<int> AddUser(User user);
    }
}
