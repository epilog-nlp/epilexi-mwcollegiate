/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

using System.Collections.Generic;

namespace Epilog.Extractor.Models
{
    public class Inflection
    {
        /// <summary>
        /// Fully Spelled-Out Inflection
        /// </summary>
        public string If { get; set; }

        /// <summary>
        /// Inflection cutback; Inflection ending ("-ing")
        /// </summary>
        public string Ifc { get; set; }

        /// <summary>
        /// Inflection Label
        /// </summary>
        public string Il { get; set; }

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
