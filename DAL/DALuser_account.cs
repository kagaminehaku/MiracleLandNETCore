using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using DTO;



namespace DAL
{
    public class DALuser_account
    {
        private static DALuser_account instance;

        public List<user_account> GetAllUser()
        {
            using (var dbContext = new TSMGEntities()) // Create a new instance
            {
                return dbContext.user_account.AsNoTracking().ToList();
            }
        }

        public user_account GetUserByUsername(string usn)
        {
            using (var dbContext = new TSMGEntities())
            {
                return dbContext.user_account.Find(usn);
            }
        }

        public int RegisterUser(string usn, string pwd, string tp, string em, string pe, string add)
        {
            pwd = DALPWDHashing.EncryptData(pwd);

            try
            {
                using (var dbContext = new TSMGEntities()) // Create a new instance
                {
                    var user = new user_account
                    {
                        username = usn,
                        password = pwd,
                        type = tp,
                        email = em,
                        phone = pe,
                        address = add,
                    };

                    dbContext.user_account.Add(user);
                    dbContext.SaveChanges();

                    return user.id;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return -1;
            }
        }

        public bool UpdatePassword(string usn, string newPassword)
        {
            try
            {
                using (var dbContext = new TSMGEntities())
                {
                    var user = dbContext.user_account.Find(usn);
                    if (user == null) return false;

                    user.password = DALPWDHashing.EncryptData(newPassword);
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
