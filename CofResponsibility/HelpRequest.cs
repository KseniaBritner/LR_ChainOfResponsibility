using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofResponsibility
{
    public class HelpRequest
    {
        public char Sign { get; private set; }
        public HelpRequest(char sign)
        {
            Sign = sign;
        }
    }
}
