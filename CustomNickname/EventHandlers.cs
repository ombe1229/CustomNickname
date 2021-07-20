using System;
using Exiled.Events.EventArgs;

namespace CustomNickname
{
    public class EventHandlers : IDisposable
    {
        private Plugin _pluginInstance;
        public EventHandlers(Plugin pluginInstance) => _pluginInstance = pluginInstance;

        public void Dispose()
        {
            _pluginInstance = null;
        }

        public void OnJoined(JoinedEventArgs ev)
        {
            if (_pluginInstance.Config.CustomDictionary.ContainsKey(ev.Player.UserId))
            {
                ev.Player.DisplayNickname = _pluginInstance.Config.CustomDictionary[ev.Player.UserId];
            }
        }
    }
}