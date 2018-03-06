using Kerry.KSYS.Service.Models;
using System.Linq;
using Kerry.KSYS.Data;
using System;
using System.Collections.Generic;
using Kerry.KSYS.Service.Models.Mapper;
using Kerry.KSYS.Service.Constants;
using System.Data.Entity;

namespace Kerry.KSYS.Service.Operation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "JOBLINKsOperation" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select JOBLINKsOperation.svc or JOBLINKsOperation.svc.cs at the Solution Explorer and start debugging.
    public class JOBLINKsOperation : IJOBLINKsOperation,IDisposable
    {
        private KEntities ctx;
        void IDisposable.Dispose()
        {
            ctx.Dispose();
        }

        public JOBLINKsOperation()
        {
            this.ctx = new KEntities();
        }


        public int AddByModel(IQueryable<JOBLINKsModel> models)
        {
            var entities = new List<JOBLINK>();
            var e = new JOBLINK();
            int insertRows = 0;
            foreach (var m in models)
            {
                 m.ToEntity(e);
                entities.Add(e);
            }

            using (var ctx = new KEntities())
            {
                ctx.JOBLINK.AddRange(entities);
                insertRows =  ctx.SaveChanges();
            }
            return insertRows;
        }

        public int Supplyment()
        {
            int impactRows = 0;
            var missJobLinks = new List<JOBLINKsModel>();
            using (var ctx = new KEntities())
            {
                missJobLinks = (from j in ctx.JOB
                                   where j.SUREFNO.Equals(SysConstants.K35_SYSTEM_ID) && string.IsNullOrEmpty(j.VOIDBY) && j.VOIDDATE == null
                                   && j.OWNERID.StartsWith("CN") && (new string[] { "H", "D" }).Contains(j.SHPTYPE) && !string.IsNullOrEmpty(j.BOOKINGNO)
                                   && !string.IsNullOrEmpty(j.JOBNO) && !string.IsNullOrEmpty(j.SHPNO)
                                   //Not exists in Job Link Table before//
                                   && (!ctx.JOBLINK.Any(l => l.SOURCE_UNID == l.JOB_UNID && l.JOB_UNID == j.UNID && l.TYPE.Equals("B")))

                                   && DbFunctions.DiffDays(j.UPDATEDATE??j.CREATEDATE,DateTime.Now)<=150
                                select new JOBLINKsModel
                                   {
                                       Unid = j.UNID,
                                       Type = "B",
                                       SourceUnid = j.UNID
                                   })
                                   .Take(200)
                                   .ToList();

                var entities = new List<JOBLINK>();
                foreach (var m in missJobLinks)
                {
                    var e = new JOBLINK();
                    m.ToEntity(e);
                    entities.Add(e);
                }

                ctx.JOBLINK.AddRange(entities);
                impactRows = ctx.SaveChanges();

            }
 
            
            return impactRows;
        }
    }
}
