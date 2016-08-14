using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripPlanner.DataAccess.Models
{
    public class PackageTrip
    {
        public int Id { get; set; }
        public Package Package { get; set; }
        [Required]
        public int PackageId { get; set; }
        public Trip Trip { get; set; }
        [Required]
        public int TripId { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal TripCost { get; set; }
    }
}
