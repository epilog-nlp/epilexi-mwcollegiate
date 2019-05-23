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
            var a = sources.ToList();
        }
    }
}
