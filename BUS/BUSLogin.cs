using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS
{
    public class BUSLogin
    {
        public user_account checkValidLogin(string usrname, string usrpwd)
        {
            var dalUserAccount = new DALuser_account();
            List<user_account> found = dalUserAccount.GetAllUser();
            usrpwd = BUSPWDHashing.EncryptData(usrpwd);

            foreach (var user in found)
            {
                if (user.username == usrname && user.password == usrpwd)
                {
                    return user;
                }

            }
            return null; 
        }

    }
}
