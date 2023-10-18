using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelModel
{
    public class Admin
    {
        public Admin() { }
        public Admin(string loginId, string passWord)
        {
            this.login_id = loginId;
            this.password = passWord;
        }
        public string login_id { get; set; }//用户名
        public string password { get; set; }//密码
    }
}
