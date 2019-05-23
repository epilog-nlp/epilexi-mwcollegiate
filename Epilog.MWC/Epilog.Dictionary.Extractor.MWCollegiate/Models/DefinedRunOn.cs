/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Epilog.Extractor.Models
{
    public class DefinedRunOn
    {
        /// <summary>
        /// Defined Run-On Phrase
        /// </summary>
        public string Drp { get; set; }

        /// <summary>
        /// Definition Section
        /// </summary>
        public List<Definition> Def { get; set; }

        /// <summary>
        /// Etymology
        /// </summary>
        public List<JArray> Et { get; set; }

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
        public List<string> Sls { get; set; }
             
        /// <summary>
        /// Variants
        /// </summary>
        public List<Variant> Vrs { get; set; }
    }
}
