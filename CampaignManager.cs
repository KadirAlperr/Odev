using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    internal class CampaignManager : ICampaignManager
    {

        List<Campaign> campaigns = new List<Campaign>();

        public void CampaignAdd(Campaign campaign)
        {
            campaigns.Add(campaign);
        }

        public void CampaignDelete(Campaign campaign)
        {
            campaigns.Remove(campaign);
        }

        public void CampaignUpdage(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }

        public void ShowCampaigns()
        {
            foreach (var campaign in campaigns)
            {
                Console.WriteLine("kampanyanın adı : " + campaign.CampaignName);
            }
        }
    }
}
