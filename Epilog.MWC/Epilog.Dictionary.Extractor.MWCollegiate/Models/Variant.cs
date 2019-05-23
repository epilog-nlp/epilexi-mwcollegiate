/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

using System.Collections.Generic;

namespace Epilog.Extractor.Models
{
    public class Variant
    {
        /// <summary>
        /// Variant
        /// </summary>
        public string Va { get; set; }

        /// <summary>
        /// Variant Label
        /// </summary>
        public string Vl { get; set; }

        /// <summary>
        /// Pronunciations
        /// </summary>
        public List<Pronunciation> Prs { get; set; }

        /// <summary>
        /// Sense-Specific Inflection Plural Label
        /// </summary>
        public string Spl { get; set; }

    }
}
