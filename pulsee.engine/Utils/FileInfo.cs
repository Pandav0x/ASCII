using System;
using System.IO;
using System.Text.RegularExpressions;

namespace pulsee.engine.Utils
{
    class FileInfo
    {
        public static string GetExtention(string fileName)
        {
            return (new System.IO.FileInfo(fileName)).Extension;
        }
    }
}
