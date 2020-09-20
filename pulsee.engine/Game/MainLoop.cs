using pulsee.engine.Utils;

using System;
using System.Diagnostics;
using System.Threading;

namespace pulsee.engine.Game
{
    class MainLoop
    {
        private bool isLooping;

        const int MS_PER_UPDATE = 20;

        public bool IsLooping
        {
            get { return isLooping; }
            set { isLooping = value; }
        }

        public MainLoop()
        {
            IsLooping = true;
        }

        public void Run()
        {
            double previous = Time.GetEpochMilliseconds();

            double lag = 0.0d;

            do
            {
                double current = Time.GetEpochMilliseconds();
                double elapsed = current - previous;

                previous = current;
                lag += elapsed;

                ProcessInput();

                while (lag >= MS_PER_UPDATE)
                {
                    Update();
                    lag -= MS_PER_UPDATE;
                }

                Render();

            } while (isLooping);
            return;
        }

        public void ProcessInput() 
        {
            //TODO - just a dummy method for a reference in main loop
        }

        public void Update() 
        {
            xConsole.Write(".", MessageType.Error);
            //TODO - just a dummy method for a reference in main loop
        }

        public void Render() 
        {
            xConsole.Write(".", MessageType.Warning);
            Thread.Sleep(120);
            //TODO - just a dummy method for a reference in main loop
        }
    }
}
