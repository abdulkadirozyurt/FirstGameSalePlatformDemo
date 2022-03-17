﻿using FirstGameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGameDemo.Business.Abstract
{
    public interface ICustomerService
    {
        void SignUp(Customer customer);

        void Update(Customer customer);

        void Delete(Customer customer);
    }
}
