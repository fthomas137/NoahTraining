using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoahTraining.Stuff
{
    public class Work : IWork
    {
        public string GetFullName(int id)
        {
            if (id == 1)
            {
                var person = new Person()
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Barker"
                };
                return person.FirstName + " " + person.LastName;
            }
            return null;
        }

        public string GetFullName(int id, string lastName)
        {
            if (id == 1)
            {
                var person = new Person()
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = lastName
                };
                return person.FirstName + " " + person.LastName;
            }
            return null;
        }

        public string GetFullNameFromLast(int id, string firstName)
        {
            throw new NotImplementedException();
        }
    }
}
