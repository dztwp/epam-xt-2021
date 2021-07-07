using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_8._1.UserAwards.DAL.Interfaces;
using Task_8._1.UserAwards.Common.Entities;
using Task_8._1.UserAwards.BLL.Interfaces;

namespace Task_8._1.UserAwards.BLL.BLL
{
    public class UserBLL:IUserBLL
    {
        private IUserDAO _userJsonDAO;
        public UserBLL(IUserDAO dao)
        {
            _userJsonDAO = dao;
        }
        public void AddUser(User newUser)
        {
            _userJsonDAO.AddUser(newUser);
        }

        public bool AssignAwardToUser(Guid userId, Guid awardId)
        {
            return _userJsonDAO.AssignAwardToUser(userId, awardId);
        }

        public void DeleteUser(Guid id)
        {
            _userJsonDAO.DeleteUser(id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userJsonDAO.GetAllUsers();
        }

        public IEnumerable<Award> GetUserAwards(Guid userId)
        {
            return _userJsonDAO.GetUserAwards(userId);
        }

        public bool IsUserExist(string name)
        {
            return _userJsonDAO.IsUserExist(name);
        }
        public User GetUserById(Guid id)
        {
            return _userJsonDAO.GetUserById(id);
        }

        public bool IsUserHasAward(Guid userId, Guid awardId)
        {
            return _userJsonDAO.IsUserHasAward(userId, awardId);
        }

        public void UpdateUser(User user)
        {
            _userJsonDAO.UpdateUser(user);
        }
    }
}
