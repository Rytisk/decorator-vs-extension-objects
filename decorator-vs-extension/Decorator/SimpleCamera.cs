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

        public string Capture()
        {
            return "<capture data in base64>";
        }

        public string GetDescription()
        {
            return "Simple camera";
        }

        public int GetQuality()
        {
            return _quality;
        }
    }
}
