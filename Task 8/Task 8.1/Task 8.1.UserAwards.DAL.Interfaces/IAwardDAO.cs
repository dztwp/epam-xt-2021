using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_8._1.UserAwards.Common.Entities;

namespace Task_8._1.UserAwards.DAL.Interfaces
{
    public interface IAwardDAO
    {
        void AddAward(Award award);

        void DeleteAward(Guid id);
        void UpdateAward(Award award);
        IEnumerable<Award> GetAllAwards();

        bool IsAwardAlreadyExist(string name);

        Award GetAwardById(Guid id);

    }
}
