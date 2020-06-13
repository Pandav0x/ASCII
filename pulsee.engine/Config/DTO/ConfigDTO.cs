using Newtonsoft.Json;

namespace pulsee.engine.Config.DTO
{
    sealed class ConfigDTO
    {
        public ConfigDTO() { }

        [JsonConstructor]
        public ConfigDTO(
            [JsonProperty("config")] ConfigConfigDTO configConfig = null,
            [JsonProperty("window")] WindowConfigDTO windowConfig = null,
            [JsonProperty("engine")] EngineConfigDTO engineConfig = null
        ) {
            Config = configConfig ?? new ConfigConfigDTO(GameContainer.configManager.loadedConfig.Config);
            Window = windowConfig ?? new WindowConfigDTO(GameContainer.configManager.loadedConfig.Window);
            Engine = engineConfig ?? new EngineConfigDTO(GameContainer.configManager.loadedConfig.Engine);
        }

        private ConfigConfigDTO _config;

        [JsonProperty("config")]
        public ConfigConfigDTO Config
        { 
            get => _config; 
            internal set => _config = value; 
        }

        private WindowConfigDTO _window;

        [JsonProperty("window")]
        public WindowConfigDTO Window
        { 
            get => _window; 
            internal set => _window = value; 
        }

        private EngineConfigDTO _engine;

        [JsonProperty("engine")]
        public EngineConfigDTO Engine
        { 
            get => _engine; 
            internal set => _engine = value; 
        }
    }
}
