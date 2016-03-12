using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CouponBusiness.SearchService;
using CouponModel.DTO.ResponseDTO;

namespace CouponBusiness
{
    public class ServiceFactory
    {
        /// <summary>
        /// 查询服务
        /// </summary>
        /// <returns></returns>
       public static ISearchService<BaseResponseDto> CreateSearchTargetService()
       {
           //这里通过switch根据传入参数判断采用那个具体方法
           return new Resource();
       }


        //以下的方法是针对订单服务的。
        //public static IOrderService<BaseResponseDto> CreateOrderTargetService()
        //{
        //    return new OrderService();
        //}

    }
  

}
