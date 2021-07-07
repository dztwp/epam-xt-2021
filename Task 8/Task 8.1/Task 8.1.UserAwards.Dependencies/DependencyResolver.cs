using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_8._1.UserAwards.BLL.BLL;
using Task_8._1.UserAwards.BLL.Interfaces;
using Task_8._1.UserAwards.DAL.Interfaces;
using Task_8._1.UserAwards.DAL.JsonDAL;

namespace Task_8._1.UserAwards.Dependencies
{
    public class DependencyResolver
    {
        private static DependencyResolver _instance;

        public static DependencyResolver Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance=new DependencyResolver();
                }
                return _instance;
            }
        }

        public IUserDAO userDAO => new UserJsonDAO();
        public IAwardDAO awardDAO => new AwardJsonDAO();

        public IUserBLL userBLL => new UserBLL(userDAO);
        public IAwardBLL awardBLL => new AwardBLL(awardDAO);

    }
}
