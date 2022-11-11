using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace tp
{
    public class Part
    {
        public string PName { get; private set; }

        public float PWeight { get; private set; }
        public Vector3 PDimensions { get; private set; }

        public PartModel PPartModel { get; private set; }
        public MetalBlank PMetalBlank { get; private set; }


        public Part() { }

        public Part(string name, Vector3 dimensions, MetalBlank metalBlank)
        {
            PName = name;
            PDimensions = dimensions;
            PMetalBlank = metalBlank;
        }
    }
}
