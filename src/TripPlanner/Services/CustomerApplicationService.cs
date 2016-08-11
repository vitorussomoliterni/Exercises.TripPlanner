using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripPlanner.Commands.Customers;

namespace TripPlanner.Services
{
    public class CustomerApplicationService
    {
        public async Task<TripPlannerResult> Register(RegisterCustomerCommand command)
        {
            // We could do some validation here, then immediately return a result with errors
            // Create the data-access object for customer
            // Save that customer to the database

            return TripPlannerResult.Success;
        }
    }
}
