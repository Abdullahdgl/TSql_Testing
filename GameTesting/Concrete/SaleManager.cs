using GameTesting.Abstract;
using GameTesting.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTesting.Concrete
{
    internal class SaleManager : ISaleService
    {
        public void Sale(Gamer gamer, GameSale gameSale, Campaign campaign)
        {
            double salePrice = (gameSale.Price) - ((gameSale.Price  * campaign.DiscountAmount)/100);
            Console.WriteLine(gameSale.GameName + " " + salePrice + " TL ye satıldı.");

        }
    }
}
