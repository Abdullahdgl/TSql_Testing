using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameTesting.Abstract;
using GameTesting.Entites;

namespace GameTesting.Concrete
{
    internal class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {

            _userValidationService = userValidationService;

        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(" Kayıt oldu.");

            }
            else
            {
                Console.WriteLine("Doğrualama Başarısızdır.");

            }



        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(" Kayit Silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(" Kayit Güncellenmiştir.");
        }
    }
}
