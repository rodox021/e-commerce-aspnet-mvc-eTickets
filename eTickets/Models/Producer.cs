using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int ActorId { get; set; }

        [Display(Name = "Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        // Relationship

        public List<Movie> Movies { get; set; }

    }
}
