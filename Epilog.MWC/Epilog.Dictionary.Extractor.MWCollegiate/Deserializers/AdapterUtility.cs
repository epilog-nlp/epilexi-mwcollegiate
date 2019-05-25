using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Epilog.Extractor.Deserializers
{
    public static class AdapterUtility
    {
        internal static TModel ApplyConversions<TModel>(this IEnumerable<JArray> source, IDictionary<string, Action<TModel, JArray>> conversions)
            where TModel : new()
        {
            var result = new TModel();
            source.Where(a => conversions.ContainsKey(a[0].Value<string>())) // First element corresponds to delegate dictionary key
                  .ToList()
                  .ForEach(array => conversions[array[0].Value<string>()](result, array)); // Invoke delegates
            return result;
        }
    }
}
