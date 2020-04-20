using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace superHeroManager.Models
{
    public class superHeros
    {
        [Key]
        public string superHeroName { get; set; }
        [Display(Name = "Superheroname")]
        public string alterEgo { get; set; }
        [Display(Name = "Alter Ego")]
        public string primaryAbility { get; set; }
        [Display(Name = "Primary Ability")]
        public string secondaryAbility { get; set; }
        [Display(Name = "Primary Ability")]
        public string catchPhrase { get; set; }
        [Display(Name = "Catch Phrase")]
        public int superHeroId { get; set; }
    }
}
