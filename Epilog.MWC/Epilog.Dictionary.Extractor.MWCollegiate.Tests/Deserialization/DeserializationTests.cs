using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace Epilog.Extractor.Tests
{
    using Models;
    using Deserializers;

    [TestClass]
    public class DeserializationTests
    {
        private static readonly IReadOnlyDictionary<string, IEnumerable<JsonResponse>> sources
            = AddWords("Hannover", "Prerogative", "Quarantine", "Shingle", "Universal");

        private static IReadOnlyDictionary<string, IEnumerable<JsonResponse>> AddWords(params string[] words)
            => words.ToDictionary(
                key => key,
                val => Deserialize($"{val}.json"));

        private static IEnumerable<JsonResponse> Deserialize(string file) 
            => JsonConvert.DeserializeObject<IEnumerable<JsonResponse>>(File.ReadAllText(file));

        [TestMethod]
        public void Initialize_Test() 
        {
            _ = sources.ToList();
        }

        [TestMethod]
        public void SenseSequenceTest()
        {
            var prero = sources["Prerogative"].Single();
            Assert.IsNotNull(prero);
            var def = prero.Def.Single();
            var sseq = def.Sseq.GetSenseSequence();
            Assert.AreEqual(6, sseq.Senses.Count());
        }
    }
}
