using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace MyHotelModel.DataBaseModel
{
    //餐饮实体
    public class DishList
    {
        //餐品id，主键自增
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int dish_id { get; set; }
        //餐品名称
        public string dish_name { get; set; }
        //单位
        public string unit { get; set; }
        //价格
        public decimal price { get; set; }
    }
}
