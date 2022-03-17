using FirstGameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGameSalePlatformDemo.Business.Abstract
{
    public interface ICustomerCheckService
    {

        bool CheckIfRealCustomer(Customer customer);

    }
}
