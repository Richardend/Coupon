using CouponModel.DTO.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CouponBusiness
{
    /// <summary>
    /// 查询服务处理类接口
    /// </summary>
    /// <typeparam name="TResponseEntity"></typeparam>
    public interface ISearchService<out TResponseEntity> where TResponseEntity : BaseResponseDto
    {
        /// <summary>
        /// 查询服务：获取实体数据
        /// </summary>
        /// <returns></returns>
        TResponseEntity GetEntityDate();
    }


    //public abstract class CouponService<T> where T:BaseResponseDto
    //{
    //    public abstract T GetEntityDate();
        
    //}



}
