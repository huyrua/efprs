using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Data;
using Infrastructure.Tests.Data.Domain;

namespace Infrastructure.Tests.Data
{
    public interface ICustomerRepository : IRepository
    {
        IList<Customer> NewlySubscribed();

        Customer FindByName(string firstname, string lastname);
    }

    public class CustomerRepository : Infrastructure.Data.GenericRepository, ICustomerRepository
    {
        public CustomerRepository()
            : base()
        {
        }

        public CustomerRepository(System.Data.Entity.DbContext context)
            : base(context)
        {
        }

        public IList<Customer> NewlySubscribed()
        {
            var lastMonth = DateTime.Now.Date.AddMonths(-1);

            return GetQuery<Customer>().Where(c => c.Inserted >= lastMonth)
                              .ToList();
        }

        public Customer FindByName(string firstname, string lastname)
        {
            return GetQuery<Customer>().Where(c => c.Firstname == firstname && c.Lastname == lastname)
                              .FirstOrDefault();
        }
    }
}
