using pulsee.engine.Config;
using pulsee.engine.Events;
using pulsee.engine.Game;

namespace pulsee.engine
{
    static class GameContainer
    {
        public static ConfigManager configManager { get; internal set; }

        public static EventManager eventManager { get; internal set; }

        public static MainLoop mainLoop { get; internal set; }

        public static void Boot()
        {
            configManager = new ConfigManager();
            eventManager = new EventManager();

            Initialize();

            mainLoop = new MainLoop();
        }

        public static void Halt()
        {
            Terminate();
        }

        public static void Run()
        {
            mainLoop.Run();
        }

        private static void Initialize()
        {
            configManager.LoadConfig();
            eventManager.Initialize();
        }

        private static void Terminate()
        {
            configManager.Dispose();
            eventManager.Dispose();
        }
    }
}
