using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8._1.UserAwards.Common.Entities
{
    public class Award
    {
        public Award(string title)
        {
            Id = Guid.NewGuid();
            Title = title;
        }
        [JsonConstructor]
        public Award(Guid id,string title)
        {
            Id = id;
            Title = title;
        }
        public Guid Id { get; }
        public string Title { get; private set; }
    }
}
