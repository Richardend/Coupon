using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouponModel.DTO.ResponseDTO
{

    #region 这里可以是一个场景下定义的返回体
    public class ResourceDto 
    {
        public int ResourceId { get; set; }
        public byte TypeId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public byte CurrencyId { get; set; }
    }

    public class ResponseResourceDto : BaseResponseDto
    {
        public IEnumerable<ResourceDto> ResponseBody { get; set; }
    }

    #endregion
}