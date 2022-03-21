using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSDP_Final_Project
{
    class CellTypeException : Exception
    {
        /* This CellTypeException is here to secure our switch/case in the decorator pattern 
         * when we enter a type of Cell that we want to create. This is the "default" response.
         */
        public CellTypeException(string _message)
        {
            message = _message;
        }

        private string message;
    }
}
