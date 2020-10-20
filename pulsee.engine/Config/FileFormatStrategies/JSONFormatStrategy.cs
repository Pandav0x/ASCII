using Newtonsoft.Json;
using pulsee.engine.Config.Contracts;
using pulsee.engine.Config.DTO;
using pulsee.engine.IO.File;

namespace pulsee.engine.Config.FileFormatStrategies
{
    class JSONFormatStrategy : IConfigFileFormatStrategy
    {
        public ConfigDTO Read(string configName)
        {
            return JsonConvert.DeserializeObject<ConfigDTO>((new FileReader()).GetFileContent(configName));
        }
    }
}
