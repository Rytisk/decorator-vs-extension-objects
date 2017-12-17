using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class LensDecorator : CameraDecorator
    {
        public LensDecorator(ICamera camera) : base(camera)
        {

        }

        public override string Capture()
        {
            Focus();
            return "<capture data with focus>";
        }

        public void Focus()
        {
            Console.WriteLine("Focusing the camera lens");
        }

        public new string GetDescription()
        {
            return base.GetDescription() + ", with good lens";
        }

        public new int GetQuality()
        {
            return base.GetQuality() + 15;
        }
    }
}
