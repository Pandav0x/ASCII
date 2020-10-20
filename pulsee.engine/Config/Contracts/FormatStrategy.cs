using pulsee.engine.IO.File;
using pulsee.engine.IO.File.Contracts;

namespace pulsee.engine.Config.Contracts
{
    public abstract class FormatStrategy
    {
        protected IFileReader fileReader;

        public FormatStrategy(IFileReader fileReader_)
        {
            fileReader = fileReader_;
        }

        public FormatStrategy()
        {
            fileReader = new FileReader();
        }
    }
}
