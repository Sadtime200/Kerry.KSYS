using Kerry.KSYS.Data;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.OData;

namespace Kerry.KSYS.Service.Controllers
{
    /*
    在为此控制器添加路由之前，WebApiConfig 类可能要求你做出其他更改。请适当地将这些语句合并到 WebApiConfig 类的 Register 方法中。请注意 OData URL 区分大小写。

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using Kerry.KSYS.Data;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<JOBOTHER>("JOBOTHERs");
    builder.EntitySet<JOB>("JOB"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class JOBOTHERsController : ODataController
    {
        private KEntities db = new KEntities();

        // GET: odata/JOBOTHERs
        [EnableQuery]
        public IQueryable<JOBOTHER> GetJOBOTHERs()
        {
            return db.JOBOTHER;
        }

        // GET: odata/JOBOTHERs(5)
        [EnableQuery]
        public SingleResult<JOBOTHER> GetJOBOTHER([FromODataUri] long key)
        {
            return SingleResult.Create(db.JOBOTHER.Where(jOBOTHER => jOBOTHER.JOB_UNID == key));
        }

        // PUT: odata/JOBOTHERs(5)
        public IHttpActionResult Put([FromODataUri] long key, Delta<JOBOTHER> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            JOBOTHER jOBOTHER = db.JOBOTHER.Find(key);
            if (jOBOTHER == null)
            {
                return NotFound();
            }

            patch.Put(jOBOTHER);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JOBOTHERExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(jOBOTHER);
        }

        // POST: odata/JOBOTHERs
        public IHttpActionResult Post(JOBOTHER jOBOTHER)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.JOBOTHER.Add(jOBOTHER);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (JOBOTHERExists(jOBOTHER.JOB_UNID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Created(jOBOTHER);
        }

        // PATCH: odata/JOBOTHERs(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] long key, Delta<JOBOTHER> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            JOBOTHER jOBOTHER = db.JOBOTHER.Find(key);
            if (jOBOTHER == null)
            {
                return NotFound();
            }

            patch.Patch(jOBOTHER);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JOBOTHERExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(jOBOTHER);
        }

        // DELETE: odata/JOBOTHERs(5)
        public IHttpActionResult Delete([FromODataUri] long key)
        {
            JOBOTHER jOBOTHER = db.JOBOTHER.Find(key);
            if (jOBOTHER == null)
            {
                return NotFound();
            }

            db.JOBOTHER.Remove(jOBOTHER);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/JOBOTHERs(5)/JOB
        [EnableQuery]
        public SingleResult<JOB> GetJOB([FromODataUri] long key)
        {
            return SingleResult.Create(db.JOBOTHER.Where(m => m.JOB_UNID == key).Select(m => m.JOB));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool JOBOTHERExists(long key)
        {
            return db.JOBOTHER.Count(e => e.JOB_UNID == key) > 0;
        }
    }
}
