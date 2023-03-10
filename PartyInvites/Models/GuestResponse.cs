using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        [Key]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]

        public string Phone { get; set; }

        [Required(ErrorMessage ="Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }

    public class GuestResponseDBContext : DbContext
    {
        public DbSet<GuestResponse> guestResponses { get; set; }
    }

}