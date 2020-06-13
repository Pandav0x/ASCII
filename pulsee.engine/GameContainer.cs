using pulsee.engine.Config;
using pulsee.engine.Events;
using System;

namespace pulsee.engine
{
    static class GameContainer
    {
        public static ConfigManager configManager { get; internal set; }

        public static EventManager eventManager { get; internal set; }

        public static void Boot()
        {
            configManager = new ConfigManager();
            eventManager = new EventManager();

            Initialize();
        }

        public static void Initialize()
        {
            configManager.LoadConfig();
            eventManager.Initialize();
        }

        public static void Run()
        {
            throw new NotImplementedException("ouais nan mais la chui en train de faire autre chose en fait");
        }
    }
}
