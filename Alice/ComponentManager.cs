using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alice.Base;

namespace Alice
{
    internal class ComponentManager
    {
        internal Dictionary<string, IAliceComponent> StaticCalls = new Dictionary<string, IAliceComponent>();
        internal Dictionary<string, IAliceComponent> RegexCalls = new Dictionary<string,IAliceComponent>();

        internal void RegistPreinstalledComponents()
        {
            foreach (IAliceComponent ac in new IAliceComponent[] {
                new Component.Time.Time()
            })
            {
                foreach (string sc in ac.StaticCalls)
                { 
                    StaticCalls.Add(sc, ac);
                }

                foreach (string rc in ac.RegexCalls)
                { 
                    RegexCalls.Add(rc, ac);
                }
            }
        }
    }
}
