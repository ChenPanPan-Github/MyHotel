﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MyHotelDAL;
using MyHotelModel;

namespace MyHotelBLL
{
    public static class AdminManager
    {
        public static bool CheckIdPwd(Admin adm)
        {
            adm.password = Md5(adm.password);
            List<Admin> ret = AdminService.CheckIdPwd(adm);
            Admin res = ret.Find(it => adm.login_id == it.login_id && adm.password == it.password);
            if (res == null) return false;
            return true;
        }
        public static string Md5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.Default.GetBytes(str);
            byte[] md5data = md5.ComputeHash(data);
            md5.Clear();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < md5data.Length - 1; i++)
            {
                sb.Append(md5data[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
