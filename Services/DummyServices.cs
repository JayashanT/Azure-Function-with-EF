using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class DummyServices : IDummyServices
    {
        public string method()
        {
            return ("user");
        }
    }
}
