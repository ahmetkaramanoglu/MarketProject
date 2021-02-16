using Business.Concrete;
using DataAccess.Concrete;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In Memory Database");
            CustomerManager customerManager = new CustomerManager(new InMemoryCustomerDal());
            foreach (var customer in customerManager.GetAll())
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + customer.Years);
            }
            Console.WriteLine();
            Console.WriteLine();
            //İşte böyle kolayca newleyerek database değiştirmiş olabiliyorsun. Bağımlılık böyle azaltılıyor. Sen
            //Customer manager sınıfında başka sınıfı newleseydin bağımlı olmuş olurdun.
            CustomerManager customerManager1 = new CustomerManager(new OracleCustomerDal());
            foreach (var customer1 in customerManager1.GetAll())
            {
                Console.WriteLine(customer1.FirstName + " " + customer1.LastName + " " + customer1.Years);
            }
            Console.WriteLine();
            Console.WriteLine();


            CityManager cityManager = new CityManager(new InMemoryCityDal());
            var result = from c in customerManager.GetAll() join ct in cityManager.GetAll() 
                         on c.CityId equals ct.Id select new CustomerDTO {CustomerId=c.Id,CityName=ct.CityName,CustomerName=c.FirstName };

            foreach (var customerDTO in result)
            {
                Console.WriteLine("{0} --- {1}", customerDTO.CustomerName, customerDTO.CityName);
            }

        }
        class CustomerDTO
        {
            public int CustomerId { get; set; }
            public string CityName { get; set; }
            public string CustomerName { get; set; }

        }
    }
}
