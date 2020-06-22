using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using q_game_api.Models;
using Microsoft.EntityFrameworkCore;
using q_game_api.Filters;


namespace q_game_api.Repository
{
    public class UserRepository : IUser
    {
        AppDbContext db;

        public UserRepository(AppDbContext db)
        {
            this.db = db;
        }

        public async Task<int> AddUser(User user)
        {
            var dbUser = await this.db.Users.FirstOrDefaultAsync(x => x.Email == user.Email).ConfigureAwait(false);
            if (dbUser != null)
                return dbUser.UserId;

            await this.db.Users.AddAsync(user).ConfigureAwait(false);
            await this.db.SaveChangesAsync().ConfigureAwait(false);
            return user.UserId;
        }
    }
}
