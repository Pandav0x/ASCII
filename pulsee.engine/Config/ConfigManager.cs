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

            xConsole.WriteLine("Default config loaded", MessageType.Info);

            xConsole.WriteLine("Loading user config", MessageType.Info);

            string userConfigName = ConfigFileFinder.GetConfigFile();
            IConfigFileFormatStrategy userConfigStrategy = FormatSelector.GetFileFormatStrategyFromFileName(userConfigName);

            configDeserializer.AssingConfigFileFormatStrategy(userConfigStrategy);
            loadedConfig = configDeserializer.LoadConfig(userConfigName);

            xConsole.WriteLine(string.Format("{1} strat used\n{0} loaded", userConfigName, userConfigStrategy.ToString()), MessageType.Info);

            xConsole.WriteLine(string.Format("width:{0}\ntitle:{1}", loadedConfig.Window.Width, loadedConfig.Window.Title));

            return;
        }
    }
}
