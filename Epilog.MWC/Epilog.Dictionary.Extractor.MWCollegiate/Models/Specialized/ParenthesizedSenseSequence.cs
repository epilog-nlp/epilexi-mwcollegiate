using System;
using System.Collections.Generic;
using System.Text;

namespace Epilog.Extractor.Models.Specialized
{
    public class ParenthesizedSenseSequence
    {
        /// <summary>
        /// The Binding Substitute.
        /// </summary>
        public BindingSubstitute Bs { get; set; }


        public List<Sense> Senses { get; set; } = new List<Sense>();
        
    }
}
