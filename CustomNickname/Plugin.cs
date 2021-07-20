using Exiled.API.Enums;
using Features = Exiled.API.Features;
using Log = Exiled.API.Features.Log;
using PlayerEvents = Exiled.Events.Handlers.Player;

namespace CustomNickname
{
    public class Plugin : Features.Plugin<Configs>
    {
        public EventHandlers EventHandlers { get; private set; }
        public override string Name { get; } = "CustomNickname";
        public override string Prefix { get; } = "CustomNickname";
        public override string Author { get; } = "ombe1229";
        public override PluginPriority Priority { get; } = PluginPriority.Default;

        private void LoadEvents()
        {
            PlayerEvents.Joined += EventHandlers.OnJoined;
        }

        public override void OnEnabled()
        {
            if (!Config.IsEnabled) return;
            base.OnEnabled();
            EventHandlers = new EventHandlers(this);
            LoadEvents();
            Log.Info("커스텀 닉네임 플러그인 활성화");
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            EventHandlers = null;
        }

        public override void OnReloaded()
        {
            PlayerEvents.Joined -= EventHandlers.OnJoined;
        }
    }
}