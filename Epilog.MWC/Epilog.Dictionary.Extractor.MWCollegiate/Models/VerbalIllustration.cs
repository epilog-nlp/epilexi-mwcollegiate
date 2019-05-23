using System;
using System.Collections.Generic;
using System.Text;

namespace Epilog.Extractor.Models
{
    public class VerbalIllustration
    {
        /// <summary>
        /// The text of the Verbal Illustration. Yes, it's a T.
        /// </summary>
        public string T { get; set; }

        /// <summary>
        /// Attribution of Quote
        /// </summary>
        public AttributionOfQuote Aq { get; set; }

    }
}
