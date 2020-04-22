using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace superHeros.Models
{
    public class SuperHeros
    {
        [Key]
        public int superHeroId { get; set; }
        public string superHeroName { get; set; }
        public string alterEgo { get; set; }
        public string primaryAbility { get; set; }
        public string secondaryAbility { get; set; }
        public string catchPhrase { get; set; }


    }
}
