namespace CoreWCFService
{
    using CoreWCF;
    using System;
    using System.Runtime.Serialization;

    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
    }
}
