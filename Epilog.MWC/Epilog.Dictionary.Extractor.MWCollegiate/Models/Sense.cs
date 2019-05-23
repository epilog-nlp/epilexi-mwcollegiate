/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Epilog.Extractor.Models
{
    public class Sense
    {
        /// <summary>
        /// Sense Number
        /// </summary>
        public string Sn { get; set; }

        /// <summary>
        /// Defining Text
        /// </summary>
        public List<JArray> Dt { get; set; }

        /// <summary>
        /// Etymology
        /// </summary>
        public List<JArray> Et { get; set; }

        /// <summary>
        /// Inflections
        /// </summary>
        public List<Inflection> Ins { get; set; }

        /// <summary>
        /// Labels
        /// </summary>
        public List<string> Lbs { get; set; }

        /// <summary>
        /// Pronunciations
        /// </summary>
        public List<Pronunciation> Prs { get; set; }

        /// <summary>
        /// Divided Sense
        /// </summary>
        public DividedSense Sdsense { get; set; }

        /// <summary>
        /// Sense-Specific Grammatical Label
        /// </summary>
        public string Sgram { get; set; }

        /// <summary>
        /// Subject/Status Labels
        /// </summary>
        public List<string> SlS { get; set; }

        /// <summary>
        /// Variants
        /// </summary>
        public List<Variant> Vrs { get; set; }
    }
}
