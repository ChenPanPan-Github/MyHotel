using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyHotelModel.DataBaseModel;

namespace MyHotelDAL
{
    public static class DishService
    {
        /// <summary>
        /// 查
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public static List<DishList> GetDishList()
        {
            return SqlHelper.db.Queryable<DishList>().ToList();
        }
        /// <summary>
        /// 增
        /// </summary>
        /// <param name="rt"></param>
        /// <returns></returns>
        public static int AddDish(DishList dl)
        {
            return SqlHelper.db.Insertable<DishList>(dl).ExecuteCommand();
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="rt"></param>
        /// <returns></returns>
        public static int UpdateDish(DishList dl)
        {
            return SqlHelper.db.Updateable<DishList>(dl).ExecuteCommand();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="rt"></param>
        /// <returns></returns>
        public static int DeleteDish(DishList dl)
        {
            return SqlHelper.db.Deleteable<DishList>(dl).ExecuteCommand();
        }
    }
}
