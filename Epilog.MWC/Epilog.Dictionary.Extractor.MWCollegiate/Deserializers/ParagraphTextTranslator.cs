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

    public static class ParagraphTextTranslator
    {
        private static readonly ImmutableDictionary<string, Action<ParagraphText, JArray>> conversions
            = new Dictionary<string, Action<ParagraphText, JArray>>
            {
                ["text"] = SetText,
                ["vis"] = AddVerbalIllustrations
            }.ToImmutableDictionary();

        private static void SetText(ParagraphText textPart, JArray array)
            => textPart.Parts.Add(new ParagraphTextPart { Text = array.ParseNextAsString() });

        private static void AddVerbalIllustrations(ParagraphText textPart, JArray array)
            => textPart.Parts.Last().Vis.AddRange(array.ParseNextAs<List<VerbalIllustration>>());

        public static ParagraphText GetParagraphText(this IEnumerable<JArray> source) 
            => source.ApplyConversions(conversions);
    }
}
