﻿using FirstGameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGameDemo.Business.Abstract
{
    public interface ICampaignService
    {
        void AddCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
    }
}
