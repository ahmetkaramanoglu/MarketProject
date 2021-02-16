using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {

        ICityDal cityDal;

        public CityManager(ICityDal cityDal)
        {
            this.cityDal = cityDal;
        }

        public List<City> GetAll()
        {
            return cityDal.GetAll();
        }
    }
}
