using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameTesting.Abstract;
using GameTesting.Entites;

namespace GameTesting.Concrete
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1993 && gamer.FirstName == "ABDULLAH" && gamer.LastName == "DAĞLI" && gamer.IdentityNumber == 123)
            {


                return true;

            }
            else
            {
                return false;

            }
        }
    }
}
