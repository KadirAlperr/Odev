

using Odev;

Customer customer1 = new Customer()
{
    Id = 1,
    TcNo = "12345678910",
    FirsName = "Kadir",
    LastName = "Ünver",
    BirthYear = 2004
};

Customer customer2 = new Customer()
{
    Id = 2,
    TcNo = "12345678910",
    FirsName = "İsmail",
    LastName = "Kaygısız",
    BirthYear = 2004
};
Customer customer3 = new Customer()
{
    Id = 3,
    TcNo = "12345678910",
    FirsName = "Alper",
    LastName = "Ünver",
    BirthYear = 2004
};





Campaign campaign1 = new Campaign()
{
    CampaignId = 1,
    CampaignName = "Black Friday",
    CampaignDescription = "13th Friday",
    Discount = 15
};
Campaign campaign2 = new Campaign()
{
    CampaignId = 2,
    CampaignName = "Happy Friday",
    CampaignDescription = "17th Friday",
    Discount = 20
};
Campaign campaign3 = new Campaign()
{
    CampaignId = 3,
    CampaignName = "White Friday",
    CampaignDescription = "21th Friday",
    Discount = 40
};


ICustomerManager customerManager = new CustomerManager();
customerManager.CustomerAdd(customer1);
customerManager.CustomerAdd(customer2);
customerManager.CustomerAdd(customer3);
customerManager.CustomerDelete(customer3);
customerManager.CustomerUpdate(customer2);
customerManager.ShowCustomers();


ICampaignManager campaignManager = new CampaignManager();
campaignManager.CampaignAdd(campaign1);
campaignManager.CampaignAdd(campaign2);
campaignManager.CampaignAdd(campaign3);
campaignManager.CampaignDelete(campaign3);
campaignManager.CampaignUpdage(campaign2);
campaignManager.ShowCampaigns();

EDevlet eDevlet = new EDevlet(customer1.TcNo,customer1.FirsName,customer1.LastName);

SellerManager sellerManager = new SellerManager();
sellerManager.Sell(customer1, campaign1);