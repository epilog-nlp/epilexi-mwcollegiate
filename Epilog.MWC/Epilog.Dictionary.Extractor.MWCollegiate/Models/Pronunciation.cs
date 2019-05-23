/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

namespace Epilog.Extractor.Models
{
    public class Pronunciation
    {
        /// <summary>
        /// Pronunciation Label before pronunciation
        /// </summary>
        public string L { get; set; }

        /// <summary>
        /// Pronunciation Label after pronunciation
        /// </summary>
        public string L2 { get; set; }

        /// <summary>
        /// Written pronunciation in Merriam-Webster format
        /// </summary>
        public string Mw { get; set; }

        /// <summary>
        /// Punctuation to separate pronunciation objects
        /// </summary>
        public string Pun { get; set; }

        /// <summary>
        /// Audio playback information
        /// </summary>
        public SoundInfo Sound { get; set; }

    }
}
