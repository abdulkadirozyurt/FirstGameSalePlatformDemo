using FirstGameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGameDemo.Business.Abstract
{
    public interface ISalesService
    {
        void Invoice(Customer customer);
        void Sale(Customer customer, Campaign campaign);
        

    }
}
