﻿using pulsee.engine.Utils;

using System;
using System.Diagnostics;
using System.Threading;

namespace pulsee.engine.Game
{
    class MainLoop
    {
        private bool isLooping;

        private readonly int msPerUpdate;

        private readonly int maxFPS;

        public bool IsLooping
        {
            get { return isLooping; }
            set { isLooping = value; }
        }

        public MainLoop()
        {
            IsLooping = true;
            msPerUpdate = (int)GameContainer.configManager.loadedConfig.Engine.MsPerUpdate;
            maxFPS = (int)GameContainer.configManager.loadedConfig.Engine.MaxFPS;
        }

        public void Run()
        {
            double previous = Time.GetEpochMilliseconds();

            double updateLag = 0.0d;

            do
            {
                double current = Time.GetEpochMilliseconds();
                double elapsed = current - previous;

                previous = current;
                updateLag += elapsed;

                ProcessInput();

                while (updateLag >= msPerUpdate)
                {
                    Update();
                    updateLag -= msPerUpdate;
                }

                Render(); //TODO - clamp Render to MAX_FPS in config

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
            //TODO - just a dummy method for a reference in main loop
        }
    }
}
