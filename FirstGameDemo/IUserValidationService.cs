﻿using FirstGameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
