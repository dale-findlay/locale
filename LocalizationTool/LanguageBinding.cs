using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalizationTool
{
    /// <summary>
    /// The DataSource for the DataGridView
    /// </summary>
    class LanguageBinding
    {
        
        public int stringID
        {
            get; set;
        }

        public string englishTranslation
        {
            get; set;
        }

        public string frenchTranslation
        {
            get; set;
        }

    }
}
