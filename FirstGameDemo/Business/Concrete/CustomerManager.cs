using FirstGameDemo.Business.Abstract;
using FirstGameDemo.Entity;
using FirstGameSalePlatformDemo.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGameDemo.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {

        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }





        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName+" isimli oyuncu kaydı silinmiştir.");
        }

        public void SignUp(Customer customer)
        {
            if (_customerCheckService.CheckIfRealCustomer(customer))
            {
                Console.WriteLine("Yeni oyuncu kaydı alınmıştır. " + customer.FirstName + " " + customer.LastName);
            }
            else
            {
                Console.WriteLine(customer.FirstName+" isimli kullanıcı, hatalı bilgi girdiğinden dolayı kayıt edilemedi.");
            }
            
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName+" oyuncusunun kaydı güncellenmiştir.");
        }
    }
}
