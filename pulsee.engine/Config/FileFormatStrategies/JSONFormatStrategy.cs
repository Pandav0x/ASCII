using Newtonsoft.Json;
using pulsee.engine.Config.Contracts;
using pulsee.engine.Config.DTO;

namespace pulsee.engine.Config.FileFormatStrategies
{
    public class JSONFormatStrategy : FormatStrategy, IConfigFileFormatStrategy
    {
        public ConfigDTO Read(string configName)
        {
            return JsonConvert.DeserializeObject<ConfigDTO>(fileReader.GetFileContent(configName));
        }
    }
}
