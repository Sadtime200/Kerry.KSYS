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

namespace Kerry.KSYS.Service.Controllers
{
    /*
    在为此控制器添加路由之前，WebApiConfig 类可能要求你做出其他更改。请适当地将这些语句合并到 WebApiConfig 类的 Register 方法中。请注意 OData URL 区分大小写。

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using Kerry.KSYS.Data;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<JOB>("JOBs");
    builder.EntitySet<JOBOTHER>("JOBOTHER"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class JOBsController : ODataController
    {
        private KEntities db = new KEntities();

        // GET: odata/JOBs
        [EnableQuery]
        public IQueryable<JOB> GetJOBs()
        {
            return db.JOB;
        }

        // GET: odata/JOBs(5)
        [EnableQuery]
        public SingleResult<JOB> GetJOB([FromODataUri] long key)
        {
            return SingleResult.Create(db.JOB.Where(jOB => jOB.UNID == key));
        }

        // PUT: odata/JOBs(5)
        public async Task<IHttpActionResult> Put([FromODataUri] long key, Delta<JOB> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            JOB jOB = await db.JOB.FindAsync(key);
            if (jOB == null)
            {
                return NotFound();
            }

            patch.Put(jOB);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JOBExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(jOB);
        }

        // POST: odata/JOBs
        public async Task<IHttpActionResult> Post(JOB jOB)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.JOB.Add(jOB);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JOBExists(jOB.UNID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Created(jOB);
        }

        // PATCH: odata/JOBs(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] long key, Delta<JOB> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            JOB jOB = await db.JOB.FindAsync(key);
            if (jOB == null)
            {
                return NotFound();
            }

            patch.Patch(jOB);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JOBExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(jOB);
        }

        // DELETE: odata/JOBs(5)
        public async Task<IHttpActionResult> Delete([FromODataUri] long key)
        {
            JOB jOB = await db.JOB.FindAsync(key);
            if (jOB == null)
            {
                return NotFound();
            }

            db.JOB.Remove(jOB);
            await db.SaveChangesAsync();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/JOBs(5)/JOBOTHER
        [EnableQuery]
        public SingleResult<JOBOTHER> GetJOBOTHER([FromODataUri] long key)
        {
            return SingleResult.Create(db.JOB.Where(m => m.UNID == key).Select(m => m.JOBOTHER));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool JOBExists(long key)
        {
            return db.JOB.Count(e => e.UNID == key) > 0;
        }
    }
}
