using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionObjects.Extensions
{
    class SmoothSkinExtension : CameraExtension
    {
        public SmoothSkinExtension(Camera camera) : base(camera)
        {
        }

        public override Image Retouch(Image image)
        {
            image.AddFeature("Smooth skin");
            return image;
        }
    }
}
