using pulsee.engine.Config.Utils;
using pulsee.engine.Utils;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace pulsee.engine.Config
{
    static class ConfigFileFinder
    {
        public static List<string> FindConfigFiles()
        {
            Regex reg = new Regex(string.Format(
                @"^.*\\config\.({0})$", 
                string.Join("|", GameContainer.configManager.loadedConfig.Config.ExtensionsPriority))
            );

            return Directory.GetFiles(Info.ProjectDirectory)
                .Where(path => reg.IsMatch(path))
                .ToList();
        }

        public static string GetConfigFile()
        {
            List<string> fileNames = FindConfigFiles();

            if (fileNames.Count == 0)
                return null;

            int elementIdx = ExtensionPicker.GetHigherPriorityExtenstionIndex(fileNames);

            return ListFinder.FindElementFromRegex(fileNames, string.Format(@".*\.{0}", GameContainer.configManager.loadedConfig.Config.ExtensionsPriority[elementIdx]));
        }
    }
}
