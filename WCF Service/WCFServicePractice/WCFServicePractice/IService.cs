using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServicePractice
{
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(ICallbackService))]
    public interface IService
    {
        [OperationContract(IsOneWay = true)]
        void GetAllUsers(string userName, string password);
        [OperationContract(IsOneWay = true)]
        void Subscribe(string userName);
        [OperationContract(IsOneWay = true)]
        void UnSubscribe(string userName);
    }
}
