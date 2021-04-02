using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace razor_crud.Models
{
    public class Spell
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string SpellName { get; set; }
        
        [Range(0, 9)]
        public uint SpellSlot { get; set; }
        
        [Required]
        public bool Concentration { get; set; }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string Components { get; set; }
        
        
    }
}