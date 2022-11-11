using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp
{
    public class ApprovedOrder
    {
        public float OrderCost { get; private set; }

        public int OrderID { get; private set; }

        private List<Part> Parts = new List<Part>();

        public ReceivedOrder OrderForResponse { get; private set; }

    }
}
