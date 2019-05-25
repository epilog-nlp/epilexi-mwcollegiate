/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Epilog.Extractor.Deserializers
{
    internal static class ArrayTranslator
    {
        internal static string ParseNextAsString(this JArray array) => array[1].Value<string>();

        internal static T ParseNextAs<T>(this JArray array) => JsonConvert.DeserializeObject<T>(array[1].ToString());

        internal static bool IsFirstArray(this JArray array) 
            => array.Children().FirstOrDefault()?.Equals(array.Children<JArray>().FirstOrDefault()) ?? false;

        internal static bool TryGetValue<TOut>(this JToken item, out TOut result)
        {
            var isSuccess = false;
            result = JsonConvert.DeserializeObject<TOut>(item.ToString(), new JsonSerializerSettings
            {
                Error = (sender, args) => 
                {
                    isSuccess = false;
                    args.ErrorContext.Handled = true;
                },
                MissingMemberHandling = MissingMemberHandling.Ignore
            });
            return isSuccess;
        }
    }
}
