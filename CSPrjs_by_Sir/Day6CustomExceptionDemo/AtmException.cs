using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6CustomExceptionDemo
{
    class AtmException : Exception
    {
        public AtmException(string errMsg) : base(errMsg)
        {
            //TODDO log the errors in file etc
        }
    }
}
