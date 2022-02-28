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
        [Required(ErrorMessage ="{0} is required")]
        public string ProfilePictureURL { get; set; }



        [Display(Name = "Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage =("{0} must be betwwen {2} and {1}"))]
        public string FullName { get; set; }



        [Display(Name = "Biography")]
        [Required(ErrorMessage = "{0} is required")]
        public string Bio { get; set; }

        //RelationShip
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
