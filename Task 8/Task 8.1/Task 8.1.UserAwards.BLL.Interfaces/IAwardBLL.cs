using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_8._1.UserAwards.Common.Entities;

namespace Task_8._1.UserAwards.BLL.Interfaces
{
    public interface IAwardBLL
    {
        void AddAward(Award award);
        IEnumerable<Award> GetAllAwards();

        bool IsAwardAlreadyExist(string title);
        Award GetAwardById(Guid id);
        void DeleteAward(Guid id);
        void UpdateAward(Award award);
    }
}
