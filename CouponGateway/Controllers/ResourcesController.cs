using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CouponModel;
using CouponModel.DTO;

namespace CouponGateway.Controllers
{
    public class ResourcesController : ApiController
    {
        private CouponDBEntities db = new CouponDBEntities();

        // GET: api/Resources
        //public IQueryable<ResourceDTO> GetResources()
        //{

        //    var res = from b in db.Resources
        //              select new ResourceDTO()
        //                {
        //                    ResourceID = b.ResourceID,
        //                    TypeID = b.TypeID,
        //                    Name = b.ShowName,
        //                    Amount = b.SalePrice,
        //                    CurrencyID = b.SalePriceCurrencyID
        //                };

        //    return res;

        //    //return db.Resources;
        //}

        //GET: api/RelationResources
        //public IEnumerable<ResourceCurrDTO> GetRelationResources()
        //{
        //    string sql = "select a.[ResourceID],a.[TypeID],a.[Name],a.[Amount],b.[CurrencyName] " +
        //                 "from [dbo].[Resource] a with (nolock) inner join [dbo].[ResourceCurrency] b with (nolock) " +
        //                 "on a.[CurrencyID]=b.[CurrencyID]";
        //    //var args = new DbParameter[] {
        //    //      new SqlParameter {ParameterName = "Major", Value = "Masters"}};

        //    var responexxl = db.Database.SqlQuery<ResourceCurrDTO>(sql);


        //    var res = from b in responexxl
        //              select new ResourceCurrDTO()
        //              {
        //                  ResourceID = b.ResourceID,
        //                  TypeID = b.TypeID,
        //                  Name = b.Name,
        //                  Amount = b.Amount,
        //                  CurrencyName = b.CurrencyName
        //              };

        //    return res;
           
        //}

        //// GET: api/Resources/5
        //[ResponseType(typeof(Resource))]
        //public IHttpActionResult GetResource(int id)
        //{
        //    Resource resource = db.Resources.Find(id);
        //    if (resource == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(resource);
        //}

        //// PUT: api/Resources/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutResource(int id, Resource resource)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != resource.ResourceID)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(resource).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ResourceExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Resources
        //[ResponseType(typeof(Resource))]
        //public IHttpActionResult PostResource(Resource resource)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Resources.Add(resource);
        //    db.SaveChanges();

        //    //return CreatedAtRoute("DefaultApi", new { id = resource.ResourceID }, resource);
        //    return StatusCode(HttpStatusCode.OK);
        //}

        //// DELETE: api/Resources/5
        //[ResponseType(typeof(Resource))]
        //public IHttpActionResult DeleteResource(int id)
        //{
        //    Resource resource = db.Resources.Find(id);
        //    if (resource == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Resources.Remove(resource);
        //    db.SaveChanges();

        //    return Ok(resource);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool ResourceExists(int id)
        //{
        //    return db.Resources.Count(e => e.ResourceID == id) > 0;
        //}
    }
}