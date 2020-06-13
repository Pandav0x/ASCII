using pulsee.engine.Config.DTO;

namespace pulsee.engine.Config.Serialization
{
    class ConfigDeserializer: ConfigFileFormatContext
    {
        public ConfigDeserializer()
        {
            return;
        }
        
        public ConfigDTO LoadConfig(string configFileName)
        {
            return configFileFormatStrategy.Read(configFileName);
        }

    }
}
