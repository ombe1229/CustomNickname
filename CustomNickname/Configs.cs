using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;

namespace CustomNickname
{
    public class Configs : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("커스텀 닉네임 설정")]
        public Dictionary<string, string> CustomDictionary { get; private set; } = new Dictionary<string, string>
        {
            
        };
    }
}