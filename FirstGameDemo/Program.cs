using FirstGameDemo.Business.Concrete;
using FirstGameDemo.Entity;
using FirstGameSalePlatformDemo.Adapter;
using FirstGameSalePlatformDemo.Business.Abstract;
using System;

namespace FirstGameSalePlatformDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer gamer1 = new Customer() 
            { 
                FirstName = "Emirhan", 
                LastName = "Cıbır", 
                Id = 32339091190, 
                DateOfBirth = new DateTime(2001,5,28) 
            };

            CustomerManager customerManager = new CustomerManager(new MernisServiceAdapter());
            customerManager.SignUp(gamer1);


            Campaign campaign1 = new Campaign()
            {
                Name = "Kış İndirimleri"
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.AddCampaign(campaign1);

            Game game = new Game()
            {
                
            };


            SalesManager salesManager = new SalesManager();
            salesManager.Sale(gamer1, campaign1);


        }
    }
}
