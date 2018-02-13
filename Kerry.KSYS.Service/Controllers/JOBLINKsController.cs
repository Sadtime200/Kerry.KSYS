using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using Kerry.KSYS.Data;
using Kerry.KSYS.Service.Constants;
using Kerry.KSYS.Service.Models;


namespace Kerry.KSYS.Service.Controllers
{
    /*
    在为此控制器添加路由之前，WebApiConfig 类可能要求你做出其他更改。请适当地将这些语句合并到 WebApiConfig 类的 Register 方法中。请注意 OData URL 区分大小写。

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using Kerry.KSYS.Data;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<JOBLINK>("JOBLINKs");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class JOBLINKsController : ODataController
    {
        private KEntities db = new KEntities();

        // GET: odata/JOBLINKs
        [EnableQuery]
        public IQueryable<JOBLINKsModel> GetJOBLINKs()
        {
            var missJobLinks = from j in db.JOB
                                   //join l in db.JOBLINK.DefaultIfEmpty() on j.UNID equals l.JOB_UNID

                               where j.SUREFNO.Equals(SysConstants.K35_SYSTEM_ID) && string.IsNullOrEmpty(j.VOIDBY) && j.VOIDDATE == null
                               && j.OWNERID.StartsWith("CN") && (new string[] { "H", "D" }).Contains(j.SHPTYPE) && !string.IsNullOrEmpty(j.BOOKINGNO)
                               && !string.IsNullOrEmpty(j.JOBNO) && !string.IsNullOrEmpty(j.SHPNO)
                               //Not exists in Job Link Table before//
                               && (!db.JOBLINK.Any(l => l.SOURCE_UNID == l.JOB_UNID && l.JOB_UNID == j.UNID && l.TYPE.Equals("B")))
                                  select new JOBLINKsModel
                                  {
                                   SourceUnid = j.UNID,
                                   Type = "B",
                                   Unid = j.UNID
                               };
            return missJobLinks;

        }

        // GET: odata/JOBLINKs(5)
        [EnableQuery]
        public SingleResult<JOBLINK> GetJOBLINK([FromODataUri] long key)
        {
            return SingleResult.Create(db.JOBLINK.Where(jOBLINK => jOBLINK.SOURCE_UNID == key));
        }

        // PUT: odata/JOBLINKs(5)
        public async Task<IHttpActionResult> Put([FromODataUri] long key, Delta<JOBLINK> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            JOBLINK jOBLINK = await db.JOBLINK.FindAsync(key);
            if (jOBLINK == null)
            {
                return NotFound();
            }

            patch.Put(jOBLINK);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JOBLINKExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(jOBLINK);
        }

        // POST: odata/JOBLINKs
        public async Task<IHttpActionResult> Post(JOBLINK jOBLINK)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.JOBLINK.Add(jOBLINK);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JOBLINKExists(jOBLINK.SOURCE_UNID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Created(jOBLINK);
        }

        // PATCH: odata/JOBLINKs(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] long key, Delta<JOBLINK> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            JOBLINK jOBLINK = await db.JOBLINK.FindAsync(key);
            if (jOBLINK == null)
            {
                return NotFound();
            }

            patch.Patch(jOBLINK);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JOBLINKExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(jOBLINK);
        }

        // DELETE: odata/JOBLINKs(5)
        public async Task<IHttpActionResult> Delete([FromODataUri] long key)
        {
            JOBLINK jOBLINK = await db.JOBLINK.FindAsync(key);
            if (jOBLINK == null)
            {
                return NotFound();
            }

            db.JOBLINK.Remove(jOBLINK);
            await db.SaveChangesAsync();

            return StatusCode(HttpStatusCode.NoContent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool JOBLINKExists(long key)
        {
            return db.JOBLINK.Count(e => e.SOURCE_UNID == key) > 0;
        }
    }
}
