using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyHotelModel.CommonModel;
using MyHotelModel.DataBaseModel;

namespace MyHotelDAL
{
    public static class RoomService
    {
        /// <summary>
        /// 查询所有房间信息
        /// </summary>
        /// <returns>返回RoomExpand类型集合</returns>
        public static List<RoomExpand> GetAllRoomExpand()
        {
            List<Room> rm = SqlHelper.db.Queryable<Room>().ToList();
            List<RoomState> rs = SqlHelper.db.Queryable<RoomState>().ToList();
            List<RoomType> rt = SqlHelper.db.Queryable<RoomType>().ToList();
            List<RoomExpand> res = new List<RoomExpand>();
            foreach(var it in rm)
            {
                RoomExpand r = new RoomExpand() {
                    room_id = it.room_id,
                    bed_num = it.bed_num,
                    roomstate_id = it.roomstate_id,
                    roomtype_id = it.roomtype_id,
                    description = it.description,
                    roomstate_name = rs.Find(tar => tar.roomstate_id == it.roomstate_id).roomstate_name,
                    roomtype_name = rt.Find(tar => tar.id == it.roomtype_id).type_name
                };
                res.Add(r);
            }
            return res;
        }
        /// <summary>
        /// 查询所有房间信息
        /// </summary>
        /// <returns>返回Room类型集合</returns>
        public static List<Room> GetAllRoom()
        {
            return SqlHelper.db.Queryable<Room>().ToList();
        }
        /// <summary>
        /// 增
        /// </summary>
        /// <param name="rt"></param>
        /// <returns></returns>
        public static int AddRoom(Room rt)
        {
            return SqlHelper.db.Insertable<Room>(rt).ExecuteCommand();
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="rt"></param>
        /// <returns></returns>
        public static int UpdateRoom(Room rt)
        {
            return SqlHelper.db.Updateable<Room>(rt).ExecuteCommand();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="rt"></param>
        /// <returns></returns>
        public static int DeleteRoom(Room rt)
        {
            return SqlHelper.db.Deleteable<Room>(rt).ExecuteCommand();
        }
    }
}
