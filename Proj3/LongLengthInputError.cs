using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj3
{
    internal class LongLengthInputError : UserError
    {
        public override string UEMessage()
        {
            return "The input was too long.";
        }
    }
}
