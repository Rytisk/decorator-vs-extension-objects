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

        public static ICamera RemoveRole<T>(ICamera decorator) where T : CameraDecorator
        {
            if(decorator is CameraDecorator)
            {
                return ((CameraDecorator)decorator).Remove<T>();
            }
            return decorator;
        }

        public static T GetRole<T>(ICamera decorator) where T : CameraDecorator
        {
            if(decorator is CameraDecorator)
            {
                CameraDecorator camDecorator = decorator as CameraDecorator;
                while(camDecorator is CameraDecorator)
                {
                    if (camDecorator is T)
                        return camDecorator as T;
                    camDecorator = camDecorator._camera as CameraDecorator;
                }
            }
            return null;
        }

        public ICamera Remove<T>() where T : CameraDecorator
        {
            if (this is T)
                return _camera;
            else
            {
                _camera = ((CameraDecorator)_camera).Remove<T>();
                return this;
            }
        }
    }
}
