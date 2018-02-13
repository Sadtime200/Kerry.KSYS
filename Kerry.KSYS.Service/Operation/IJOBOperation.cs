using System.ServiceModel;

namespace Kerry.KSYS.Service.Operation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IJOBOperation" in both code and config file together.
    [ServiceContract]
    public interface IJOBOperation
    {
        /// <summary>
        ///  House was imported earilier than Master & House consollot_uind will remain null after Master imported to K system.
        /// </summary>
        /// <returns>impact row count</returns>
        [OperationContract]
        int AddCONSOLUNID();
        /// <summary>
        /// For cosol job detach HBL.or detach & reatch HBL scenario.
        /// </summary>
        /// <returns>impact row count</returns>
        [OperationContract]
        int UpdateCONSOLUNID();

        [OperationContract]
        int RemoveCONSOLUNID();
    }
}
