using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripPlanner.Commands.Customers;
using TripPlanner.DataAccess.Models;

namespace TripPlanner.Services
{
    public class CustomerApplicationService
    {
        public TripPlannerDbContext Context { get; private set; }

        public CustomerApplicationService(TripPlannerDbContext context)
        {
            Context = context;
        }

        public async Task<Customer> Create(RegisterCustomerCommand customer)
        {
            //create customer object to save in DB
            var newCustomer = new Customer()
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                StreetAddress = customer.StreetAddress,
                Suburb = customer.Suburb,
                State = customer.State,
                Postcode = customer.Postcode,
                DateOfBirth = customer.DateOfBirth
            };
            Context.Customers.Add(newCustomer);
            await Context.SaveChangesAsync();
            return newCustomer;            
        }
        public async Task<Customer> Update(int custId, RegisterCustomerCommand customer)
        {
            var customerToUpdate = Context.Customers.FirstOrDefault(c => c.Id == custId);
            customerToUpdate.FirstName = customer.FirstName;
            customerToUpdate.LastName = customer.LastName;
            customerToUpdate.DateOfBirth = customer.DateOfBirth;
            customerToUpdate.Suburb = customer.Suburb;
            customerToUpdate.Postcode = customer.Postcode;
            customerToUpdate.State = customer.State;
            customerToUpdate.StreetAddress = customer.StreetAddress;
            
            await Context.SaveChangesAsync();
            return customerToUpdate;
        }
    }
}
