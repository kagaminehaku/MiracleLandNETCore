using System;
using System.Collections.Generic;
using DAL;
using DTOCore;

namespace BUS
{
    public class BUSLogin
    {
        public UserAccount checkValidLogin(string usrname, string usrpwd)
        {
            var dalUserAccount = new DALuser_account();
            List<UserAccount> found = dalUserAccount.GetAllUser();
            usrpwd = BUSPWDHashing.EncryptData(usrpwd);

            foreach (var user in found)
            {
                if (user.Username == usrname && user.Password == usrpwd)
                {
                    return user;
                }

            }
            return null; 
        }

    }
}
