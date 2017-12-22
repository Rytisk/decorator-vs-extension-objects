using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class FlashDecorator : CameraDecorator
    {
        public FlashDecorator(ICamera camera) : base(camera)
        {

        }

        public override int Capture()
        {
            return _camera.Capture() + Flash();
        }

        public int Flash()
        {
            Console.WriteLine("*flash*");
            return 10;
        }

        public override string GetDescription()
        {
            return _camera.GetDescription() + ", with flash";
        }
    }
}
