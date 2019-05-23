/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

using System.Collections.Generic;

namespace Epilog.Extractor.Models
{
    public class AlternateHeadword
    {
        /// <summary>
        /// Headword
        /// </summary>
        public string Hw { get; set; }

        /// <summary>
        /// Pronunciations
        /// </summary>
        public List<Pronunciation> Prs { get; set; }

        /// <summary>
        /// Parenthesized Subject Status Label
        /// </summary>
        public string Psl { get; set; }

    }
}
