using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Identity;

namespace RailwayRS.Models
{
    public class Passenger
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PassengerId { get; set; }

        [StringLength(50)]
        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "Enter Name:")]
        [DisplayName("Name")]
        public string PassengerName { get; set; }

        [Required(ErrorMessage = "Select your Gender:")]
        [StringLength(50)]
        [Column(TypeName = "nvarchar")]
        public string Gender { get; set; }

        [ForeignKey("User")]
        public string UserId { get;set; }
        public IdentityUser User { get; set; }
    }
}