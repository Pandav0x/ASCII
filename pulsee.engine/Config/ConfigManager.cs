using pulsee.engine.Config.Contracts;
using pulsee.engine.Config.DTO;
using pulsee.engine.Config.FileFormatStrategies;
using pulsee.engine.Config.Serialization;
using pulsee.engine.Config.Utils;
using pulsee.engine.Utils;

namespace pulsee.engine.Config
{
    class ConfigManager
    {
        public ConfigDTO loadedConfig { get; internal set; }

        private ConfigSerializer configSerializer;

        private ConfigDeserializer configDeserializer;

        public ConfigManager()
        {
            configSerializer = new ConfigSerializer();
            configDeserializer = new ConfigDeserializer();
        }

        public void LoadConfig()
        {
            xConsole.WriteLine("Loading default config", MessageType.Info);

            //loading default config
            configDeserializer.AssingConfigFileFormatStrategy(new JSONFormatStrategy());
            loadedConfig = configDeserializer.LoadConfig(Info.ProjectDirectory + @"Assets\Defaults\default.config.json");

            xConsole.WriteLine("Default config loaded.", MessageType.Info);

            xConsole.WriteLine("Loading user config.", MessageType.Info);

            //loading user config if any
            string userConfigName = ConfigFileFinder.GetConfigFile();

            if (userConfigName == null)
            {
                xConsole.WriteLine("No custom config found.", MessageType.Info);
                return;
            }

            IConfigFileFormatStrategy userConfigStrategy = FormatSelector.GetFileFormatStrategyFromFileName(userConfigName);

            configDeserializer.AssingConfigFileFormatStrategy(userConfigStrategy);
            loadedConfig = configDeserializer.LoadConfig(userConfigName);

            xConsole.WriteLine(string.Format("{0} loaded", userConfigName), MessageType.Info);

            return;
        }
    }
}
