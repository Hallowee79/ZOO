using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.ClassHelper
{
     public static class EfClass
    {
        public static Entities Context { get; } = new Entities();
    }
}
