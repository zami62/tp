using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace tp
{
    public class Material
    {
        public string MName { get; private set; }

        public float MDensity { get; private set; }

        public float MCost { get; private set; }


        public Material() { }

        public Material(string name, float density, float cost)
        {
            MName = name;
            MDensity = density;
            MCost = cost;
        }
    }

}
