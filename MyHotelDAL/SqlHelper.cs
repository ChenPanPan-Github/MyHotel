using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace MyHotelDAL
{
    public static class SqlHelper
    {
        /// <summary>
        /// 数据库配置
        /// </summary>
        public static SqlSugarClient db = new SqlSugarClient(new ConnectionConfig() {
            ConnectionString = "Data Source=127.0.0.1;User ID=root;Password=pan123;Database=hotel_db;Charset=utf8",
            DbType = DbType.MySql,
            IsAutoCloseConnection = true,
            InitKeyType = InitKeyType.Attribute
        });
    }
}
