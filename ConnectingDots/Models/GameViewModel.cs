using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConnectingDots.Models
{
    public class GameViewModel
    {
        [Key]
        public int Id { get; set; }

        public Game Game { get; set; }

        public List<Game> AllGames { get; set; }
    }
}