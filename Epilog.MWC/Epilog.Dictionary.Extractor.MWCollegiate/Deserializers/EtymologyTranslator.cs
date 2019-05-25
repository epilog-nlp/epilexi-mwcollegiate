/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Epilog.Extractor.Deserializers
{
    using Models;

    public static class EtymologyTranslator
    {
        private static readonly ImmutableDictionary<string, Action<Etymology, JArray>> conversions
            = new Dictionary<string, Action<Etymology, JArray>>
            {
                ["text"] = SetText,
                ["et_snote"] = SetSupplementalNote
            }.ToImmutableDictionary();

        private static void SetText(Etymology etymology, JArray array)
            => etymology.Text = array.ParseNextAsString();

        private static void SetSupplementalNote(Etymology etymology, JArray array)
            => etymology.Et_snote = array.ParseNextAs<List<JArray>>()
                                         .Select(subArray => subArray.ParseNextAsString())
                                         .ToList();

        public static Etymology GetEtymology(this IEnumerable<JArray> source) 
            => source.ApplyConversions(conversions);
    }
}
