using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice.Base
{
    public interface IAliceComponent : ITalkable
    {
        public string[] StaticCalls { get; }

        public string[] RegexCalls { get; }
    }
}
