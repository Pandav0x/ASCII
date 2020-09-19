using Newtonsoft.Json;
using pulsee.engine.Utils;

namespace pulsee.engine.Config.DTO
{
    class EngineConfigDTO
    {
        public EngineConfigDTO() { }

        [JsonConstructor]
        public EngineConfigDTO(
            [JsonProperty("physic_tick")] float? physicRefreshRate_ = null,
            [JsonProperty("graphic_tick")] float? graphicRefreshRate_ = null,
            [JsonProperty("clock_speed")] float? clockSpeed_ = null
        ) {
            PhysicRefreshRate = physicRefreshRate_ ?? GameContainer.configManager.loadedConfig.Engine.PhysicRefreshRate;
            GraphicRefreshRate = graphicRefreshRate_ ?? GameContainer.configManager.loadedConfig.Engine.GraphicRefreshRate;
            ClockSpeed = clockSpeed_ ?? GameContainer.configManager.loadedConfig.Engine.ClockSpeed;            
        }

        public EngineConfigDTO(EngineConfigDTO engineConfig)
        {
            PhysicRefreshRate = engineConfig.PhysicRefreshRate;
            GraphicRefreshRate = engineConfig.GraphicRefreshRate;
            ClockSpeed = engineConfig.ClockSpeed;
        }

        private float? _physicRefreshRate;

        [JsonProperty("physic_tick")]
        public float? PhysicRefreshRate 
        {
            get => _physicRefreshRate;
            internal set => _physicRefreshRate = value;
        }

        private float? _graphicRefreshRate;

        [JsonProperty("graphic_tick")]
        public float? GraphicRefreshRate 
        {
            get => _graphicRefreshRate;
            internal set => _graphicRefreshRate = value;
        }

        private float? _clockSpeed;

        [JsonProperty("clock_speed")]
        public float? ClockSpeed 
        {
            get => _clockSpeed;
            internal set => _clockSpeed = value;
        }
    }
