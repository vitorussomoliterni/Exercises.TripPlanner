using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripPlanner.DataAccess.Models;

namespace TripPlanner.Services
{
    public class TripApplicationService
    {
        TripPlannerDbContext _context;

        public TripApplicationService(TripPlannerDbContext context)
        {
            _context = context;
        }

        public Trip CreateTrip(DateTime tripDate, string origin, string destination, int transportTypeId)
        {
            return null;
        }

        public Trip UpdateTrip(int tripId, DateTime tripDate, string origin, string destination, int transportTypeId)
        {
            return null;
        }

        public void DeleteTrip(int tripId)
        {

        }
    }
}
