using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCustomerDal : ICustomerDal
    {
        List<Customer> _customers;
        public InMemoryCustomerDal()
        {
            _customers = new List<Customer>()
            {
                new Customer{Id=1,FirstName="Ahmet",LastName="Karamanoglu",CityId=53,Years="21"},
                new Customer{Id=2,FirstName="Yusuf",LastName="Onala",CityId=61,Years="21"},
                new Customer{Id=3,FirstName="Emre",LastName="Ozel",CityId=67,Years="21"},
                new Customer{Id=4,FirstName="Eray",LastName="Uyar",CityId=60,Years="20"},
                new Customer{Id=5,FirstName="Halil",LastName="Pusuroglu",CityId=61,Years="21"}
            };
        }
        public void Add(Customer customer)
        {
             _customers.Add(customer);
        }

        public void Delete(Customer customer)
        {
            Customer customerToDelete;
            customerToDelete = _customers.SingleOrDefault(c=>c.Id==customer.Id);
            _customers.Remove(customerToDelete);
        }

        public List<Customer> GetAll()
        {
            return _customers;
        }

        public void Update(Customer customer)
        {
            Customer customerToUpdate=_customers.SingleOrDefault(c=>c.Id==customer.Id);
            customerToUpdate.FirstName = customer.FirstName;
            customerToUpdate.LastName = customer.LastName;
            customerToUpdate.CityId = customer.CityId;
            customerToUpdate.Years = customer.Years;
            
        }
    }
}
