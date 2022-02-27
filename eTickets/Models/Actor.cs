using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        [Display(Name = "Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //RelationShip
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
