using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Principal.WinApp
{
    public class AppCore
    {
        public static UnityContainer Container { get; set; }

        public static void Start()
        {
            Container = new UnityContainer();
            IOC.Register.RegisterObjectInContainer(Container);

        }
    }
}
