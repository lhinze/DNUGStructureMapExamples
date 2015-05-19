using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    public class Foo : EFoo
    {
        private readonly EBar _Bar;

        public Foo(EBar bar)
        {
            _Bar = bar;
        }

        public string Message
        {
            get
            {
                return string.Format("Message from {0}!", _Bar.User);
            }
        }
    }
}
