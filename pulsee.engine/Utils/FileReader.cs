using System.IO;

namespace pulsee.engine.Utils
{
    static class FileReader
    {
        public static string GetFileContent(string filePath)
        {
            string content = "";

            if (File.Exists(filePath))
            {
                using (StreamReader r = new StreamReader(filePath))
                {
                    content = r.ReadToEnd();
                }
            }

            return content;
        }
    }
}
