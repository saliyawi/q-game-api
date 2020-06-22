using q_game_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace q_game_api.Repository
{
   public interface IGame
    {
        Task<bool> AddGameRounds(List<MontyGame> roundList);

        IEnumerable<MontyGame> GetGameResults(int userId);
    }
}
