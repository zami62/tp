using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace tp
{
    public class MetalBlank
    {
        public float MBWeight { get; private set; }
        public Vector3 MBDimensions { get; private set; }

        public float MBCost { get; private set; }

        public Material MBMaterial { get; private set; }


        public MetalBlank() { }

        public MetalBlank(Vector3 dimensions, Material material)
        {
            MBDimensions = dimensions;
            MBMaterial = material;
        }
    }
}
