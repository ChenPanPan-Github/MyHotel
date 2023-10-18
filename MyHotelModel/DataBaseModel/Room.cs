using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace MyHotelModel.DataBaseModel
{
    /// <summary>
    /// 房间信息实体类
    /// </summary>
    public class Room
    {
        //房间号，主键
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int room_id { get; set; }
        //房间类型号
        public int roomtype_id { get; set; }
        //房间状态号
        public int roomstate_id { get; set; }
        //房间描述
        public string description { get; set; }
        //床数
        public int bed_num { get; set; }
    }
}
