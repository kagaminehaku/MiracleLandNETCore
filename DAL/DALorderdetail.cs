using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALorderdetail
    {
        public bool AddOrderDetail(int orderid, int pid, int quantity)
        {
            try
            {
                using (var dbContext = new TSMGEntities())
                {
                    var orders_detail = new order_detail
                    {
                        orderid = orderid,
                        pid = pid, 
                        quantity = quantity
                    };

                    dbContext.order_detail.Add(orders_detail);
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
