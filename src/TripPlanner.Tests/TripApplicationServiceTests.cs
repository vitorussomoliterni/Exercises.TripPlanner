using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace TripPlanner.Tests
{
    public class TripApplicationServiceTests
    {
        [Fact]
        public async void CreateServiceTest()
        {
            // Set up fixture
            var optionsBuilder = new DbContextOptionsBuilder<TripPlannerDbContext>();
        }
    }
}
