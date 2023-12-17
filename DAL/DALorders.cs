using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class DALorders
    {
        public string AddOrders(int userid, long total)
        {
            try
            {
                using (var dbContext = new TSMGEntities())
                {
                    var orders = new order
                    {
                        userid = userid, 
                        total = total
                    };

                    dbContext.orders.Add(orders);
                    dbContext.SaveChanges();
                    return orders.orderid.ToString();
                }
            }
            catch (Exception ex)
            {
                return $"An error occurred: {ex.GetType().Name} - {ex.Message}\nStack Trace: {ex.StackTrace}";
            }
        }
    }
}
