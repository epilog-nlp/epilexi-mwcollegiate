using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Epilog.Extractor.Models
{
    public class ParagraphText
    {
        /// <summary>
        /// The complete text of the paragraph without modifying <see cref="VerbalIllustration"/>.
        /// </summary>
        public string Text => Parts.Aggregate("", (result, part) => $"{result}{part.Text}");

        /// <summary>
        /// The divided text of a paragraph with modifying illustrations.
        /// </summary>
        public List<Specialized.ParagraphTextPart> Parts { get; set; } = new List<Specialized.ParagraphTextPart>();

    }
}
