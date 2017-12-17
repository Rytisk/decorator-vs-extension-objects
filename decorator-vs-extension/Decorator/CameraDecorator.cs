using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class CameraDecorator : ICamera
    {
        private ICamera _camera;

        public abstract string Capture();

        public CameraDecorator(ICamera camera)
        {
            _camera = camera;
        }    

        public string GetDescription()
        {
            return _camera.GetDescription();
        }

        public int GetQuality()
        {
            return _camera.GetQuality();
        }
    }
}
