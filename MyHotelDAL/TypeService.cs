using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyHotelModel.CommonModel;

namespace MyHotelDAL
{
    public static class TypeService
    {
        /// <summary>
        /// 查
        /// </summary>
        /// <returns></returns>
        public static List<RoomType> GetAllRoomType()
        {
            return SqlHelper.db.Queryable<RoomType>().ToList();
        }
        /// <summary>
        /// 增
        /// </summary>
        /// <param name="rt"></param>
        /// <returns></returns>
        public static int AddRoomType(RoomType rt)
        {
            return SqlHelper.db.Insertable<RoomType>(rt).ExecuteCommand();
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="rt"></param>
        /// <returns></returns>
        public static int UpdateRoomType(RoomType rt)
        {
            return SqlHelper.db.Updateable<RoomType>(rt).ExecuteCommand();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="rt"></param>
        /// <returns></returns>
        public static int DeleteRoomType(RoomType rt)
        {
            return SqlHelper.db.Deleteable<RoomType>(rt).ExecuteCommand();
        }
    }
}
