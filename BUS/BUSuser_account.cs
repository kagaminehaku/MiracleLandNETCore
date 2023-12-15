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

        public int RegisterUser(string usn, string pwd, string tp, string em, string pe, string add)
        {
            var daluseraccount = new DALuser_account();
            int id = daluseraccount.RegisterUser(usn, pwd, tp, em, pe, add);
            return id;
        }

        public bool UpdatePassword(string usn, string pwd)
        {
            var daluseraccount = new DALuser_account();
            return daluseraccount.UpdatePassword(usn, pwd);
        }
    }
}
