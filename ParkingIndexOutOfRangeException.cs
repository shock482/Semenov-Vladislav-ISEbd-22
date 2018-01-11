using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2sem1
{
    class ParkingIndexOutOfRangeException : Exception
    {
        public ParkingIndexOutOfRangeException() :
            base("В магазине нет драгоценности по такому индексу")
        { }
    }
}
