using System.Collections.Generic;
using Data.Entities;

namespace Services
{
    public interface IDummyServices
    {
        IEnumerable<Users> GetUsers();
        string method();
    }
}