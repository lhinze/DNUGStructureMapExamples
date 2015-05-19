using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example6
{
    public class Bar : IBar
    {
        private readonly string _Name;

        public Bar(string name)
        {
            _Name = name;
        }

        public string User
        {
            get
            {
                return _Name;
            }
        }
    }
}
