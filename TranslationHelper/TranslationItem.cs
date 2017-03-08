using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Might want a class like this in the future for storing various metadata for each inidivual translation item.
// Currently we just handle them "blindly" and just copy the string value around

namespace TranslationHelper
{
    class TranslationItem
    {
        public TranslationItem(String _key)
        {
            //this.key = _key;
            //this.English = "";
            //this.Dutch = "";
            //this.French = "";
            //this.German = "";
            //this.Portuguese = "";
            //this.Spanish = "";
        }
        public String key { get; set; }
        public String English { get; set; }
        public String Dutch { get; set; }
        public String French { get; set; }
        public String German { get; set; }
        public String Portuguese { get; set; }
        public String Spanish { get; set; }
    }
}
