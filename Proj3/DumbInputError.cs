using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj3
{
    internal class DumbInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to input something dumb. This fired an error!";
        }
    }
}
