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
            ICamera camera = new TimerDecorator(new FlashDecorator(new SimpleCamera()));

            Console.WriteLine(camera.Capture());

            var newCam = new LensDecorator(CameraDecorator.RemoveRole<TimerDecorator>(camera));

            Console.WriteLine(newCam.Capture());

            var timer = CameraDecorator.GetRole<TimerDecorator>(camera);

            timer.WaitTimer();
        }
    }
}
