/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

namespace Epilog.Extractor.Models
{
    public class CognateCrossReferenceTarget
    {
        /// <summary>
        /// Cognate Cross-Reference Label
        /// </summary>
        public string Cxl { get; set; }
        
        /// <summary>
        /// Cross-Reference target Id
        /// </summary>
        public string Cxr { get; set; }

        /// <summary>
        /// Cross-Reference Hyperlink Text
        /// </summary>
        public string Cxt { get; set; }

        /// <summary>
        /// Sense Number of Cross-Reference Target
        /// </summary>
        public string Cxn { get; set; }


    }
}
