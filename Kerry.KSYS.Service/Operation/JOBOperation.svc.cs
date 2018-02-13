using Kerry.KSYS.Data;
using Kerry.KSYS.Service.Constants;
using System;
using System.Data.Entity;
using System.Linq;

namespace Kerry.KSYS.Service.Operation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "JOBOperation" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select JOBOperation.svc or JOBOperation.svc.cs at the Solution Explorer and start debugging.
    public class JOBOperation : IJOBOperation,IDisposable
    {
        private KEntities ctx;
        void IDisposable.Dispose()
        {
            ctx.Dispose();
        }

        public JOBOperation()
        {
            this.ctx = new KEntities();
        }

        public int AddCONSOLUNID()
        {
        
            //Logger.Write();
            int impactRows = 0;
            using (var ctx = new KEntities())
            {
                var query = (from j in ctx.JOB
                             where j.SUREFNO.Contains(SysConstants.K35_SYSTEM_ID) && j.OWNERID.StartsWith("CN")
                             && string.IsNullOrEmpty(j.VOIDBY) && j.SHPTYPE.Equals("H")
                             && !string.IsNullOrEmpty(j.SHPNO) && !string.IsNullOrEmpty(j.CONSOLNO) && j.CONSOLLOT_UNID == null
                             &&ctx.JOB.Any(m=>m.SHPNO==j.CONSOLNO&&m.OWNERID.Equals(j.OWNERID)&&m.BIZTYPE.Equals(j.BIZTYPE)
                             &&string.IsNullOrEmpty(m.VOIDBY))

                             && DbFunctions.DiffDays(j.UPDATEDATE ?? j.CREATEDATE, DateTime.Now) <= 1
                             select j).ToList().Take(200);

                foreach (var q in query)
                {
                    var consol = ctx.JOB.Where(j => j.SHPNO.Equals(q.CONSOLNO) && j.OWNERID == q.OWNERID && j.VOIDBY == null & j.VOIDDATE == null)
                                        .ToList().FirstOrDefault();
                    if (consol != null)
                    {
                        q.CONSOLLOT_UNID = consol.UNID;
                        ctx.Entry<JOB>(q).State = System.Data.Entity.EntityState.Modified;
                    }

                }
                impactRows = ctx.SaveChanges();
            }

            return impactRows;
        }

        public int UpdateCONSOLUNID()
        {
            int impactRows = 0;
            try
            {

            
            using (var ctx = new KEntities())
            {
                    var query = (from j in ctx.JOB
                                 where j.SUREFNO.Contains(SysConstants.K35_SYSTEM_ID) && j.OWNERID.StartsWith("CN")
                                  && string.IsNullOrEmpty(j.VOIDBY) && j.SHPTYPE.Equals("H")
                                  && !string.IsNullOrEmpty(j.CONSOLNO) && j.CONSOLLOT_UNID != null                 
                                  &&ctx.JOB
                                    .Any(m=>m.UNID==j.CONSOLLOT_UNID&&!m.SHPNO.Equals(j.CONSOLNO)
                                        &&string.IsNullOrEmpty(m.VOIDBY)&&m.OWNERID.Equals(j.OWNERID)
                                        &&m.BIZTYPE.Equals(j.BIZTYPE))
                                 //&&ctx.JOB.Any(m=>m.SHPNO.Equals(j.CONSOLNO)&&m.OWNERID.Equals(j.OWNERID)&&m.UNID!=j.CONSOLLOT_UNID&&string.IsNullOrEmpty(m.VOIDBY))
                                 && DbFunctions.DiffDays(j.UPDATEDATE ?? j.CREATEDATE, DateTime.Now) <= 1
                                 select j)
                                 .ToList()
                                 .Take(200)
                                 ;

                    foreach (var q in query)
                {
                        if (!string.IsNullOrEmpty(q.CONSOLNO))
                        {
                            var consol = ctx.JOB.Where(m => m.SHPTYPE.Equals("M") && m.OWNERID.Equals(q.OWNERID) && m.BIZTYPE.Equals(q.BIZTYPE)
                                        && string.IsNullOrEmpty(m.VOIDBY) && m.SHPNO.Equals(q.CONSOLNO)).ToList().FirstOrDefault();
                            if (consol != null)
                            {
                                q.CONSOLLOT_UNID = consol.UNID;
                            }
                            else
                            {
                                q.CONSOLLOT_UNID = null;
                            }
                        }
                        else
                        {
                            q.CONSOLLOT_UNID = null;
                        }

                    
                        ctx.Entry<JOB>(q).State = System.Data.Entity.EntityState.Modified;
                    }
                    impactRows = ctx.SaveChanges();
            }
            }
            catch (System.ArgumentOutOfRangeException ex)
            {

                throw(ex);
            }

            return impactRows;
        }

        public int RemoveCONSOLUNID()
        {
            int impactRows = 0;
            try
            {
                using (var ctx = new KEntities())
                {
                    var query = (from j in ctx.JOB
                                 where j.SUREFNO.Contains(SysConstants.K35_SYSTEM_ID) && j.OWNERID.StartsWith("CN")
                                  && string.IsNullOrEmpty(j.VOIDBY) && j.SHPTYPE.Equals("H")
                                  && string.IsNullOrEmpty(j.CONSOLNO) && j.CONSOLLOT_UNID != null

                                  && DbFunctions.DiffDays(j.UPDATEDATE ?? j.CREATEDATE, DateTime.Now) <= 1
                                 select j)
                                 .Take(200)
                                 .ToList()
                                 ;

                    query.ForEach(q=> {
                        q.CONSOLLOT_UNID = null;
                        ctx.Entry<JOB>(q).State = System.Data.Entity.EntityState.Modified;
                    });

                    impactRows = ctx.SaveChanges();
                }
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                throw (ex);
            }

            return impactRows;
        }
    }
}
