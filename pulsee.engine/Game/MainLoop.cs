using System;
using pulsee.engine.Utils;

namespace pulsee.engine.Game
{
    class MainLoop
    {
        private bool isLooping;

        public bool IsLooping
        {
            get { return isLooping; }
            set { isLooping = value; }
        }

        public MainLoop() 
        {
            isLooping = true;
        }

        public void Run()
        {
            do
            {

                xConsole.WriteLine("Nothing in the main loop yet !", MessageType.Error);
                isLooping = false;
            } while (isLooping);
            return;
        }
    }
}
