using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace MyHotelModel.DataBaseModel
{
    //顾客登记实体
    public class GuestRecord
    {
        public GuestRecord()
        {
            this.reside_id = 1;
        }
        //顾客ID号 主键自增
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int guest_id { get; set; }
        //顾客名称
        public string guest_name { get; set; }
        //性别
        public string gender { get; set; }
        //身份号码
        public string identity_id { get; set; }
        //电话号码
        public string phone { get; set; }
        //房号
        public int room_id { get; set; }
        //入住状态ID
        public int reside_id { get; set; }
        //入住日期
        public DateTime reside_date { get; set; }
        //押金
        public decimal deposit { get; set; }
        //房款
        public decimal total_money { get; set; }
        //餐饮费用
        public decimal dish_price { get; set; }
        //退房日期
        public DateTime leave_date { get; set; }
        //交易号
        public string trade_no { get; set; }

    }
}
