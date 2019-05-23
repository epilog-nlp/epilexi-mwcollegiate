/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

namespace Epilog.Extractor.Models
{
    public class Quotation
    {
        /// <summary>
        /// Quotation Text
        /// </summary>
        public string T { get; set; }

        /// <summary>
        /// Source of the Quote
        /// </summary>
        public AttributionOfQuote Aq { get; set; }
    }
}
