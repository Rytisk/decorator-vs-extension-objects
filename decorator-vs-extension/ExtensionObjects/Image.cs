using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionObjects
{
    public class Image
    {
        private List<string> _features = new List<string>();

        public Image()
        {

        }

        public void AddFeature(string feature)
        {
            _features.Add(feature);
        }

        public List<string> GetFeatures()
        {
            return _features.Count > 0 ? _features : new List<string>() {"No features yet" };
        }

    }
}
