using System;
using System.Collections.Generic;
using System.Text;

namespace Epilog.Extractor.Models.Specialized
{
    /// <summary>
    /// A sequence of related Senses and Subsenses.
    /// </summary>
    /// <remarks>
    /// From the API, a Sense Sequence (SSEQ) array can contain any of the following as elements:
    /// Sense; Truncated Sense (SEN); Binding Substitute (BS); Parenthesized Sense Sequence (PSEQ).
    /// </remarks>
    public class SenseSequence
    {

        //public List<List<Sense>> Senses { get; set; } = new List<List<Sense>>();

        public IDictionary<int, Sense> Senses { get; } = new Dictionary<int, Sense>();

        private int senseId;

        private int NextId => System.Threading.Interlocked.Increment(ref senseId);

        public void Add(Sense sense) => Senses[NextId] = sense;
    }
}
