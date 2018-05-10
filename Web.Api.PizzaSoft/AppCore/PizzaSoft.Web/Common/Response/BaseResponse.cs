using Newtonsoft.Json;
using System.Collections.Generic;

namespace AppCore.PizzaSoft.Web.Common.Response
{
    [JsonObject]
    public class BaseResponse<T> where T : new()
    {
        [JsonProperty(PropertyName = "success")]
        public bool success { get; set; }

        [JsonProperty(PropertyName = "messages")]
        public List<string> Messages { get; set; }

        [JsonProperty(PropertyName = "data")]
        public T Data {get;set;}
    }
}
