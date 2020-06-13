using pulsee.engine.Config.Contracts;

namespace pulsee.engine.Config.Serialization
{
    abstract class ConfigFileFormatContext
    {
        protected IConfigFileFormatStrategy configFileFormatStrategy { get; private set; }

        public ConfigFileFormatContext()
        {
            return;
        }

        public void AssingConfigFileFormatStrategy(IConfigFileFormatStrategy configFileFormatStrategy_)
        {
            configFileFormatStrategy = configFileFormatStrategy_;
        }
    }
}
