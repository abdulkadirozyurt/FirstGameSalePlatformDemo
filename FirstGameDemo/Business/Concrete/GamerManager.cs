using FirstGameDemo.Business.Abstract;
using FirstGameDemo.Entity;
using FirstGameSalePlatformDemo.Business.Abstract;
using GameProject;
using System;
using System.Collections.Generic;
using System.Linq;                                                      /* Bir manager sınıfı içerisinde başka bir manager sınıfını kullanacaksan onu asla new'leme (dependency injection) */
using System.Text;
using System.Threading.Tasks;

namespace FirstGameDemo.Business.Concrete
{
    public class GamerManager : IGamerService
    {

        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService) // constructor oluşturduk
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {

            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama ve kayıt başarısız.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }
    }
}
