using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace MyHotelModel.CommonModel
{
    /// <summary>
    /// 房间类型实体类
    /// </summary>
    public class RoomType
    {
        public RoomType() { }
        public RoomType(string typeName, decimal typePrice)
        {
            this.type_name = typeName;
            this.type_price = typePrice;
        }
        public RoomType(int typeId, string typeName, decimal typePrice)
        {
            this.id = typeId;
            this.type_name = typeName;
            this.type_price = typePrice;
        }
        //序列号ID，主键
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }
        //房间类型名
        public string type_name { get; set; }
        //房间类型价格
        public decimal type_price { get; set; }
    }
}
