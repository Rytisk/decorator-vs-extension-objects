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

        public override int Capture()
        {
            Focus();
            return _camera.Capture() + 15;
        }

        public void Focus()
        {
            Console.WriteLine("Focusing the camera lens");
        }

        public override string GetDescription()
        {
            return _camera.GetDescription() + ", with good lens";
        }
    }
}
