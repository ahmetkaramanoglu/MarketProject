using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IOrderDal
    {
        List<Order> GetAll();
        void Add(Order order);
        void Update(Order order);
        void Delete(Order order);
    }
}
