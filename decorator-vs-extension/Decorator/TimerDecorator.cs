﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class TimerDecorator : CameraDecorator
    {
        public TimerDecorator(ICamera camera) : base(camera)
        {

        }

        public override int Capture()
        {
            return 0;
        }

        public override string GetDescription()
        {
            return _camera.GetDescription() + ", with timer";
        }
    }
}
