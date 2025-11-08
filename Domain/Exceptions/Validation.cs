using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    internal class Validation : Exception
    {
        public Validation(string message) : base(message)
        {
        }
    }
}
