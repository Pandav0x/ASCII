using pulsee.engine.Config.Contracts;
using pulsee.engine.Utils;
using System;
using System.Collections.Generic;
using System.IO;

namespace pulsee.engine.Config.Utils
{
    static class FormatSelector
    {
        public static IConfigFileFormatStrategy GetFileFormatStrategyFromFileNames(List<string> fileNames)
        {
            List<Type> configFileFormatStrategies = Reflexion.GetTypesImplementing<IConfigFileFormatStrategy>();

            int elementIdx = ExtensionPicker.GetHigherPriorityExtenstionIndex(configFileFormatStrategies);

            string selectedFormat = GameContainer.configManager.loadedConfig.Config.ExtensionsPriority[elementIdx].ToUpper();

            return GetConfigStrategyIndex(selectedFormat);
        }

        public static IConfigFileFormatStrategy GetFileFormatStrategyFromFileName(string fileName)
        {        
            string extension = Path.GetExtension(fileName);

            return GetConfigStrategyIndex(extension.Replace(".", "").ToUpper());
        }

        private static IConfigFileFormatStrategy GetConfigStrategyIndex(string format)
        {
            List<Type> configFileFormatStrategies = Reflexion.GetTypesImplementing<IConfigFileFormatStrategy>();

            int configStrategyIndex = ListFinder.FindIndexFromRegex(configFileFormatStrategies, string.Format(@"{0}.*", format));

            return (IConfigFileFormatStrategy)Reflexion.InstanciateFromType(configFileFormatStrategies[configStrategyIndex]);
        }
    }
}
