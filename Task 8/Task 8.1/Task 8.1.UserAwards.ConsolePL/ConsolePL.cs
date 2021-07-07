using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_8._1.UserAwards.BLL;
using Task_8._1.UserAwards.Common.Entities;
using Task_8._1.UserAwards.Dependencies;

namespace Task_8._1.UserAwards.PL.ConsolePL
{
    public class ConsolePL
    {
        static void Main(string[] args)
        {
            var _userbll = DependencyResolver.Instance.userBLL;
            var _awardBLL = DependencyResolver.Instance.awardBLL;
            _userbll.AddUser(new Common.Entities.User("EGOR", DateTime.Now));
            _awardBLL.AddAward(new Common.Entities.Award("ЛУЧШИЙ PEKARь"));
            _userbll.AssignAwardToUser(Guid.Parse("26255dcf-9c73-4eb5-b45c-8f0bb3343cd2"), Guid.Parse("fc168656-dab7-4747-ba82-6d7205e370bb"));
            IEnumerable<User> listOfUsers=_userbll.GetAllUsers();
            IEnumerable<Award> listOfAwardsForUser = _userbll.GetUserAwards(Guid.Parse("26255dcf-9c73-4eb5-b45c-8f0bb3343cd2"));
            IEnumerable<Award> listOfAwards=_awardBLL.GetAllAwards();
            foreach (var item in listOfAwards)
            {
                Console.WriteLine(item.Title);
            }
            //_userbll.AssignAwardToUser()
            Console.ReadLine();
        }
    }
}
