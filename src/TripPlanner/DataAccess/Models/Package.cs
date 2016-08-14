using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TripPlanner.DataAccess.Models
{
    public class Package
    {
        public int Id { get; set; }
        public List<PackageTrip> PackageTrips { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}