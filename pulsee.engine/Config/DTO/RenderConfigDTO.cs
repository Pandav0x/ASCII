using Newtonsoft.Json;

namespace pulsee.engine.Config.DTO
{
    class RenderConfigDTO
    {
        public RenderConfigDTO() { }

        [JsonConstructor]
        public RenderConfigDTO(
            [JsonProperty("max_fps")] float? maxFPS_ = null
        )
        {
            MaxFPS = maxFPS_ ?? GameContainer.configManager.loadedConfig.Render.MaxFPS;
        }

        public RenderConfigDTO(RenderConfigDTO renderConfig)
        {
            MaxFPS = renderConfig.MaxFPS;
        }

        private float? maxFPS;

        [JsonProperty("max_fps")]
        public float? MaxFPS
        {
            get { return maxFPS; }
            set { maxFPS = value; }
        }

    }
}
