using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
