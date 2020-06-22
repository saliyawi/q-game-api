using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace q_game_api.Models
{
    public class MontyGame
    {
        [Key]
        public int RoundId { get; set; }
        public int UserId { get; set; }
        public bool Door1 { get; set; }
        public bool Door2 { get; set; }
        public bool Door3 { get; set; }
        public bool Status { get; set; }

    }
}
