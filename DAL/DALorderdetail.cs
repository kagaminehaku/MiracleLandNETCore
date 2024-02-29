using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOCore;

namespace DAL
{
    public class DALorderdetail
    {
        public bool AddOrderDetail(int orderid, int pid, int quantity)
        {
            try
            {
                using (var dbContext = new TsmgContext())
                {
                    var orders_detail = new OrderDetail
                    {
                        Orderid = orderid,
                        Pid = pid, 
                        Quantity = quantity
                    };

                    dbContext.OrderDetails.Add(orders_detail);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch 
            {
                return false;
            }
        }
    }
}
