using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice.Base
{
    public interface ITalkable
    {
        /// <summary>
        /// Send message to Alice Engine
        /// </summary>
        /// <param name="text">Message for alice engine</param>
        public ITalkable Talk(string text);
     
        /// <summary>
        /// When expired (=Talk has been ended) it will be true
        /// </summary>
        public bool Expired { get; }

        /// <summary>
        /// Response for last message
        /// </summary>
        public string? Response { get; }
    }
}
