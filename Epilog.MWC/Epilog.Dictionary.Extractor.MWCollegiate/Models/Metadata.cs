/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

using System.Collections.Generic;

namespace Epilog.Extractor.Models
{
    public class Metadata
    {
        /// <summary>
        /// Id of the entry
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Universally Unique Id for the entry
        /// </summary>
        public string Uuid { get; set; }

        /// <summary>
        /// 9-Digit Code used for sorting words in alphabetical order
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// Source Data-Set for the entry
        /// </summary>
        public string Src { get; set; }

        /// <summary>
        /// Section of the Dictionary the word comes from
        /// </summary>
        public string Section { get; set; }

        /// <summary>
        /// Lists all the entry's headwords, variants, inflections, undefined entry words, and defined run-on phrases
        /// </summary>
        public List<string> Stems { get; set; }

        /// <summary>
        /// Flag whether the word is tagged as offensive
        /// </summary>
        public bool Offensive { get; set; }

    }
}
