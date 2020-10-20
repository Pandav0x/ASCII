using System.Xml;
using Newtonsoft.Json;
using pulsee.engine.Config.Contracts;
using pulsee.engine.Config.DTO;

namespace pulsee.engine.Config.FileFormatStrategies
{
    public class XMLFormatStrategy : FormatStrategy, IConfigFileFormatStrategy
    {
        public ConfigDTO Read(string configName)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(fileReader.GetFileContent(configName));
            string json = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.None, true);

            return JsonConvert.DeserializeObject<ConfigDTO>(json);
        }
    }
}
