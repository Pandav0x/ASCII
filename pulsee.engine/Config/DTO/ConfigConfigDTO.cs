using Newtonsoft.Json;

namespace pulsee.engine.Config.DTO
{
    public class ConfigConfigDTO
    {
        public ConfigConfigDTO() { }

        [JsonConstructor]
        public ConfigConfigDTO(
            [JsonProperty("ext_priority")] string[] extensionsPriority_ = null
        ) {
            ExtensionsPriority = extensionsPriority_ ?? GameContainer.configManager.loadedConfig.Config.ExtensionsPriority;
        }

        public ConfigConfigDTO(ConfigConfigDTO configConfig)
        {
            ExtensionsPriority = configConfig.ExtensionsPriority;
        }

        private string[] _extensionsPriority;

        [JsonProperty("ext_priority")]
        public string[] ExtensionsPriority 
        {
            get => _extensionsPriority;
            internal set => _extensionsPriority = value; 
        }
    }
}
