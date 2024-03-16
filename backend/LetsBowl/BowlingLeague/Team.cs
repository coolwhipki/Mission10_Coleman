using System.ComponentModel.DataAnnotations;

namespace LetsBowl.BowlingLeague
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        [MaxLength(50)]
        public string TeamName { get; set; }
        public int CaptainID { get; set; }
    }
}
