/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Epilog.Extractor.Models
{
    public class JsonResponse
    {
        /// <summary>
        /// Metadata for the response
        /// </summary>
        public Metadata Meta { get; set; }

        /// <summary>
        /// Homograph Number
        /// </summary>
        public int Hom { get; set; }

        /// <summary>
        /// Headword Info
        /// </summary>
        public HeadwordInfo Hwi { get; set; }

        /// <summary>
        /// Alternate Headwords
        /// </summary>
        public List<AlternateHeadword> Ahws { get; set; }

        /// <summary>
        /// Points to Artwork
        /// </summary>
        public Artwork Art { get; set; }

        /// <summary>
        /// Cognate Cross References
        /// </summary>
        public List<CognateCrossReference> Cxs { get; set; }

        /// <summary>
        /// Date of First Known Use of word
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// General Label
        /// </summary>
        public List<string> Lbs { get; set; }

        /// <summary>
        /// Synonym Section
        /// </summary>
        public List<Synonym> Syns { get; set; }

        /// <summary>
        /// Undefined Run-Ons
        /// </summary>
        public List<UndefinedRunOn> Uros { get; set; }

        /// <summary>
        /// Defined Run-Ons
        /// </summary>
        public List<DefinedRunOn> Dros { get; set; }

        /// <summary>
        /// Directional Cross Reference Section
        /// </summary>
        public List<string> Dxnls { get; set; }

        /// <summary>
        /// Variants
        /// </summary>
        public List<Variant> Vrs { get; set; }

        /// <summary>
        /// Usage Section
        /// </summary>
        public List<Usage> Usages { get; set; }

        /// <summary>
        /// Etymology
        /// </summary>
        public List<JArray> Et { get; set; }

        /// <summary>
        /// Tables
        /// </summary>
        public Table Table { get; set; }

        /// <summary>
        /// Inflections
        /// </summary>
        public List<Inflection> Ins { get; set; }

        /// <summary>
        /// Subject Status Labels
        /// </summary>
        public List<string> Sls { get; set; }

        /// <summary>
        /// Quotations Section
        /// </summary>
        public List<Quotation> Quotes { get; set; }

        /// <summary>
        /// Functional Label
        /// </summary>
        public string Fl { get; set; }

        /// <summary>
        /// Short Definition
        /// </summary>
        public List<string> Shortdef { get; set; }

        /// <summary>
        /// Definition Section
        /// </summary>
        public List<Definition> Def { get; set; }



    }

}
