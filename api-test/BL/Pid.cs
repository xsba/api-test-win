using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_test.BL
{
    public static class Pid
    {
        public static int Get()
        {
            return System.Diagnostics.Process.GetCurrentProcess().Id;
        }
    }
}
