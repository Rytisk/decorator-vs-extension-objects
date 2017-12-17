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

        public override string Capture()
        {
            Flash();
            return "<capture data with flash>";
        }

        public void Flash()
        {
            Console.WriteLine("*flash*");
        }

        public new string GetDescription()
        {
            return base.GetDescription() + ", with flash";
        }

        public new int GetQuality()
        {
            return base.GetQuality() + 10;
        }
    }
}
