using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS
{
    public class BUSLogin
    {
        public int checkValidLogin(string usrname, string usrpwd)
        {
            DALuser_account dalUserAccount = new DALuser_account(); // Create a new instance directly
            List<user_account> found = dalUserAccount.GetAllNguoiDung();

            foreach (var user in found)
            {
                if (user.username == usrname && user.password == usrpwd)
                {
                    return user.id;
                }
            }

            return -1;
        }

    }
}
