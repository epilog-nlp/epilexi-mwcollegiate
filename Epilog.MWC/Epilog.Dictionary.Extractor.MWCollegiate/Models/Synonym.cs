/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Epilog.Extractor.Models
{
    public class Synonym
    {
        /// <summary>
        /// Paragraph Label
        /// </summary>
        public string Pl { get; set; }

        /// <summary>
        /// Paragraph Text Section
        /// </summary>
        public List<JArray> Pt { get; set; }

        /// <summary>
        /// See in addition references
        /// </summary>
        public List<string> Sarefs { get; set; }

    }
}
