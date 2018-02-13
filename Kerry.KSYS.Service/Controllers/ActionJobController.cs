using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
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
    builder.EntitySet<ACTION_JOB>("ActionJob");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class ActionJobController : ODataController
    {
        private KINTFEntities db = new KINTFEntities();

        // GET: odata/ActionJob
        [EnableQuery]
        public IQueryable<ACTION_JOB> GetActionJob()
        {
            return db.ACTION_JOB;
        }

        // GET: odata/ActionJob(5)
        [EnableQuery]
        public SingleResult<ACTION_JOB> GetACTION_JOB([FromODataUri] decimal key)
        {
            return SingleResult.Create(db.ACTION_JOB.Where(aCTION_JOB => aCTION_JOB.UNID == key));
        }

        // PUT: odata/ActionJob(5)
        public IHttpActionResult Put([FromODataUri] decimal key, Delta<ACTION_JOB> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ACTION_JOB aCTION_JOB = db.ACTION_JOB.Find(key);
            if (aCTION_JOB == null)
            {
                return NotFound();
            }

            patch.Put(aCTION_JOB);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ACTION_JOBExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(aCTION_JOB);
        }

        // POST: odata/ActionJob
        public IHttpActionResult Post(ACTION_JOB aCTION_JOB)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ACTION_JOB.Add(aCTION_JOB);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ACTION_JOBExists(aCTION_JOB.UNID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Created(aCTION_JOB);
        }

        // PATCH: odata/ActionJob(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] decimal key, Delta<ACTION_JOB> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ACTION_JOB aCTION_JOB = db.ACTION_JOB.Find(key);
            if (aCTION_JOB == null)
            {
                return NotFound();
            }

            patch.Patch(aCTION_JOB);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ACTION_JOBExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(aCTION_JOB);
        }

        // DELETE: odata/ActionJob(5)
        public IHttpActionResult Delete([FromODataUri] decimal key)
        {
            ACTION_JOB aCTION_JOB = db.ACTION_JOB.Find(key);
            if (aCTION_JOB == null)
            {
                return NotFound();
            }

            db.ACTION_JOB.Remove(aCTION_JOB);
            db.SaveChanges();

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

        private bool ACTION_JOBExists(decimal key)
        {
            return db.ACTION_JOB.Count(e => e.UNID == key) > 0;
        }
    }
}
