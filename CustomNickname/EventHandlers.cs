using System;

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
    }
}