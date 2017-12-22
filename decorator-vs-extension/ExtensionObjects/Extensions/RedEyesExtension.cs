using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionObjects.Extensions
{
    class RedEyesExtension : CameraExtension
    {
        public RedEyesExtension(Camera camera) : base(camera)
        {
        }

        public override Image Retouch(Image image)
        {
            image.AddFeature("Red eyes removal");
            return image;
        }

        public Image DemonEyesEffectImage()
        {
            Image image = _camera.Capture();
            image.AddFeature("Demon eyes");
            return image;
        }
    }
}
