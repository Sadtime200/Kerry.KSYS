using Kerry.KSYS.Service.Models;
using System.Linq;
using System.ServiceModel;

namespace Kerry.KSYS.Service.Operation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IJOBLINKsOperation" in both code and config file together.
    [ServiceContract]
    public interface IJOBLINKsOperation
    {
        [OperationContract]
        int AddByModel(IQueryable<JOBLINKsModel> models);

        /// <summary>
        /// Patch missed job link
        /// </summary>
        /// <returns>impact row count</returns>
        [OperationContract]
        int Supplyment();
    }
}
