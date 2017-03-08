using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationHelper.Extractors
{
    abstract class Extractor
    {
        protected String filename;
        protected Dictionary<String, String> translationItems;
        protected List<String> otherFiles;
        public Extractor()
        {

        }
        public Extractor(String _filename)
        {

        }
        abstract public void FindOtherFiles();
        public abstract Dictionary<String, String> Extract();
    }
}
