using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class BUSorders
    {
        public string AddNewOrders(int userid, int total)
        {
            var dalorders = new DALorders();
            string totalforcus = dalorders.AddOrders(userid,total);
            return totalforcus;
        }
    }
}
