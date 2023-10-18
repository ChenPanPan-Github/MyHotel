using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyHotelModel.DataBaseModel;

namespace MyHotelDAL
{
    public static class GuestService
    {
        /// <summary>
        /// 查
        /// </summary>
        /// <returns></returns>
        public static List<GuestRecord> GetGuestRecord()
        {
            return SqlHelper.db.Queryable<GuestRecord>().ToList();
        }
        /// <summary>
        /// 增
        /// </summary>
        /// <param name="rt"></param>
        /// <returns></returns>
        public static int AddGustRecord(GuestRecord gr)
        {
            return SqlHelper.db.Insertable<GuestRecord>(gr).ExecuteCommand();
        }
        /// <summary>
        /// 更
        /// </summary>
        /// <param name="gr"></param>
        /// <returns></returns>
        public static int UpdateState(GuestRecord gr)
        {
            return SqlHelper.db.Updateable<GuestRecord>(gr).ExecuteCommand();
        }
    }
}
