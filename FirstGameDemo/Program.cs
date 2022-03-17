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
                FirstName = "Abdulkadir", 
                LastName = "Özyurt", 
                Id = 18043787086, 
                DateOfBirth = new DateTime(2001,1,27) 
            };

            CustomerManager customerManager = new CustomerManager(new MernisServiceAdapter());
            customerManager.SignUp(gamer1);


            Campaign campaign1 = new Campaign()
            {
                Name = "Kış İndirimleri"
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.AddCampaign(campaign1);

            GameManager gameManager = new GameManager()
            {

            };


            SalesManager salesManager = new SalesManager();
            salesManager.Sale(gamer1, campaign1);


        }
    }
}
