using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace TranslationHelper.Extractors
{
    class AndroidExtractor //: Extractor
    {
        private String filename;
        private List<String> otherFiles;
        private Dictionary<String, TranslationItem> translationItems;
        public AndroidExtractor()
        {

        }

        public AndroidExtractor(String _filename)
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
                if (f.EndsWith(".xml") && !f.Equals(filename))
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

                XmlDocument document = new XmlDocument();
                document.Load(f);
                //XmlNode root = document.GetElementsByTagName("resources")[0];
                XmlNodeList elemList = document.GetElementsByTagName("string");
                //XmlNodeList elemList = document.GetElementsByTagName("resources").;
                for (int i = 0; i < elemList.Count; i++)
                {
                    if (translationItems.ContainsKey(elemList[i].Attributes[0].Value))
                    {
                        TranslationItem item = translationItems[elemList[i].Attributes[0].Value];
                        item.GetType().GetProperty(currLang).SetValue(item, elemList[i].ChildNodes[1].InnerText, null);
                    }
                    else
                    {
                        TranslationItem item = new TranslationItem(elemList[i].Attributes[0].Value);
                        item.key = elemList[i].Attributes[0].Value;
                        item.GetType().GetProperty(currLang).SetValue(item, elemList[i].InnerText);
                        translationItems.Add(elemList[i].Attributes[0].Value, item);
                    }
                }
            }
            return translationItems;
        }
    }
}
