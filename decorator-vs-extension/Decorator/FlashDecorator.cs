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
            Flash();
            return _camera.Capture() + 10;
        }

        public void Flash()
        {
            Console.WriteLine("*flash*");
        }

        public override string GetDescription()
        {
            return _camera.GetDescription() + ", with flash";
        }
    }
}
