using Alice.Base;

namespace Alice.Component.Time
{
    public class Time : IAliceComponent
    {
        public string[] StaticCalls => new string[] { 
            "今の時刻"
        };

        public string[] RegexCalls => new string[] { };

        public bool Expired => true;

        public string? Response => $"{DateTime.Now.ToLocalTime().ToLongTimeString()} です。";

        public ITalkable Talk(string text)
        {
            return this;
        }
    }
}