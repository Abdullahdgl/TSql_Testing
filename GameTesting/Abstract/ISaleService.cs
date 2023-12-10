using GameTesting.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTesting.Abstract
{
    internal interface ISaleService
    {
        void Sale(Gamer gamer, GameSale gameSale, Campaign campaign);

    }
}
