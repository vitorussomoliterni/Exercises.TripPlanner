using System;
using Microsoft.EntityFrameworkCore;
using TripPlanner.DataAccess.Models;
using Xunit;
using TripPlanner.Services;
using TripPlanner.Commands.Customers;

namespace TripPlanner.Tests
{
    public class CustomerApplicationServiceTests
    {
        [Fact]
        public async void UpdateCustomerTest()
        {
            //Set up fixture
            var optionsBuilder = new DbContextOptionsBuilder<TripPlannerDbContext>();
            optionsBuilder.UseInMemoryDatabase();

            using (var context = new TripPlannerDbContext(optionsBuilder.Options))
            {
                //Add a customer to the database
                var customerToUpdate = new Customer()
                {
                    FirstName = "A",
                    LastName = "B",
                    DateOfBirth = DateTime.Today.AddYears(-32),
                    StreetAddress = "A",
                    Suburb = "C",
                    Postcode = "2222",
                    State = "NSW"
                };
                context.Customers.Add(customerToUpdate);
                context.SaveChanges();
                //uppdate the customer using the service
                //Execute SUT
                var service = new CustomerApplicationService(context);
                var newCustomerInfo = new RegisterCustomerCommand()
                {
                    FirstName = "JUAN",
                    LastName = "RONDON",
                    DateOfBirth = DateTime.Today.AddYears(-30),
                    StreetAddress = "ONE ADDRESS",
                    Suburb = "ONE SUBURB",
                    Postcode = "0000",
                    State = "VIC"
                };
                var updatedCustomer = await service.Update(1, newCustomerInfo);
                //Verify Outcomes
                Assert.Equal(newCustomerInfo.FirstName, updatedCustomer.FirstName);
                Assert.Equal(newCustomerInfo.LastName, updatedCustomer.LastName);
                Assert.Equal(newCustomerInfo.DateOfBirth, updatedCustomer.DateOfBirth);
                Assert.Equal(newCustomerInfo.StreetAddress, updatedCustomer.StreetAddress);
                Assert.Equal(newCustomerInfo.Suburb, updatedCustomer.Suburb);
                Assert.Equal(newCustomerInfo.Postcode, updatedCustomer.Postcode);
                Assert.Equal(newCustomerInfo.State, updatedCustomer.State);
            }
        }
    }
}
