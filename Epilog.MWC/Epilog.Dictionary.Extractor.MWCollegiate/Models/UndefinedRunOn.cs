/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Epilog.Extractor.Models
{
    public class UndefinedRunOn
    {
        /// <summary>
        /// Undefined Entry Word
        /// </summary>
        public string Ure { get; set; }

        /// <summary>
        /// Functional Label
        /// </summary>
        public string Fl { get; set; }

        /// <summary>
        /// Undefined Run-On Text Section
        /// </summary>
        public JArray Utxt { get; set; }

        /// <summary>
        /// Inflections
        /// </summary>
        public List<Inflection> Ins { get; set; }

        /// <summary>
        /// General Labels
        /// </summary>
        public List<string> Lbs { get; set; }

        /// <summary>
        /// Pronunciations
        /// </summary>
        public List<Pronunciation> Prs { get; set; }

        /// <summary>
        /// Parenthesized Subject/Status Label
        /// </summary>
        public string Psl { get; set; }

        /// <summary>
        /// Subject/Status Labels
        /// </summary>
        public string Sls { get; set; }

        /// <summary>
        /// Variants
        /// </summary>
        public List<Variant> Vrs { get; set; }
    }
}
