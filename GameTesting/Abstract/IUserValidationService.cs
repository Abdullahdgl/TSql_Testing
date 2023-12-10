using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameTesting.Entites;

namespace GameTesting.Abstract
{
    internal interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
