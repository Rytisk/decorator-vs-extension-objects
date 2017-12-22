using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionObjects
{
    public abstract class Camera
    {
        private List<CameraExtension> _extentions = new List<CameraExtension>();

        public abstract Image Capture();

        public void AddExtention(CameraExtension extention)
        {
            _extentions.Add(extention);
        }

        public T GetExtention<T>() where T : CameraExtension
        {
            foreach (CameraExtension extention in _extentions)
            {
                if (extention is T)
                {
                    return (extention as T);
                }
            }
            return null;
        }

        public void RemoveExtention<T>() where T : CameraExtension
        {
            _extentions.Remove(GetExtention<T>());
        }

        public virtual Image Retouch(Image image)
        {
            foreach(var extension in _extentions)
            {
                image = extension.Retouch(image);
            }
            return image;
        }
    }
}
