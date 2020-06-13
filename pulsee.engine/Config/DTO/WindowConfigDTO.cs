using Newtonsoft.Json;
using pulsee.engine.Utils;

namespace pulsee.engine.Config.DTO
{
    class WindowConfigDTO
    {
        public WindowConfigDTO() { }

        [JsonConstructor]
        public WindowConfigDTO(
            [JsonProperty("height")] int? height_ = null,
            [JsonProperty("width")] int? width_ = null,
            [JsonProperty("title")] string title_ = null
        ) {
            Height = height_ ?? GameContainer.configManager.loadedConfig.Window.Height;
            Width = width_ ?? GameContainer.configManager.loadedConfig.Window.Width;
            Title = title_ ?? GameContainer.configManager.loadedConfig.Window.Title;
        }

        public WindowConfigDTO(WindowConfigDTO windowConfig)
        {
            Height = windowConfig.Height;
            Width = windowConfig.Width;
            Title = windowConfig.Title;
        }

        private int? _height;

        [JsonProperty("height")]
        public int? Height
        {
            get => _height;
            internal set => _height = value;
        }

        private int? _width;

        [JsonProperty("width")]
        public int? Width 
        {
            get => _width;
            internal set => _width = value;
        }

        private string _title;

        [JsonProperty("title")]
        public string Title 
        {
            get => _title;
            internal set => _title = value;
        }
    }
}
