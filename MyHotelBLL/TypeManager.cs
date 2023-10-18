using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyHotelDAL;
using MyHotelModel.CommonModel;

namespace MyHotelBLL
{
    public static class TypeManager
    {
        /// <summary>
        /// 获取房间信息
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public static List<RoomType> GetAllRoomType(string typeName)
        {
            List<RoomType> ret = TypeService.GetAllRoomType();
            if (string.IsNullOrEmpty(typeName))
                return ret;
            return ret.FindAll(it => typeName == it.type_name);
        }
        /// <summary>
        /// 添加房间类型
        /// </summary>
        /// <param name="tyName"></param>
        /// <returns></returns>
        public static bool AddRoomType(RoomType rt)
        {
            int ret = TypeService.AddRoomType(rt);
            if (ret == 0) return false;
            return true;
        }
        /// <summary>
        /// 删除房间信息
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public static bool DeleteRoomType(RoomType rt)
        {
            int ret = TypeService.DeleteRoomType(rt);
            if (ret == 0) return false;
            return true;
        }
        /// <summary>
        /// 修改房间信息
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public static bool UpdateRoomType(RoomType rt)
        {
            int ret = TypeService.UpdateRoomType(rt);
            if (ret == 0) return false;
            return true;
        }
    }
}
