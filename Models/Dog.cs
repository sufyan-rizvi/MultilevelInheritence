using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritence.Models
{
    internal class Dog: Mammals
    {
        public string DogNoise()
        {
            return ("I am Dog!");
        }
    }
}
