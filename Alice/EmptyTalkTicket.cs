using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alice.Base;

namespace Alice
{
    internal class EmptyTalkTicket : ITalkable
    {
        public ITalkable Talk(string text)
        {
            Response = "No Talkable Session";
            Expired = true;
            return this;
        }
        
        public bool Expired { get; internal set; }

        public string? Response { get; internal set; }
    }
}
