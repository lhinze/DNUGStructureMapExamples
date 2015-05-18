using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    public class Bar : IBar
    {
        public string User
        {
            get
            {
                return "User 1";
            }
        }
    }
}
