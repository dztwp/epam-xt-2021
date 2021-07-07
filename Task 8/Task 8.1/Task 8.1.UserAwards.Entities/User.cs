using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8._1.UserAwards.Common.Entities
{
    public class User
    {
        [JsonConstructor]
        public User(Guid id,string name, DateTime dateOfBirth)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            Age = DateTime.Now.Year - DateOfBirth.Year;
        }
        public User( string name, DateTime dateOfBirth)
        {
            Id = Guid.NewGuid();
            Name = name;
            DateOfBirth = dateOfBirth;
            Age = DateTime.Now.Year-DateOfBirth.Year;
        }

        public Guid Id { get; }
        public string Name { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public int Age { get;}
    }
}
