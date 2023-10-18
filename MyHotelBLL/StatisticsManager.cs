using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyHotelModel.DataBaseModel;

namespace MyHotelBLL
{
    public static class StatisticsManager
    {
        /// <summary>
        /// 获取每月的房款总数收入
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static double[] GetMoney(int year)
        {
            double[] money = new double[12];
            List<GuestRecord> gr = GuestManager.GetGuestRecord("").FindAll(it => it.leave_date.Year == year);
            foreach (var item in gr)
            {
                int month = item.leave_date.Month;
                money[month] += Convert.ToDouble(item.total_money);
            }
            return money;
        }
        /// <summary>
        /// 获取每月的餐饮收入
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static double[] GetDishPrice(int year)
        {
            double[] price = new double[12];
            List<GuestRecord> gr = GuestManager.GetGuestRecord("").FindAll(it => it.leave_date.Year == year);
            foreach (var item in gr)
            {
                int month = item.leave_date.Month;
                price[month] += Convert.ToDouble(item.dish_price);
            }
            return price;
        }

        /// <summary>
        /// 获取一年的总房款收入
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static double SumTotalMoney(int year)
        {
            double totalMoney = 0;
            List<GuestRecord> gr = GuestManager.GetGuestRecord("").FindAll(it => it.leave_date.Year == year);
            foreach (var item in gr)
            {
                totalMoney += Convert.ToDouble(item.total_money);
            }
            return totalMoney;
        }
        /// <summary>
        /// 获取一年的餐饮总收入
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static double SumDishMoney(int year)
        {
            double DishMoney = 0;
            List<GuestRecord> gr = GuestManager.GetGuestRecord("").FindAll(it => it.leave_date.Year == year);
            foreach (var item in gr)
            {
                DishMoney += Convert.ToDouble(item.dish_price);
            }
            return DishMoney;
        }
    }
}