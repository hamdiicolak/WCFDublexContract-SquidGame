using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace JangDeok_su
{   
    static class GlobalVariables
    {
        public static MainWindow MainWindow { get; set; }
        public static SquidGameRef.ServiceClient Gamer = new SquidGameRef.ServiceClient(new InstanceContext(new CallbackHandler()));
    }
}
