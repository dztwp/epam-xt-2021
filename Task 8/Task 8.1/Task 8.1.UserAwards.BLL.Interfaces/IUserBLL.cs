using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_8._1.UserAwards.Common.Entities;

namespace Task_8._1.UserAwards.BLL.Interfaces
{
     public interface IUserBLL
    {
        void AddUser(User newUser);
        void DeleteUser(Guid id);
        void UpdateUser(User user);
        IEnumerable<User> GetAllUsers();

        bool AssignAwardToUser(Guid userId, Guid awardId);

        IEnumerable<Award> GetUserAwards(Guid userId);

        bool IsUserExist(string name);

        User GetUserById(Guid id);

        bool IsUserHasAward(Guid userId, Guid awardId);
    }
}
