using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameTesting.Abstract;
using GameTesting.Entites;

namespace GameTesting.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CompaignName + " Eklenmiştir.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CompaignName + " Silinmiştir.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CompaignName + " Güncellenmiştir.");
        }
    }
}
