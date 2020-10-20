using pulsee.engine.IO.File.Contracts;

namespace pulsee.engine.IO.File
{
    class FileReader : IFileReader
    {
        public string GetFileContent(string filePath)
        {
            string content = "";

            if (System.IO.File.Exists(filePath))
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
                {
                    content = reader.ReadToEnd();
                }
            }

            return content;
        }
    }
}
