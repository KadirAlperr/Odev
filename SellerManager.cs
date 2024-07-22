using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    internal class SellerManager :ISellerManager
    {
        
       

        public void Sell(Customer customer, Campaign campaign)
        {
            if (EDevlet.kontrol)
            {
                Console.WriteLine(customer.FirsName + " isimli kullanıcı" + campaign.CampaignName + " kampanyasıyla ürün almıştır");
            }
            else
            {
                Console.WriteLine("Kimlik bilgilerinizi kontrol ediniz");
            }
        }
    }
}
