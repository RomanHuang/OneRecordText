using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneRecordText.Model.OneRecord
{
    public class booleanType
    {
        [JsonProperty("@type")]
        public string types { get; set; } = "http://www.w3.org/2001/XMLSchema#boolean";
        [JsonProperty("@value")]
        public string value { get; set; }
    }
}
