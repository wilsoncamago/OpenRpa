using Newtonsoft.Json;

namespace itsellSharedlibrary.Domain
{
    public class DataInput
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }
}
