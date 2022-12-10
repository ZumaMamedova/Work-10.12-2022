using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degree
{
    public class Kelvin
    {
        public double Degree { get; set; }
        public Kelvin( double degree)
        {
            Degree = degree;
        }

        

        public static implicit operator Kelvin(Celsius degree)
        {
            return new Kelvin(degree.Degree+273);
        }
    }
    
}
