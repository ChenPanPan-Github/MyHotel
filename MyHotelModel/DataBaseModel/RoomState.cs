using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace MyHotelModel.DataBaseModel
{
    public class RoomState
    {

        //状态ID 主键自增
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int roomstate_id { get; set; }
        //状态名称
        public string roomstate_name { get; set; }

    }
}
