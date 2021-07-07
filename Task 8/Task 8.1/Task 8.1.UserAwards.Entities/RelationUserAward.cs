using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8._1.UserAwards.Common.Entities
{
    public class RelationUserAward
    {
        public Guid UserId { get;}
        public Guid AwardId { get; }
        public RelationUserAward(Guid userId,Guid awardId)
        {
            UserId = userId;
            AwardId = awardId;
        }

    }
}
