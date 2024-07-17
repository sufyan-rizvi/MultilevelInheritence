using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MultilevelInheritence.Models
{
    internal class WarmBlooded : Animals
    {
        public string WarmNoises()
        {
            return ("I am WarmBlooded");
        }
    }
}
