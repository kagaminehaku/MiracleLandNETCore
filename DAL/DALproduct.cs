using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALproduct
    {
        public List<product> GetAllProduct()
        {
            using (var dbContext = new TSMGEntities())
            {
                return dbContext.products.AsNoTracking().ToList();
            }
        }

        public product GetProductByID(int pid)
        {
            using (var dbContext = new TSMGEntities())
            {
                return dbContext.products.FirstOrDefault(u => u.pid == pid);
            }
        }

        public product GetProductByName(string pname)
        {
            using (var dbContext = new TSMGEntities())
            {
                return dbContext.products.FirstOrDefault(u => u.pname == pname);
            }
        }

        public string AddNewProduct(string pname, int pprice, int pquantity, string pinfo, string pimg)
        {
            try
            {
                using (var dbContext = new TSMGEntities())
                {
                    var existingProduct = GetProductByName(pname);
                    if (existingProduct != null)
                    {
                        return "Product name is Duplicate";
                    }

                    var product = new product
                    {
                        pname = pname,
                        pprice = pprice,
                        pquantity = pquantity,
                        pinfo = pinfo,
                        pimg = pimg
                    };

                    dbContext.products.Add(product);
                    dbContext.SaveChanges();
                    return product.pname;
                }
            }
            catch (Exception ex)
            {
                return "An error occurred: " + ex.Message;
            }
        }

        public bool UpdateProduct(int id, string newpname, int newpprice, int newquantity, string newpinfo, string pimg)
        {
            try
            {
                using (var dbContext = new TSMGEntities())
                {
                    var product = dbContext.products.Find(id);
                    if (product == null) return false;
                    product.pname = newpname; 
                    product.pprice = newpprice;
                    product.pquantity = newquantity;
                    product.pinfo = newpinfo;
                    product.pimg = pimg;
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool RemoveProduct(int id)
        {
            try
            {
                using (var dbContext = new TSMGEntities())
                {
                    var product = dbContext.products.Find(id);
                    if (product == null) return false;
                    dbContext.products.Remove(product);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

    }
}
