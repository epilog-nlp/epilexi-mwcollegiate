/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Epilog.Extractor.Models
{
    public class Definition
    {
        /// <summary>
        /// Verb Divider
        /// </summary>
        public string Vd { get; set; }

        /// <summary>
        /// Subject/Status Label
        /// </summary>
        public List<string> Sls { get; set; }

        /// <summary>
        /// Sense Sequence
        /// </summary>
        public List<JArray> Sseq { get; set; }
    }
}
