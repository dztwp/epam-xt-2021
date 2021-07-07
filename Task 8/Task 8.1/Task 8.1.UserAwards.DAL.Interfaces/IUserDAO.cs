using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_8._1.UserAwards.Common.Entities;

namespace Task_8._1.UserAwards.DAL.Interfaces
{
    public interface IUserDAO
    {
        void AddUser(User newUser);
        void DeleteUser(Guid id);
        void UpdateUser(User user);
        IEnumerable<User> GetAllUsers();
        User GetUserById(Guid id);

        bool AssignAwardToUser(Guid userId, Guid awardId);

        IEnumerable<Award> GetUserAwards(Guid userId);

        bool IsUserHasAward(Guid userId, Guid awardId);
        bool IsUserExist(string name);


    }
}
