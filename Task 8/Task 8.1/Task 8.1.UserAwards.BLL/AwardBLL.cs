using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_8._1.UserAwards.BLL.Interfaces;
using Task_8._1.UserAwards.Common.Entities;
using Task_8._1.UserAwards.DAL.Interfaces;

namespace Task_8._1.UserAwards.BLL.BLL
{
    public class AwardBLL : IAwardBLL
    {
        IAwardDAO _awardDAO;
        public AwardBLL(IAwardDAO inAwardDAO)
        {
            _awardDAO = inAwardDAO;
        }
        public void AddAward(Award award)
        {
            _awardDAO.AddAward(award);
        }

        public void DeleteAward(Guid id)
        {
            _awardDAO.DeleteAward(id);
        }

        public IEnumerable<Award> GetAllAwards()
        {
            return _awardDAO.GetAllAwards();
        }

        public Award GetAwardById(Guid id)
        {
            return _awardDAO.GetAwardById(id);
        }

        public bool IsAwardAlreadyExist(string title)
        {
            return _awardDAO.IsAwardAlreadyExist(title);
        }

        public void UpdateAward(Award award)
        {
            _awardDAO.UpdateAward(award);
        }
    }
}
