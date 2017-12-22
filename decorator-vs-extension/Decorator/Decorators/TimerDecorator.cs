using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Decorator
{
    class TimerDecorator : CameraDecorator
    {
        private int _timeToWait = 3;

        public TimerDecorator(ICamera camera) : base(camera)
        {

        }

        public override int Capture()
        {
            WaitTimer();
            return _camera.Capture();
        }

        public override string GetDescription()
        {
            return _camera.GetDescription() + ", with timer";
        }

        public void WaitTimer()
        {
            for(int i = 0; i < _timeToWait; i++)
            {
                Console.WriteLine("Count: {0}", i + 1);
                Thread.Sleep(1000);
            }
        }
    }
}
