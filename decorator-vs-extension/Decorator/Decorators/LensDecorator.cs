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
            return _camera.Capture() + Focus();
        }

        public int Focus()
        {
            Console.WriteLine("Focusing the camera lens");
            return 15;
        }

        public override string GetDescription()
        {
            return _camera.GetDescription() + ", with good lens";
        }
    }
}
