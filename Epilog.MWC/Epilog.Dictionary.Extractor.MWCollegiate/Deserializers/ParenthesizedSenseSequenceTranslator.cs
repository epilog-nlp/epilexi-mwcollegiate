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

namespace Epilog.Extractor.Deserializers
{
    using Models;
    using Models.Specialized;

    public static class ParenthesizedSenseSequenceTranslator
    {
        private static readonly ImmutableDictionary<string, Action<ParenthesizedSenseSequence, JArray>> conversions
            = new Dictionary<string, Action<ParenthesizedSenseSequence, JArray>>
            {
                ["bs"] = SetBindingSubstitute,
                ["sense"] = AddSense
            }.ToImmutableDictionary();


        private static void SetBindingSubstitute(ParenthesizedSenseSequence pseq, JArray array) 
            => pseq.Bs = array.ParseNextAs<BindingSubstitute>();

        private static void AddSense(ParenthesizedSenseSequence pseq, JArray array)
            => pseq.Senses.Add(array.ParseNextAs<Sense>());

        internal static ParenthesizedSenseSequence GetParenthesizedSenseSequence(this IEnumerable<JArray> source) 
            => source.ApplyConversions(conversions);

        public static IEnumerable<Sense> ToSenses(this ParenthesizedSenseSequence sequence)
        {
            var result = new List<Sense>();
            if (sequence.Bs?.Sense != null)
                result.Add(sequence.Bs.Sense);
            result.AddRange(sequence.Senses);
            return result;
        }
    }
}
