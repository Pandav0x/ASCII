using Newtonsoft.Json;
using pulsee.engine.Utils;

namespace pulsee.engine.Config.DTO
{
    public class EngineConfigDTO
    {
        public EngineConfigDTO() { }

        [JsonConstructor]
        public EngineConfigDTO(
            [JsonProperty("ms_per_update")] int? msPerUpdate_ = null,
            [JsonProperty("max_fps")] int? maxFPS_ = null
        )
        {
            MsPerUpdate = msPerUpdate_ ?? GameContainer.configManager.loadedConfig.Engine.MsPerUpdate;
            MaxFPS = maxFPS_ ?? GameContainer.configManager.loadedConfig.Engine.MaxFPS;
        }

        public EngineConfigDTO(EngineConfigDTO engineConfig)
        {
            MsPerUpdate = engineConfig.MsPerUpdate;
            MaxFPS = engineConfig.MaxFPS;
        }

        private int? _msPerUpdate;

        [JsonProperty("ms_per_update")]
        public int? MsPerUpdate
        {
            get => _msPerUpdate;
            internal set => _msPerUpdate = value;
        }

        private float? _maxFPS;

        [JsonProperty("max_fps")]
        public float? MaxFPS
        {
            get => _maxFPS;
            internal set => _maxFPS = value;
        }
    }
}
