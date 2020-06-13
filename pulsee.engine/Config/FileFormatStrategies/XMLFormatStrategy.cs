﻿using System.Xml;
using Newtonsoft.Json;
using pulsee.engine.Config.Contracts;
using pulsee.engine.Config.DTO;
using pulsee.engine.Utils;

namespace pulsee.engine.Config.FileFormatStrategies
{
    class XMLFormatStrategy : IConfigFileFormatStrategy
    {
        public ConfigDTO Read(string configName)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(FileReader.GetFileContent(configName));
            string json = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.None, true);

            return JsonConvert.DeserializeObject<ConfigDTO>(json);
        }
    }
}