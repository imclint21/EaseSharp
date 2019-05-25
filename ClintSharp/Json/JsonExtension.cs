using Newtonsoft.Json;

namespace ClintSharp.Json
{
    public static class JsonExtension
    {
        public static string ToJson(this object obj) => JsonConvert.SerializeObject(obj);

        public static string ToJsonF(this object obj) => JsonConvert.SerializeObject(obj, Formatting.Indented);

        public static dynamic FromJson(this string value) => JsonConvert.DeserializeObject(value);
    }
}
