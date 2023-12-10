// See https://aka.ms/new-console-template for more information
using GameTesting;
using GameTesting.Concrete;
using GameTesting.Entites;

Console.WriteLine(" Oyuncu Doğrulanmış oyuncu kısmı");

Gamer gamer1 = new Gamer();
gamer1.FirstName = "ABDULLAH";
gamer1.LastName = "DAĞLI";
gamer1.BirthYear = 1993;
gamer1.IdentityNumber = 123;
GamerManager gamerManager = new GamerManager(new UserValidationManager());
//gamerManager.Add(gamer1);

Campaign campaign1 = new Campaign();
campaign1.CompaignName = "Kampanya 1";
campaign1.Description = "Test";
campaign1.DiscountAmount = 90;

CampaignManager campaignManager = new CampaignManager();
campaignManager.Add(campaign1);


//oyun
GameSale gameSale = new GameSale();
gameSale.GameName = "Valorant";
gameSale.Price = 3000;

SaleManager saleManager = new SaleManager();
saleManager.Sale(gamer1, gameSale, campaign1);










//gamerManager.Add(new Gamer { Id = 1, BirthYear = 1993, FirstName = "ABDULLAH", LastName = "DAĞLI", IdentityNumber = 123 });
