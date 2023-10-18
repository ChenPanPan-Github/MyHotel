using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyHotelDAL;
using MyHotelModel.DataBaseModel;

namespace MyHotelBLL
{
    public static class RoomManager
    {
        /// <summary>
        /// 获取房间信息
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns></returns>
        public static List<RoomExpand> GetAllRoom(string roomId)
        {
            List<RoomExpand> ret = RoomService.GetAllRoomExpand();
            if (string.IsNullOrEmpty(roomId))
            {
                return ret;
            }
            return ret.FindAll(it => Convert.ToInt32(roomId) == it.room_id);
        }
        /// <summary>
        /// 获取roomId的房间
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns></returns>
        public static Room GetRoom(int roomId)
        {
            return RoomService.GetAllRoom().Find(it => roomId == it.room_id);
        }
        /// <summary>
        /// 获取全部空余房间
        /// </summary>
        /// <returns></returns>
        public static List<Room> GetFreeRoom()
        {
            RoomState state = RoomStateManager.GetAllRoomState().Find(it => it.roomstate_name =="空闲");
            return RoomService.GetAllRoom().FindAll(it => it.roomstate_id == state.roomstate_id);
        }
        /// <summary>
        /// 添加房间类型
        /// </summary>
        /// <param name="tyName"></param>
        /// <returns></returns>
        public static bool AddRoom(Room rt)
        {
            int ret = RoomService.AddRoom(rt);
            if (ret == 0) return false;
            return true;
        }
        /// <summary>
        /// 删除房间信息
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public static bool DeleteRoom(Room rt)
        {
            int ret = RoomService.DeleteRoom(rt);
            if (ret == 0) return false;
            return true;
        }
        /// <summary>
        /// 修改房间信息
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public static bool UpdateRoom(Room rt)
        {
            int ret = RoomService.UpdateRoom(rt);
            if (ret == 0) return false;
            return true;
        }
        /// <summary>
        /// 获取某一种房间类型房间总数
        /// </summary>
        /// <param name="typeId">0表示全部房间，其他...</param>
        /// <returns></returns>
        public static int GetRoomCount(int typeId)
        {
            if(typeId == 0)
                return RoomService.GetAllRoom().Count;
            return RoomService.GetAllRoom().FindAll(it => it.roomtype_id == typeId).Count;
        }
        
        /// <summary>
        /// 获去某一种房间类型对应状态的房间总数
        /// </summary>
        /// <param name="type">type={0，1，2，3};//0表示全部房间，1表示入住，2表示空闲，3表示维修</param>
        /// <returns></returns>
        public static int GetRoomStateCount(int typeId, int state)
        {
            if(typeId == 0)
                return RoomService.GetAllRoom().FindAll(it => it.roomstate_id == state).Count;
            return RoomService.GetAllRoom().FindAll(it => it.roomstate_id == state && it.roomtype_id == typeId).Count;
        }
        public static List<RoomExpand> GetRoomStateByType(int typeId)
        {
            return RoomService.GetAllRoomExpand().FindAll(it => it.roomtype_id == typeId);
        }
    }
}
