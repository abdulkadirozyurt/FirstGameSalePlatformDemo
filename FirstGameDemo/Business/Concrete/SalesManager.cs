using FirstGameDemo.Business.Abstract;
using FirstGameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGameDemo.Business.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Invoice(Customer customer)
        {
            Console.WriteLine("Değerli Müşterimiz "+customer.FirstName+" "+customer.LastName+", faturanız e-posta olarak gönderilmiştir.");
        }

        public void Sale(Game game)
        {
            Console.WriteLine("Değerli Müşterimiz, " + game.Name+ " oyununda iyi eğlenceler dileriz");
        }
    }
}
