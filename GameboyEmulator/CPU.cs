using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameboyEmulator
{
    public class CPU
    {
        public CPU()
        {
            throw new OPCodeUnimplementedException(1, 0x00.ToString());
        }


        public class OPCodeUnimplementedException : Exception
        {
            public OPCodeUnimplementedException(int severity, string message) : base(message)
            {
                // do whatever you want with severity
            }
        }
    }


}
