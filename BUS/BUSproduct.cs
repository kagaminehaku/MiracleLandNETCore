using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSproduct
    {
        public List<product> GetAllNguoiDung()
        {
            var dalproduct = new DALproduct();
            return dalproduct.GetAllProduct();
        }

        public string AddNewProduct(string newpname, int newpprice, int newpquantity, string newpinfo, string newpimg)
        {
            var dalproduct = new DALproduct();
            string productname = dalproduct.AddNewProduct( newpname, newpprice, newpquantity, newpinfo, newpimg);
            return productname;
        }

        public bool UpdateProduct(int id, string newpname, int newpprice, int newpquantity, string newpinfo, string newpimg)
        {
            var dalproduct = new DALproduct();
            return dalproduct.UpdateProduct(id, newpname, newpprice, newpquantity, newpinfo, newpimg);
        }

        public bool RemoveProduct(int id)
        {
            var dalproduct = new DALproduct();
            return dalproduct.RemoveProduct(id);
        }
    }
}
