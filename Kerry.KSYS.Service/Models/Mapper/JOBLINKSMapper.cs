using Kerry.KSYS.Data;


namespace Kerry.KSYS.Service.Models.Mapper
{
    public static class JOBLINKSMapper
    {

        public static JOBLINK ToEntity(this JOBLINKsModel model,JOBLINK entity)
        {
            entity.JOB_UNID = model.Unid;
            entity.SOURCE_UNID = model.SourceUnid;
            entity.TYPE = model.Type;
            return entity;

        }

        public static JOBLINKsModel ToModel(this JOBLINK entity, JOBLINKsModel model)
        {
            model.Unid = entity.JOB_UNID;
            model.Type = entity.TYPE;
            model.SourceUnid = entity.SOURCE_UNID;
            return model;
        }

    }
}