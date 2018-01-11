using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2sem1
{
    class ParkingOverflowException : Exception
    {
        public ParkingOverflowException() :
            base("В магазине нет свободных мест")
        { }
    }
}
