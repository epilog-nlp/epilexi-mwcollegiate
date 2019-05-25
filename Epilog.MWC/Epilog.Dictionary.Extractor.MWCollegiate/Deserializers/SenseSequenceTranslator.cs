/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Newtonsoft.Json;

namespace Epilog.Extractor.Deserializers
{
    using Models;
    using Models.Specialized;
    

    public static class SenseSequenceTranslator
    {
        private static readonly ImmutableDictionary<string, Action<SenseSequence, JArray>> conversions
            = new Dictionary<string, Action<SenseSequence, JArray>>
            {
                ["bs"] = AddBindingSubstitute,
                ["sen"] = AddSense,
                ["sense"] = AddSense,
                ["pseq"] = AddParenthesizedSenseSequence

            }.ToImmutableDictionary();

        private static void AddBindingSubstitute(SenseSequence sequence, JArray array)
        {
            sequence.Add(array.ParseNextAs<BindingSubstitute>().Sense);
        }

        private static void AddSense(SenseSequence sequence, JArray array)
        {
            sequence.Add(array.ParseNextAs<Sense>());
        }

        private static void AddParenthesizedSenseSequence(SenseSequence sequence, JArray array)
        {
            var result = array.ParseNextAs<IEnumerable<JArray>>().GetParenthesizedSenseSequence();
            //var result = JsonConvert.DeserializeObject<IEnumerable<JArray>>(array[1].ToString()).GetParenthesizedSenseSequence();
            result.ToSenses().ToList().ForEach(sequence.Add);
        }

        public static SenseSequence GetSenseSequence(this IEnumerable<IEnumerable<JArray>> source)
        {
            var result = new SenseSequence();
            source.SelectMany(inner => inner.ApplyConversions(conversions).Senses).ToList().ForEach(sense => result.Add(sense.Value));
            return result;
        }

    }
}
