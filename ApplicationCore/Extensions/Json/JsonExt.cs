using Newtonsoft.Json;

namespace ApplicationCore.Extensions.Json
{
    public static class JsonExt
    {
        public static string ToJson(this object obj) => JsonConvert.SerializeObject(obj);
    }
}
