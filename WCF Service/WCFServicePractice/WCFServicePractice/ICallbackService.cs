using System.Collections.Generic;
using System.ServiceModel;

namespace WCFServicePractice
{
    public interface ICallbackService
    {
        [OperationContract(IsOneWay = true)]
        void GetAllUsersCallback(List<string> users);
        [OperationContract(IsOneWay = true)]
        void SubscribeCallback(string userName);
        [OperationContract(IsOneWay = true)]
        void UnSubscribeCallback(string userName);
    }
}