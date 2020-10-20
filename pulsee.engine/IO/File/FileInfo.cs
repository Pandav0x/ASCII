namespace pulsee.engine.IO.File
{
    class FileInfo
    {
        public static string GetExtention(string fileName)
        {
            return (new System.IO.FileInfo(fileName)).Extension;
        }
    }
}
