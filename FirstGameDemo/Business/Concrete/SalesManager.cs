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
        public void Invoice(Gamer customer)
        {
            Console.WriteLine("Değerli Müşterimiz " + customer.FirstName + " " + customer.LastName + ", faturanız e-posta olarak gönderilmiştir.");
        }

        public void Sale(Gamer customer, Campaign campaign)
        {
            Console.WriteLine("Sayın " + customer.FirstName + " " + customer.LastName + ", oyununuzda iyi eğlenceler dileriz");
        }
    }
}
