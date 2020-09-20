using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pulsee.engine.Utils
{
    class Time
    {
        public static int GetEpoch()
        {
            return (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
        }

        public static long GetEpochMilliseconds()
        {
            return (DateTimeOffset.UtcNow).ToUnixTimeMilliseconds();
        }
    }
}
