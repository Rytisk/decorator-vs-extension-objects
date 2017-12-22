using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionObjects
{
    class SimpleCamera : Camera
    {
        public override Image Capture()
        {
            return new Image();
        }

        public override Image Retouch(Image image)
        {
            image = base.Retouch(image);
            image.AddFeature("Regulated brightness");
            return image;
        }
    }
}
