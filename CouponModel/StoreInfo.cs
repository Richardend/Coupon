//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CouponModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class StoreInfo
    {
        public int StoreID { get; set; }
        public string StoreAdrr { get; set; }
        public string StoreName { get; set; }
        public byte AreaType { get; set; }
        public byte CountryID { get; set; }
        public byte ProvinceID { get; set; }
        public int CityID { get; set; }
        public decimal LongitudeGMap { get; set; }
        public decimal LatitudeGMap { get; set; }
        public decimal LongitudeBMap { get; set; }
        public decimal LatitudeBMap { get; set; }
        public System.DateTime DataChange_LastTime { get; set; }
        public System.DateTime DataChange_CreateTime { get; set; }
    }
}
