using pulsee.engine.Utils;

namespace pulsee.engine
{
    class Program
    {
        public static void Main()
        {
            GameContainer.Boot();
            GameContainer.Run();
            GameContainer.Halt();
            xConsole.ReadLine();
        }
    }
}
