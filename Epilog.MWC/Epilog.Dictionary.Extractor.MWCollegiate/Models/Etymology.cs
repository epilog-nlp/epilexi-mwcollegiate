using System;
using System.Collections.Generic;
using System.Text;

namespace Epilog.Extractor.Models
{
    public class Etymology
    {
        /// <summary>
        /// The Etymology content.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Etymology Supplemental Note
        /// </summary>
        public List<string> Et_snote { get; set; }
    }
}
