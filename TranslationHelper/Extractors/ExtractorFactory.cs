using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationHelper.Extractors
{
    class ExtractorFactory
    {
        private String windowsFile;
        private String androidFile;
        private String iosFile;
        private String outFile;
        private Dictionary<String, TranslationItem> compDict;
        public ExtractorFactory(String _windowsFile, String _androidFile, String _iosFile, String _outFile)
        {
            this.windowsFile = _windowsFile;
            this.androidFile = _androidFile;
            this.iosFile = _iosFile;
            this.outFile = _outFile;
            this.compDict = new Dictionary<String, TranslationItem>();
        }

        public void ExtractThemStrings()
        {
            //List<Extractor> extractorList = new List<Extractor>();  //make an actual factory model, haha
            compDict = new Dictionary<String, TranslationItem>();
            WindowsExtractor winExtract = new WindowsExtractor(windowsFile);
            Dictionary<String, TranslationItem> winDict = winExtract.Extract();
            //AndroidExtractor androidExtract = new AndroidExtractor(androidFile);
            //Dictionary<String, TranslationItem> androidDict = androidExtract.Extract();
            Dictionary<String, TranslationItem> androidDict = new Dictionary<String, TranslationItem>();
            //IOSExtractor iosExtract = new IOSExtractor(iosFile);
            //Dictionary<String, TranslationItem> iosDict = iosExtract.Extract();
            Dictionary<String, TranslationItem> iosDict = new Dictionary<String,TranslationItem>();
            compDict = winDict.Concat(androidDict).Concat(iosDict).GroupBy(d => d.Key)
             .ToDictionary(d => d.Key, d => d.First().Value);

            String csv = "Key ; English ; Spanish ; Portuguese ; French ; German ; Dutch ;\n";
            csv += String.Join(
                Environment.NewLine,
                compDict.Select(d => d.Key + ";" + d.Value.English + ";" + d.Value.Spanish + ";" + d.Value.Portuguese + ";" + d.Value.French + ";" + d.Value.German + ";" + d.Value.Dutch + ";")
            );
            System.IO.File.WriteAllText(outFile, csv);
        }

        public void CreateExcelFile(Dictionary<String, String> transDict)
        {

        }
    }
}
