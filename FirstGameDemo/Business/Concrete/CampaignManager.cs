using FirstGameDemo.Business.Abstract;
using FirstGameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGameDemo.Business.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.Name+" Eklenmiştir.");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Silinmiştir.");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Güncellenmiştir.");
        }
    }
}
