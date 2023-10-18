using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyHotelModel;

namespace MyHotelDAL
{
    public static class AdminService
    {
        public static List<Admin> CheckIdPwd(Admin adm)
        {
            return SqlHelper.db.Queryable<Admin>().ToList();
        }
    }
}
