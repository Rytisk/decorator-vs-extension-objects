using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionObjects
{
    public abstract class CameraExtension
    {
        protected Camera _camera;

        public CameraExtension(Camera camera)
        {
            _camera = camera;
        }

        public abstract Image Retouch(Image image);
    }
}
