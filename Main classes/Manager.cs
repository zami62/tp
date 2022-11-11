using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp
{
    class Manager
    {
        public Manager() { }


        public ApprovedOrder ApproveOrder(ReceivedOrder order)
        {
            return new ApprovedOrder();
        }

        public OrderResponse RespondToOrder(ReceivedOrder order)
        {
            return new OrderResponse();
        }

        public void GetOrderPayment()
        {

        }

        public void OrderMBFromManufacturer()
        {

        }

        public bool CheckBasementForMB()
        {
            return true;
        }    
    }
}
