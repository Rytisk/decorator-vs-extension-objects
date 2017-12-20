using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICamera camera = new FlashDecorator(new TimerDecorator(new SimpleCamera()));

            Console.WriteLine(camera.Capture());

            var flasher = CameraDecorator.GetRole<FlashDecorator>(camera);
            flasher.Flash();
            CameraDecorator.RemoveRole<TimerDecorator>(ref camera);

            Console.WriteLine(camera.Capture());
        }
    }
}
