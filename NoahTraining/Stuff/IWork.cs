using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoahTraining.Stuff
{
    public interface IWork
    {
        string GetFullName(int id);
        string GetFullName(int id, string lastName);
        string GetFullNameFromLast(int id, string firstName);
    }
}
