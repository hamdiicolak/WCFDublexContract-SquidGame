using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WCFServicePractice
{
    public class Service : IService
    {
        private static List<ICallbackService> ServiceUsers = new List<ICallbackService>();
        private static List<string> Users = new List<string>();
        public ICallbackService Callback
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<ICallbackService>();
            }
        }

        public void GetAllUsers(string userName, string password)
        {
            if(Users.Contains(userName))
            {
                if(password == "squidGame")
                {
                    Callback.GetAllUsersCallback(Users);
                    //ServiceUsers.ForEach(
                    //delegate (ICallbackService callback)
                    //{ callback.GetAllUsersCallback(Users); });
                }
            }
        }

        public void Subscribe(string userName)
        {
            if (!ServiceUsers.Contains(Callback))
            {
                ServiceUsers.Add(Callback);
                Users.Add(userName);

                ServiceUsers.ForEach(
                delegate (ICallbackService callback)
                { callback.SubscribeCallback(userName); });
            }
        }

        public void UnSubscribe(string userName)
        {
            if (ServiceUsers.Contains(Callback))
            {
                ServiceUsers.Remove(Callback);
                Users.Remove(userName);

                ServiceUsers.ForEach(
                delegate (ICallbackService callback)
                { callback.UnSubscribeCallback(userName); });
            }
        }
    }
}
