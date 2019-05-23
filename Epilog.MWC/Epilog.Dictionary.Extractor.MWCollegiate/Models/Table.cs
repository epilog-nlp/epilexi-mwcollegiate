/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

namespace Epilog.Extractor.Models
{
    public class Table
    {
        /// <summary>
        /// String ID of the target table
        /// </summary>
        public string Tableid { get; set; }

        /// <summary>
        /// String text to display in Table Link
        /// </summary>
        public string Displayname { get; set; }

    }
}
