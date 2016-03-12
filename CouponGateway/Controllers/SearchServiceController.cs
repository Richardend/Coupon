using System.Web.Http;
using CouponBusiness;
using CouponModel.DTO.ResponseDTO;


namespace CouponGateway.Controllers
{
    public class SearchServiceController : ApiController
    {
        //private CouponDBEntities db = new CouponDBEntities();

        // GET: api/Resources
        public ResponseResourceDto GetResources()
        {
            
            ISearchService<BaseResponseDto> factory = ServiceFactory.CreateSearchTargetService();
            return factory.GetEntityDate() as ResponseResourceDto;

            //CouponService<BaseResponseDto> factorysearchservice = new ResourceAbs<BaseResponseDto>();
            //return factorysearchservice.GetEntityDate() as ResponseResourceDto;
            //var res = from b in db.Resources
            //          select new ResourceDTO()
            //            {
            //                ResourceID = b.ResourceID,
            //                TypeID = b.TypeID,
            //                Name = b.Name,
            //                Amount = b.Amount,
            //                CurrencyID = b.CurrencyID
            //            };

            //return res;

            //return db.Resources;
        }

      
    }
}