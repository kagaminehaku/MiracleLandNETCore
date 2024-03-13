using DTOCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DAL
{
    public class DALshopping_cart
    {
        public List<ShoppingCart> GetAllItemInUserCart(int uid) 
        {
            using (var dbContext = new TsmgContext())
            {
                return dbContext.ShoppingCarts.Where(cart => cart.Id == uid).ToList();
            }
        }

        public ShoppingCart GetExistCartItem(int uid, int pid)
        {
            using (var dbContext = new TsmgContext())
            {
                return dbContext.ShoppingCarts.FirstOrDefault(cart => cart.Id == uid && cart.Pid == pid);
            }
        }

        public void UpdateItemQtyInCart(int uid, int pid ,int newqty)
        {
            try
            {
                using (var dbContext = new TsmgContext())
                {
                    var CartItem = dbContext.ShoppingCarts.FirstOrDefault(cart => cart.Id == uid && cart.Pid == pid);
                    CartItem.Pquantity = CartItem.Pquantity+newqty;
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void DeleteItemInCart (int uid, int pid)
        {
            try
            {
                using (var dbContext = new TsmgContext())
                {
                    var CartItem = dbContext.ShoppingCarts.FirstOrDefault(cart => cart.Id == uid && cart.Pid == pid);
                    dbContext.ShoppingCarts.Remove(CartItem);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void AddItemToCart (int uid ,int pid ,int newqty)
        {
            try
            {
                using (var dbContext = new TsmgContext())
                {
                    var existingItem = GetExistCartItem(uid,pid);
                    if (existingItem != null)
                    {
                        UpdateItemQtyInCart (uid, pid , newqty);
                    }

                    var CartItem = new ShoppingCart
                    {
                        Id = uid,
                        Pid = pid,
                        Pquantity = newqty
                    };
                    Console.WriteLine(CartItem.Id);
                    Console.WriteLine(CartItem.Pid);
                    Console.WriteLine(CartItem.Pquantity);
                    dbContext.ShoppingCarts.Add(CartItem);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
             
    }
}
