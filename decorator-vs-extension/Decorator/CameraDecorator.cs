using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class CameraDecorator : ICamera
    {
        protected ICamera _camera;

        public abstract int Capture();
        public abstract string GetDescription();

        public CameraDecorator(ICamera camera)
        {
            _camera = camera;
        }

        void AddRole<T>(T role) where T : CameraDecorator
        {
            throw new NotImplementedException();
        }

        T GetRole<T>() where T : CameraDecorator
        {
            throw new NotImplementedException();
        }
    }
}
