﻿using System.ComponentModel.DataAnnotations;

namespace q_game_api.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
       // public string UserName { get; set; }
        public string Email { get; set; }

    }
}
