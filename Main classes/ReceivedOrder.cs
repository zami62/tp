using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp
{
    public class ReceivedOrder
    {
        public string OrderMessage { get; private set; }

        private List<PartModel> PartsModels = new List<PartModel>();
    }
}
