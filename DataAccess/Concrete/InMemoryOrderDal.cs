using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryOrderDal : IOrderDal
    {
        List<Order> _orders;
        public InMemoryOrderDal()
        {
            _orders = new List<Order>()
            {
                new Order{Id=1,CustomerId=1,Date="15.02.2021"},
                new Order{Id=2,CustomerId=2,Date="15.02.2021"},
                new Order{Id=3,CustomerId=3,Date="15.02.2021"},
                new Order{Id=4,CustomerId=4,Date="15.02.2021"},
                new Order{Id=5,CustomerId=5,Date="15.02.2021"},
            };
        }
        public void Add(Order order)
        {
            _orders.Add(order);
        }

        public void Delete(Order order)
        {
            Order orderToDelete = _orders.SingleOrDefault(o=>o.Id==order.Id);
            _orders.Remove(orderToDelete);
        }

        public List<Order> GetAll()
        {
            return _orders;
        }

        public void Update(Order order)
        {
            Order orderToUpdate = _orders.SingleOrDefault(o => o.Id == order.Id);
            orderToUpdate.CustomerId = order.CustomerId;
            orderToUpdate.Date = order.Date;
            
        }
    }
}
