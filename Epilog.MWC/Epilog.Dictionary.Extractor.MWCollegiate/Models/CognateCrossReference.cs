/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

using System.Collections.Generic;

namespace Epilog.Extractor.Models
{
    public class CognateCrossReference
    {
        /// <summary>
        /// Cognate Cross-Reference Label
        /// </summary>
        public string Cxl { get; set; }

        /// <summary>
        /// Cognate Cross-Reference Targets
        /// </summary>
        public List<CognateCrossReferenceTarget> Cxtis { get; set; }
    }
}
