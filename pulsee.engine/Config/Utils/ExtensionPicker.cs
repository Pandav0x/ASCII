using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace pulsee.engine.Config.Utils
{
    static class ExtensionPicker
    {
        public static int GetHigherPriorityExtenstionIndex<T>(List<T> haystack)
        {
            int elementIdx = haystack.Count - 1;

            foreach (T element in haystack)
            {
                string extension = Path.GetExtension(element.ToString());

                int currentElementIdx = GameContainer.configManager.loadedConfig.Config.ExtensionsPriority.ToList<string>().IndexOf(extension.Replace(".", "").ToLower());

                elementIdx = (elementIdx > currentElementIdx) ? currentElementIdx : elementIdx;
            }

            return elementIdx;
        }
    }
}
