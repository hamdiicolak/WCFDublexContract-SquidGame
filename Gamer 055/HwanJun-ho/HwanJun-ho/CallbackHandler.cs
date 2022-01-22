using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HwanJun_ho.SquidGameRef;

namespace HwanJun_ho
{
    public partial class CallbackHandler : IServiceCallback
    {
        public void GetAllUsersCallback(string[] users)
        {
            GlobalVariables.MainWindow.DataView.Text += "Oyuncu Listesi : " + Environment.NewLine;
            foreach (var user in users)
            {
                GlobalVariables.MainWindow.DataView.Text += user + Environment.NewLine;
            }
        }

        public void SubscribeCallback(string userName)
        {
            GlobalVariables.MainWindow.DataView.Text += "Oyuncu " + userName + " katıldı." + Environment.NewLine;
        }

        public void UnSubscribeCallback(string userName)
        {
            GlobalVariables.MainWindow.DataView.Text += "Oyuncu " + userName + " elendi..." + Environment.NewLine;
        }
    }
}
