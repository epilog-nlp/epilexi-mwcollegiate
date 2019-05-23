/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Epilog.Extractor.Deserializers
{
    internal static class ArrayTranslator
    {
        internal static string ParseNextAsString(this JArray array) => array[1].Value<string>();

        internal static T ParseNextAs<T>(this JArray array) => array[1].Value<T>();
    }
}
