using System;
using Alice.Base;
using Alice.Base.Config;

namespace Alice
{
    public class AliceEngine : ITalkable
    {
        public AliceEngine()
        {
            _userConfig = new();
            _systemConfig = new();
            _components = new();
            _components.RegistPreinstalledComponents();
        }

        public AliceEngine(AliceSystemConfig systemConfig) : this()
        { 
            _systemConfig = systemConfig;
        }

        private AliceUserConfig _userConfig;
        private AliceSystemConfig _systemConfig;

        private ComponentManager _components;

        public ITalkable Talk(string text)
        {
            System.Diagnostics.Debug.WriteLine("Input: " + text);
            if (_components.StaticCalls.Keys.Contains(text))
            {
                return _components.StaticCalls[text].Talk(text);
            }

            var regexcheck = _components.RegexCalls.Where(v => System.Text.RegularExpressions.Regex.IsMatch(text, v.Key));
            if (regexcheck.Any())
            {
                return regexcheck.First().Value.Talk(text);
            }

            return new EmptyTalkTicket() { 
                Response = "No Response Available",
                Expired = true,
            };
        }

        public bool Expired { get { return false; } }

        public string? Response { get { return null; } }
    }
}
