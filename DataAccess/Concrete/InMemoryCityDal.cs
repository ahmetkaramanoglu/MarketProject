using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCityDal : ICityDal
    {
        List<City> _cities;
        public InMemoryCityDal()
        {
            _cities = new List<City>()
            {
                new City{Id=53,CityName="Rize"},
                new City{Id=61,CityName="Trabzon"},
                new City{Id=60,CityName="Tokat"},
                new City{Id=67,CityName="Zonguldak"},
                new City{Id=34,CityName="Istanbul"},
            };
        }
        public void Add(City city)
        {
            _cities.Add(city);
        }

        public void Delete(City city)
        {
            City cityToDelete = _cities.SingleOrDefault(c=>c.Id==city.Id);
            _cities.Remove(cityToDelete);
        }

        public List<City> GetAll()
        {
            return _cities;
        }

        public void Update(City city)
        {
            City cityToUpdate = _cities.SingleOrDefault(c => c.Id == city.Id);
            cityToUpdate.CityName = city.CityName;
        }
    }
}
