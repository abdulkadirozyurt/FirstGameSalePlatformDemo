using FirstGameDemo.Business.Concrete;
using FirstGameDemo.Entity;
using GameProject.Business.Concrete;

namespace FirstGameSalePlatformDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gamer gamer1 = new Gamer() 
            //{ 
            //    FirstName = "Emirhan", 
            //    LastName = "Cıbır", 
            //    Id = 32339091190, 
            //    DateOfBirth = new DateTime(2001,5,28) 
            //};

            //GamerManager customerManager = new GamerManager(new MernisServiceAdapter());
            //customerManager.SignUp(gamer1);


            //Campaign campaign1 = new Campaign()
            //{
            //    Name = "Kış İndirimleri"
            //};

            //CampaignManager campaignManager = new CampaignManager();
            //campaignManager.AddCampaign(campaign1);

            //Game game = new Game()
            //{

            //};


            //SalesManager salesManager = new SalesManager();
            //salesManager.Sale(gamer1, campaign1);



            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                FirstName = "ABDULKADİR",
                LastName = "ÖZYURT",
                BirthYear = 2002,
                IdentityNumber = 12345
            });



        }
    }
}
