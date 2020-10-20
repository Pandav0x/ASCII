using pulsee.engine.Config.DTO;

namespace pulsee.engine.Config.Contracts
{
    public interface IConfigFileFormatStrategy
    {
        ConfigDTO Read(string configName);
    }
}
