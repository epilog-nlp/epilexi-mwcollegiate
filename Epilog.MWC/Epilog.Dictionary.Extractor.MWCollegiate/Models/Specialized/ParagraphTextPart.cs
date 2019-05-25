using System.Collections.Generic;

namespace Epilog.Extractor.Models.Specialized
{
    /// <summary>
    /// Represents a portion of <see cref="ParagraphText"/> text section including an optional modifying <see cref="VerbalIllustration"/>.
    /// </summary>
    public class ParagraphTextPart
    {
        /// <summary>
        /// Part of the parent paragraph's full text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The Verbal Illustration (Example sentence) illustrating how a word is used in the context of the <see cref="Text"/> component.
        /// </summary>
        public List<VerbalIllustration> Vis { get; set; } = new List<VerbalIllustration>();
    }
}
