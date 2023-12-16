using DTO;
using DAL;
using System;
using System.Collections.Generic;

namespace BUS
{
    public class BUSuser_account
    {
        public List<user_account> GetAllNguoiDung()
        {
            var daluseraccount = new DALuser_account();
            return daluseraccount.GetAllUser();
        }

        public string RegisterUser(string usn, string pwd, string tp, string em, string pe, string add)
        {
            pwd = BUSPWDHashing.EncryptData(pwd);
            var daluseraccount = new DALuser_account();
            string username = daluseraccount.RegisterUser(usn, pwd, tp, em, pe, add);
            return username;
        }

        public bool UpdatePassword(string usn, string newpwd)
        {
            newpwd = BUSPWDHashing.EncryptData(newpwd);
            var daluseraccount = new DALuser_account();
            return daluseraccount.UpdatePassword(usn, newpwd);
        }
    }
}
