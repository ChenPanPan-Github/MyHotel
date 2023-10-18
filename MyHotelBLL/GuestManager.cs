using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyHotelDAL;
using MyHotelModel.DataBaseModel;

namespace MyHotelBLL
{
    public static class GuestManager
    {
        /// <summary>
        /// 查询未结账 客户信息
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public static List<GuestRecord> GetGuestRecord(DateTime startTime, DateTime endTime)
        {
            return GuestService.GetGuestRecord().FindAll(it => it.reside_date >= startTime && it.leave_date <= endTime && it.leave_date == Convert.ToDateTime("1900-01-01"));
        }
        /// <summary>
        /// 查询已结账 客户信息
        /// </summary>
        /// <param name="guestName"></param>
        /// <returns></returns>
        public static List<GuestRecord> GetGuestRecord(string guestName)
        {
            if(string.IsNullOrEmpty(guestName))
            {
                return GuestService.GetGuestRecord().FindAll(it => it.reside_id == 2);
            }
            return GuestService.GetGuestRecord().FindAll(it => it.guest_name == guestName && it.reside_id == 2);
        }
        /// <summary>
        /// 查询某一客户
        /// </summary>
        /// <param name="guestId"></param>
        /// <returns></returns>
        public static GuestRecord GetOneGuest(int guestId)
        {
            return GuestService.GetGuestRecord().Find(it => it.guest_id == guestId);
        }
        /// <summary>
        /// 添加客户记录
        /// </summary>
        /// <param name="tyName"></param>
        /// <returns></returns>
        public static bool AddGuestRecord(GuestRecord gr)
        {
            int retAdd = GuestService.AddGustRecord(gr);
            if (retAdd == 0) return false;
            //获取房间状态值
            RoomState state = RoomStateManager.GetAllRoomState().Find(it => it.roomstate_name == "入住");
            Room r = RoomManager.GetRoom(gr.room_id);
            if (state == null || r == null) return false;
            //改变房间状态
            r.roomstate_id = state.roomstate_id;
            bool retChange = RoomManager.UpdateRoom(r);
            if (retChange == false) return false;
            return true;
        }
        /// <summary>
        /// 结算房款 = 天数 * 价格
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static decimal PayMoney(int roomId, DateTime dt)
        {
            decimal money = TypeService.GetAllRoomType().Find(it => it.id == roomId).type_price;
            TimeSpan ts = DateTime.Now - dt;
            if (ts.Days == 0) return money;
            return money = ts.Days * money;
        }
        /// <summary>
        /// 结算更新
        /// </summary>
        /// <param name="gr"></param>
        /// <returns></returns>
        public static bool UpdateState(GuestRecord gr)
        {
            //更新用户记录状态
            int ret = GuestService.UpdateState(gr);
            if (ret == 0) return false;
            //更新住房状态
            //获取房间状态值
            RoomState state = RoomStateManager.GetAllRoomState().Find(it => it.roomstate_name == "空闲");
            Room r = RoomManager.GetRoom(gr.room_id);
            if (state == null || r == null) return false;
            //改变房间状态
            r.roomstate_id = state.roomstate_id;
            bool retChange = RoomManager.UpdateRoom(r);
            if (retChange == false) return false;
            return true;
        }
        public static bool UpdatePrice(int roomId, decimal money)
        {
            GuestRecord gr = GuestService.GetGuestRecord().Find(it => it.room_id == roomId && it.reside_id == 1);
            gr.dish_price = money;
            int ret = GuestService.UpdateState(gr);
            if (ret == 0) return false;
            return true;
        }
    }
}
