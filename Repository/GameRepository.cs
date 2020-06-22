using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using q_game_api.Models;
using Microsoft.EntityFrameworkCore;

namespace q_game_api.Repository
{
    public class GameRepository : IGame
    {
        AppDbContext db;
        public GameRepository(AppDbContext db)
        {
            this.db = db;
        }

        public async Task<bool> AddGameRounds(List<MontyGame> roundList)
        {
            if(roundList.Count > 0)
            {
                await this.db.MontyGames.AddRangeAsync(roundList);
                return await this.db.SaveChangesAsync().ConfigureAwait(false) > 0;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<MontyGame> GetGameResults(int userId)
        {
            var results = this.db.MontyGames.Where(m => m.UserId == userId).OrderBy(m => m.RoundId).ToList();
            if(results.Count > 0)
            {
                return results;
            }
            else { return null; }
        }
    }
}
