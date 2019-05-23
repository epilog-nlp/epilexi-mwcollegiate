/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

namespace Epilog.Extractor.Models
{
    public class AttributionOfQuote
    {
        /// <summary>
        /// Name of Author
        /// </summary>
        public string Auth { get; set; }

        /// <summary>
        /// Source work for Quote
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Publication Date of Quote
        /// </summary>
        public string Aqdate { get; set; }

        /// <summary>
        /// Further detail on quote source
        /// </summary>
        public SubSource Subsource { get; set; }
    }
}
