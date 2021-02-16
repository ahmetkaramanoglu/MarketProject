using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICityDal
    {
        List<City> GetAll();
        void Add(City city);
        void Update(City city);
        void Delete(City city);
    }
}
