using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectingDots.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Child Name")]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        public string child { get; set; }

        [Required]
        [Display(Name = "Stop 1 Latitude")]
        public string stop1_lat { get; set; }

        [Required]
        [Display(Name = "Stop 1 Longitude")]
        public string stop1_lon { get; set; }

        [Required]
        [Display(Name = "Stop 1 Address")]
        public string stop1_add { get; set; }

        [Required]
        [Display(Name = "Stop 1 status")]
        public string stop1_stat { get; set; }

        [Required]
        [Display(Name = "Stop 2 Latitude")]
        public string stop2_lat { get; set; }

        [Required]
        [Display(Name = "Stop 2 Longitude")]
        public string stop2_lon { get; set; }

        [Required]
        [Display(Name = "Stop 2 Address")]
        public string stop2_add { get; set; }

        [Required]
        [Display(Name = "Stop 2 status")]
        public string stop2_stat { get; set; }

        [Required]
        [Display(Name = "Stop 3 Latitude")]
        public string stop3_lat { get; set; }

        [Required]
        [Display(Name = "Stop 3 Longitude")]
        public string stop3_lon { get; set; }

        [Required]
        [Display(Name = "Stop 3 Address")]
        public string stop3_add { get; set; }

        [Required]
        [Display(Name = "Stop 3 status")]
        public string stop3_stat { get; set; }

        [Required]
        [Display(Name = "Stop 4 Latitude")]
        public string stop4_lat { get; set; }

        [Required]
        [Display(Name = "Stop 4 Longitude")]
        public string stop4_lon { get; set; }

        [Required]
        [Display(Name = "Stop 4 Address")]
        public string stop4_add { get; set; }

        [Required]
        [Display(Name = "Stop 4 status")]
        public string stop4_stat { get; set; }

        [Required]
        [Display(Name = "Stop 5 Latitude")]
        public string stop5_lat { get; set; }

        [Required]
        [Display(Name = "Stop 5 Longitude")]
        public string stop5_lon { get; set; }

        [Required]
        [Display(Name = "Stop 5 Address")]
        public string stop5_add { get; set; }

        [Required]
        [Display(Name = "Stop 5 status")]
        public string stop5_stat { get; set; }

        [Required]
        [Display(Name = "Stop 6 Latitude")]
        public string stop6_lat { get; set; }

        [Required]
        [Display(Name = "Stop 6 Longitude")]
        public string stop6_lon { get; set; }

        [Required]
        [Display(Name = "Stop 6 Address")]
        public string stop6_add { get; set; }

        [Required]
        [Display(Name = "Stop 6 status")]
        public string stop6_stat { get; set; }
    }
}