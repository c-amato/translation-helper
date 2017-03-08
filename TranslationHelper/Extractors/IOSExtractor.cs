using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TranslationHelper.Extractors
{
    class IOSExtractor //: Extractor
    {
        private String filename;
        private List<String> otherFiles;
        private Dictionary<String, TranslationItem> translationItems;
        public IOSExtractor()
        {

        }

        public IOSExtractor(String _filename)
        {
            this.filename = _filename;
            this.translationItems = new Dictionary<String, TranslationItem>();
            this.otherFiles = new List<String>();
            this.otherFiles.Add(_filename);
            FindOtherFiles();
        }

        public void FindOtherFiles()
        {
            string workingDirectory = Path.GetDirectoryName(filename);
            foreach (String f in Directory.GetFiles(workingDirectory))
            {
                if (f.EndsWith(".strings") && !f.Equals(filename))
                {
                    otherFiles.Add(f);
                }
            }
        }

        public Dictionary<String, TranslationItem> Extract()
        {
            String currLang = "";

            foreach (String f in otherFiles)
            {
                if (f.Contains(".es."))
                    currLang = "Spanish";
                else if (f.Contains(".pt."))
                    currLang = "Portuguese";
                else if (f.Contains(".fr."))
                    currLang = "French";
                else if (f.Contains(".de."))
                    currLang = "German";
                else if (f.Contains(".nl."))
                    currLang = "Dutch";
                else
                    currLang = "English";


            }
            return translationItems;
        }
    }
}
