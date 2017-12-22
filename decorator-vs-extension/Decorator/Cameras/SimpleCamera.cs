using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SimpleCamera : ICamera
    {
        private int _quality = 50;

        public int Capture()
        {
            return _quality;
        }

        public string GetDescription()
        {
            return "Simple camera";
        }
    }
}
