using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using q_game_api.Models;
using q_game_api.Repository;
using q_game_api.Filters;

namespace q_game_api.Controllers
{
    [Route("api/Game")]
    [ApiController]
    public class GameController : Controller
    {
        private IGame gameRepo;

        public GameController(IGame gameRepo)
        {
            this.gameRepo = gameRepo;
        }

        /// <summary>
        /// Add Game Rounds
        /// </summary>
        /// <param name="gameRoundList"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddGameRound")]
        public async Task<bool> AddGameRounds([FromBody] List<MontyGame> gameRoundList)
        {
            if (gameRoundList.Count == 0)
                throw new ApiValidationExceptionFilter("Game Round Data is null");

            return await this.gameRepo.AddGameRounds(gameRoundList);
        }

        /// <summary>
        /// Get Game Results
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Results/{userId}")]
        public  List<MontyGame> GetGameResults(int userId)
        {
            return  this.gameRepo.GetGameResults(userId).ToList<MontyGame>();
        }
    }
}
