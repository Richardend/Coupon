using CouponModel;
using CouponModel.DTO;
using CouponModel.DTO.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponBusiness.SearchService
{
    public class Resource : ISearchService<ResponseResourceDto>
        
    {
        CouponDBEntities Db = new CouponDBEntities();
        //public IEnumerable<T> GetEntityDate()
        //{
        //    //今后这里通过判断传入的对象，再判断具体调用那个方法
        //    var response = base.Db.Resources;
        //    IEnumerable<ResourceCurrDTO> res = from b in response
        //               select new ResourceCurrDTO()
        //               {
        //                   ResourceID = b.ResourceID,
        //                   TypeID = b.TypeID,
        //                   Name = b.ShowName,
        //                   Amount = b.SalePrice,
        //                   CurrencyName = b.IsEnable
        //               };

        //     return res;

        //}

        public ResponseResourceDto GetEntityDate()
        {
            var response = Db.Resources;
            IEnumerable<ResourceDto> query = from b in response
                                             select new ResourceDto()
                                             {
                                                 ResourceId = b.ResourceID,
                                                 TypeId = b.TypeID,
                                                 Name = b.ShowName,
                                                 Amount = b.SalePrice,
                                                 CurrencyId = b.SalePriceCurrencyID
                                             };

            ResponseResourceDto res = new ResponseResourceDto();
            res.Ack = "ok";
            res.ResponseBody = query;
            return res;
        }
    }

    //public class ResourceAbs<T> : CouponService<T> where T:BaseResponseDto
    //{
    //    CouponDBEntities Db = new CouponDBEntities();
    //    public override T GetEntityDate()
    //    {
    //        var response = Db.Resources;
    //        IEnumerable<ResourceDto> query = from b in response
    //                                         select new ResourceDto()
    //                                         {
    //                                             ResourceId = b.ResourceID,
    //                                             TypeId = b.TypeID,
    //                                             Name = b.ShowName,
    //                                             Amount = b.SalePrice,
    //                                             CurrencyId = b.SalePriceCurrencyID
    //                                         };

    //        ResponseResourceDto res = new ResponseResourceDto();
    //        res.Ack = "ok";
    //        res.ResponseBody = query;
    //        return res as T;
    //    }
    //}


}
