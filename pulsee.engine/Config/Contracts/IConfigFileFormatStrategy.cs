using pulsee.engine.Config.DTO;

namespace pulsee.engine.Config.Contracts
{
    interface IConfigFileFormatStrategy
    {
        ConfigDTO Read(string configName);
    }
}
