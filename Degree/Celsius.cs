using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degree
{
    public class Celsius
    {
        public double Degree { get; set; }
        public Celsius(double degree)
        {
            Degree = degree;
        }

       

        public static implicit operator Celsius(Kelvin degree)
        {
            return new Celsius(degree.Degree - 273);
        }
    }
}
