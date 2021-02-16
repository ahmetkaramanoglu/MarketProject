using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            this.customerDal = customerDal;
        }

        public List<Customer> GetAll()
        {
            /*
             Burda bana Customer tablosunun listesi lazım dimi? CustomerDal sınıfını newleyemezsin çünkü ona bağımlı olursun.
            onun yerine onun interfaceni tutan ICustomerDal'ın constructor ile oluştur.
            Bunu Dejencty injection ile yapıcaksın. Ki sen bu listeyi get all yapabilesin.
            Böylece hem Database'de farklı teknik ile yazmak istediğinde bu interface'i o yeni database
            tekniğine implement edersin olur biter. bu listeyi o yeni database' eklemek istediğin zaman(add methodunu varsay burda)
            direk o yeni database tekniğini newlersin customermanager constructorın'da. çünkü onun adresini tutabiliyor.
             */
            return customerDal.GetAll();
        }
    }
}
