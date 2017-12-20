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

        public static void RemoveRole<T>(ref ICamera decorator) where T : CameraDecorator
        {
            //Doesnt work with first
            if(decorator is CameraDecorator)
            {
                CameraDecorator camDecorator = decorator as CameraDecorator;
                while (camDecorator is CameraDecorator)
                {
                    if (camDecorator._camera is T)
                    {
                        var next = camDecorator._camera as CameraDecorator;
                        camDecorator._camera = next._camera;
                    }
                    camDecorator = camDecorator._camera as CameraDecorator;
                }
            }
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
    }
}
