using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyHotelDAL;
using MyHotelModel.DataBaseModel;

namespace MyHotelBLL
{
    public static class DishManager
    {
        /// <summary>
        /// 获取餐饮信息
        /// </summary>
        /// <param name="DiashName"></param>
        /// <returns></returns>
        public static List<DishList> GetDishList(string DiashName)
        {
            List<DishList> ret = DishService.GetDishList();
            if (string.IsNullOrEmpty(DiashName))
                return ret;
            return ret.FindAll(it => DiashName == it.dish_name);
        }
        /// <summary>
        /// 添加餐饮类型
        /// </summary>
        /// <param name="dl"></param>
        /// <returns></returns>
        public static bool AddDish(DishList dl)
        {
            int ret = DishService.AddDish(dl);
            if (ret == 0) return false;
            return true;
        }
        /// <summary>
        /// 删除餐饮信息
        /// </summary>
        /// <param name="dl"></param>
        /// <returns></returns>
        public static bool DeleteDish(DishList dl)
        {
            int ret = DishService.DeleteDish(dl);
            if (ret == 0) return false;
            return true;
        }
        /// <summary>
        /// 修改餐饮信息
        /// </summary>
        /// <param name="dl"></param>
        /// <returns></returns>
        public static bool UpdateDish(DishList dl)
        {
            int ret = DishService.UpdateDish(dl);
            if (ret == 0) return false;
            return true;
        }
    }
}
