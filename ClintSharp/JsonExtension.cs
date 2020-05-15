using Newtonsoft.Json;

namespace ClintSharp
{
    public static class JsonExtension
    {
        public static string ToJson(this object obj) => JsonConvert.SerializeObject(obj);

        public static string ToJsonF(this object obj) => JsonConvert.SerializeObject(obj, Formatting.Indented);

        public static dynamic FromJson(this string value) => JsonConvert.DeserializeObject(value);
        
        public static dynamic FromJson<T>(this string value) => JsonConvert.DeserializeObject<T>(value);
    }
}
