using FirstGameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Business.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2001 && gamer.FirstName == "ABDULKADİR"&& 
                gamer.LastName=="ÖZYURT"&& gamer.IdentityNumber==12345)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
