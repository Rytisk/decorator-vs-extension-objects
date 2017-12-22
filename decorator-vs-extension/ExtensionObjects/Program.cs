using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionObjects.Extensions;

namespace ExtensionObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera cam = new SimpleCamera();

            cam.AddExtention(new RedEyesExtension(cam));
            cam.AddExtention(new SmoothSkinExtension(cam));

            var img = cam.Capture();
            PrintFeatures(img);
            
            img = cam.Retouch(img);
            PrintFeatures(img);

            cam.RemoveExtention<SmoothSkinExtension>();
            var newImg = cam.Capture();
            newImg = cam.Retouch(newImg);
            PrintFeatures(newImg);

            var extension = cam.GetExtention<RedEyesExtension>();

            var demonImg = extension.DemonEyesEffectImage();
            PrintFeatures(demonImg);
        }

        static void PrintFeatures(Image image)
        {
            foreach (var feature in image.GetFeatures())
                Console.WriteLine(feature);
            Console.WriteLine();
        }
    }
}
